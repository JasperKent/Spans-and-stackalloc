namespace Spans
{
    public record struct Point3D(double X, double Y, double Z)
    {
        public override string ToString() => $"({X}, {Y}, {Z})";

        public static Point3D Parse (string input) 
        {
            try
            {
                var items = input.Replace("(", "").Replace(")", "").Split(",");

                return new Point3D(double.Parse(items[0]), double.Parse(items[1]), double.Parse(items[2]));
            }
            catch (Exception e)
            {
                throw new FormatException("Input in incorrect format", e);
            }
        }

        public static Point3D ParseFast(string input)
        {
            try
            {
                ReadOnlySpan<char> chars = input;
                Span<double> coords = stackalloc double[] { 0.0, 0.0, 0.0 };
                Span<char> number = stackalloc char[chars.Length];

                number.Fill(' ');

                int count = 0;
                int pos = 0;

                foreach(char c in chars)
                {
                    if (c == '(')
                        continue;

                    if (c == ',' || c == ')')
                    {
                        coords[count++] = double.Parse(number);

                        pos = 0;

                        number.Fill(' ');

                        continue;
                    }

                    number[pos++] = c;
                }

                return new Point3D(coords[0], coords[1], coords[2]);
            }
            catch (Exception e)
            {
                throw new FormatException("Input in incorrect format", e);
            }
        }
    }
}
