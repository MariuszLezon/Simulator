namespace Simulator
{
    public static class Validator
    {
        public static int Limiter(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        public static string Shortener(string value, int min, int max, char placeholder)
        {
            if (value.Length < min) return new string(placeholder, min - value.Length) + value;
            if (value.Length > max) return value.Substring(0, max);
            return value;
        }
    }
}
