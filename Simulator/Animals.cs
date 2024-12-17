namespace Simulator;

public class Animals
{
    private string _description = "Default"; 

    public required string Description
    {
        get => _description;
        init
        {
            
            string trimmedDescription = value.Trim();

            
            if (trimmedDescription.Length < 3)
                trimmedDescription = trimmedDescription.PadRight(3, '#');

            
            if (trimmedDescription.Length > 15)
                trimmedDescription = trimmedDescription.Substring(0, 15).TrimEnd();

            
            if (char.IsLower(trimmedDescription[0]))
                trimmedDescription = char.ToUpper(trimmedDescription[0]) + trimmedDescription.Substring(1);

            _description = trimmedDescription;
        }
    }

    public uint Size { get; set; } = 3;

    public string Info => $"{Description} <{Size}>";
}
