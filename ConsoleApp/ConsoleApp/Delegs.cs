using System;

namespace ConsoleApp
{
    public class Delegs
    {
        public delegate void MathDeleg(int a, int b);

        public event MathDeleg MathEvent;

        public void Implementation()
        {
            MathDeleg math = new MathDeleg(Add);
            math(12, 13);
            math += Subtract;
            math(12, 13);
            math += Multiply;
            math(12, 13);
            math += Divide;
            math(12, 13);
            math += (int x, int y) =>
            {
                Console.WriteLine($"Hi My name is {x} and my girlfriend name is {y}");
            };
            math(12, 13);
        }

        public void Modulus(int x, int y)
        {
            Console.WriteLine($"Remainder = {x % y}");
        }

        public void Divide(int x, int y)
        {
            Console.WriteLine($"Quotient = {x / y}");
        }

        public void Multiply(int x, int y)
        {
            Console.WriteLine($"Product = {x * y}");
        }

        public void Subtract(int x, int y)
        {
            Console.WriteLine($"Difference = {x - y}");
        }

        public void Add(int x, int y)
        {
            MathEvent?.Invoke(10, 20);
            Console.WriteLine($"Sum = {x + y}");
        }
    }
}
