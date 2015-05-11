using System;

namespace OOP
{
    public class Complex 
    {
        // автоматические свойства, для которых не надо создавать приватных переменных
        //private set означет, что кроме как внутри класс устанавливать значения в эти свойства нельзя
        //get означает, что значение данного свойства можно получить и вне данного класса (отсутствие модификатора доступа эквивалентно public)
        public double Real { get; private set; }
        public double Imaginary { get; private set; }
        
        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public Complex Add(Complex other)
        {
            return new Complex(Real + other.Real, Imaginary + other.Imaginary);
        }

        public Complex Sub(Complex other)
        {
            return new Complex(Real - other.Real, Imaginary - other.Imaginary);
        }

        public Complex Mult(Complex other)
        {
            return new Complex(Real*other.Real - Imaginary*other.Imaginary, Real*other.Imaginary + Imaginary*other.Real);
        }

        public Complex Conjugate()
        {
            return new Complex(Real, Imaginary*(-1));
        }

        public Complex Devide(Complex other)
        {
            var k = other.Real*other.Real + other.Imaginary*other.Imaginary;
            const double tolerance = 0.0001;
            if (Math.Abs(k) < tolerance)
            {
                throw new InvalidOperationException();
            }
            var tmp = Mult(other.Conjugate());

            return new Complex(1/k*tmp.Real, 1/k*tmp.Imaginary);
        }

        public override bool Equals(object obj)
        {
            var other = (Complex) obj;
            const double tolerance = 0.0001;
            return Math.Abs(Real - other.Real) < tolerance && Math.Abs(Imaginary - other.Imaginary) < tolerance;
        }

        //при переопределении метода Equals обычно в паре переопределяют метод GetHashCode, который возвращает целое число, обладающее свойствами
        //если объекты равны, то хэш коды у них равны, если объекты разные, то хэш коды могут и совпасть, 
        //а если хэш коды не совпадают, то объекты разные
        public override int GetHashCode()
        {
            //конструкция unchecked означает, что если внутри, после завершения числовых операций произойдет переполнение
            //( в данном случае, если значения выйдут из диапазона типа int),
            //то не будет выброшено исключение OverflowException
            unchecked
            {
                //операция ^ (xor) исключающее или
                return (Real.GetHashCode() * 397) ^ Imaginary.GetHashCode();
            }
        }

        public override string ToString()
        {
            return string.Format("[ {0} + {1}i ]", Real, Imaginary);
        }
    }
}
