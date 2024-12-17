namespace Simulator
{
    public class Animals
    {
        public string Description { get; set; }
        public int Size { get; set; }

        public virtual string Info => $"{Description} <{Size}>";

        public override string ToString()
        {
            return $"{this.GetType().Name.ToUpper()}: {Info}";
        }
    }
}