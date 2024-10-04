namespace Shapes
{
    public class Circle
    {
        private float radius;
        public float Radius { get { return radius; } set {  if (value > 0) radius = value; } }

        public float Area()
        {
            return MathF.PI * radius * radius;
        }

        public float Length()
        {
            return 2 * radius * MathF.PI;
        }

        public override string ToString()
        {
            return $"Circle.\t radius: {radius}, area: {Area()}, length: {Length()}";
        }
    }
}