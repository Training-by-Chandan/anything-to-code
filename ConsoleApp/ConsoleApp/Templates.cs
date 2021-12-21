using System;

namespace ConsoleApp
{
    public class TemplateOne<T1, T2>
        where T1 : IShapeLiving

        where T2 : LivingThings
    {
        public T1 x;
        public T1 y;
        public T2 a;
        public T2 b;

        public void DisplayType()
        {
            Console.WriteLine($"type of x is {typeof(T1)}");
            Console.WriteLine($"type of y is {typeof(T1)}");
            Console.WriteLine($"type of a is {typeof(T2)}");
            Console.WriteLine($"type of b is {typeof(T2)}");
        }

        public void GetInput(T1 val1, T2 val2, T1 val3)
        {
        }
    }

    public class NonTemplatedClass
    {
        public static void TemplatedFunction<T1, T2>(T1 x, T2 y)
            where T1 : IShape
            where T2 : LivingThings
        {
        }
    }
}
