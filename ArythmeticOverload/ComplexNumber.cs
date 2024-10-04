namespace ArythmeticOverload
{
    public class ComplexNumber
    {
        private double real, imaginary;

        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.real + b.real, a.imaginary + b.imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.real - b.real, a.imaginary - b.imaginary);
        }

        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            double real = a.real * b.real - a.imaginary * b.imaginary;
            double imaginary = a.real * b.imaginary + a.imaginary * b.real;

            return new ComplexNumber(real, imaginary);
        }

        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            double real = (a.real * b.real + a.imaginary * b.imaginary) /
                (b.real * b.real + b.imaginary * b.imaginary);
            double imaginary = (a.real * b.imaginary - a.imaginary * b.real) /
                (b.real * b.real + b.imaginary * b.imaginary);

            return new ComplexNumber(real, -imaginary);
        }

        public override string ToString()
        {
            if (imaginary == 0) return real.ToString();
            return imaginary > 0 ? $"{real}+{imaginary}i" : $"{real}{imaginary}i";
        }
    }
}