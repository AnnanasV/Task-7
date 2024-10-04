namespace Shapes
{
    public class Triangle
    {
        private float x, y, z;

        public float X { get { return x; } set { if (value > 0) x = value; } }
        public float Y { get { return y; } set { if (value > 0) y = value; } }
        public float Z { get { return z; } set { if (value > 0) z = value; } }

        public float Perimeter()
        {
            return x + y + z;
        }

        public float Area()
        {
            var p = Perimeter();
            return MathF.Sqrt(p * (p - x) * (p - y) * (p - z));
        }

        public override string ToString()
        {
            return $"Triangle.\t x, y, z: {x}, {y}, {z}, area: {Area()}, perimeter: {Perimeter()}";
        }
    }
}
