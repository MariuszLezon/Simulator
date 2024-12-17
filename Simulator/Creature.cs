namespace Simulator;

public class Creature
{
    private string _name = "Unknown";
    private int _level = 1;
    private bool _isNameSet = false;
    private bool _isLevelSet = false;

    public string Name
    {
        get => _name;
        set
        {
            if (_isNameSet)
                throw new InvalidOperationException("Name can only be set once.");

            string trimmedName = value.Trim();

            
            if (trimmedName.Length < 3)
                trimmedName = trimmedName.PadRight(3, '#');

            if (trimmedName.Length > 25)
                trimmedName = trimmedName.Substring(0, 25).TrimEnd();

            if (trimmedName.Length < 3)
                trimmedName = trimmedName.PadRight(3, '#');

            if (char.IsLower(trimmedName[0]))
                trimmedName = char.ToUpper(trimmedName[0]) + trimmedName.Substring(1);

            _name = trimmedName;
            _isNameSet = true;
        }
    }

    public int Level
    {
        get => _level;
        set
        {
            
            if (value < 1)
                _level = 1;
            else if (value > 10)
                _level = 10;
            else
                _level = value;

            _isLevelSet = true;
        }
    }

    public Creature(string name = "Unknown", int level = 1)
    {
        Name = name;
        Level = level;
    }

    public Creature() { }

    public void SayHi()
    {
        Console.WriteLine($"Hi, I am {Name} and I am level {Level}.");
    }

    public string Info => $"{Name} <{Level}>";

    public void Upgrade()
    {
        if (Level < 10)
            _level++;
    }

    public void Go(Direction direction)
    {
        
        Console.WriteLine($"{Name} goes {direction.ToString().ToLower()}.");
    }

    public void Go(Direction[] directions)
    {
        
        foreach (var direction in directions)
        {
            Go(direction);
        }
    }

    public void Go(string input)
    {
        
        Direction[] directions = DirectionParser.Parse(input);
        Go(directions);
    }
}
