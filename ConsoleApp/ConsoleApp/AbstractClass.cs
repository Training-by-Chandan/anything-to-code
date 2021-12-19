using System;

namespace ConsoleApp
{
    //public class A : B, C // b and c both are interface, b can be class but c is interface, c can be class and b can be interface, but both of them cannot be classes
    //{
    //}
    public abstract class ShapeAbs
    {
        protected double _area, _perimeter;

        public void Area()
        {
            Console.WriteLine($"Area => {_area}");
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter => {_perimeter}");
        }

        public abstract void GetInput();
    }

    public class SquareAbs : ShapeAbs
    {
        private double _length;

        public override void GetInput()
        {
            Console.WriteLine("Enter the length");
            _length = Convert.ToDouble(Console.ReadLine());
            _area = Math.Pow(_length, 2);
            _perimeter = 4 * _length;
        }
    }

    public class RectangleAbs : ShapeAbs
    {
        private double _length, _breadth;

        public override void GetInput()
        {
            Console.WriteLine("Enter the length");
            _length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the breadth");
            _breadth = Convert.ToDouble(Console.ReadLine());
            _area = _length * _breadth;
            _perimeter = 2 * (_length + _breadth);
        }
    }
}
