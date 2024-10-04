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

        #region overloading Equality
        public static bool operator ==(ComplexNumber a, ComplexNumber b)
        {
            if(Equals(a, b)) return true;
            return false;
        }

        public static bool operator !=(ComplexNumber a, ComplexNumber b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;

            ComplexNumber num = (ComplexNumber)obj;
            return real == num.real && imaginary == num.imaginary;
        }

        public override int GetHashCode()
        {
            return real.GetHashCode() ^ imaginary.GetHashCode();
        }
        #endregion

        public override string ToString()
        {
            if (imaginary == 0) return real.ToString();
            return imaginary > 0 ? $"{real}+{imaginary}i" : $"{real}{imaginary}i";
        }
    }
}