using System;

namespace ConsoleApp
{
    public interface ISOn
    {
    }

    public interface IDaughter
    {
    }

    public interface ITeacher
    {
    }

    public interface IStudent
    {
    }

    public class Bibhas : ISOn, IStudent
    {
    }

    public class Chandan : IStudent, ITeacher, ISOn
    {
    }

    public class Sita : IDaughter, ITeacher
    {
    }

    public interface IArea
    {
        void Area();
    }

    public interface IPerimeter
    {
        void Perimeter();
    }

    public interface IGetInput
    {
        void GetInput();
    }

    public interface IShape : IArea, IPerimeter, IGetInput
    {
    }

    public class Square : IShape
    {
        private double _length;

        public void GetInput()
        {
            Console.WriteLine("Enter the length");
            _length = Convert.ToDouble(Console.ReadLine());
        }

        public void Area()
        {
            Console.WriteLine($"Area => {Math.Pow(_length, 2)}");
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter => {4 * _length}");
        }
    }

    public class Circle : IShape
    {
        private double _radius;

        public void GetInput()
        {
            Console.WriteLine("Enter the Radius");
            _radius = Convert.ToDouble(Console.ReadLine());
        }

        public void Area()
        {
            Console.WriteLine($"Area => {Math.PI * Math.Pow(_radius, 2)}");
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter => {2 * Math.PI * _radius}");
        }
    }

    public class Rectangle : IShape
    {
        private double _length;
        private double _breadth;

        public void GetInput()
        {
            Console.WriteLine("Enter the length");
            _length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the breadth");
            _breadth = Convert.ToDouble(Console.ReadLine());
        }

        public void Area()
        {
            Console.WriteLine($"Area => {_length * _breadth}");
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter => {2 * (_length + _breadth)}");
        }
    }
}
