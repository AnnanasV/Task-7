namespace Shapes
{
    public class Rectangle
    {
        private float x;
        private float y;

        public float X { get { return x; } set { if (value > 0) x = value; } }
        public float Y { get { return y; } set { if (value > 0) y = value; } }

        public float Area()
        {
            return x * y;
        }

        public float Perimeter()
        {
            return x * 2 + y * 2;
        }

        public override string ToString()
        {
            return $"Triangle.\t x, y: {x}, {y}, area: {Area()}, perimeter: {Perimeter()}";
        }
    }
}
