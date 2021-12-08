using System;

namespace ConsoleApp
{
    public static class StaticClass
    {
        public static int I;
        public static string Name { get; set; }

        public static void SomeFunction()
        {
        }
    }

    public class NonStaticClass
    {
        public static int StaticInt = 0;
        public int I = 0;
        public string Name { get; set; }

        public void SomeFunction()
        {
            I++;
            StaticInt++;
            Console.WriteLine($"I => {I}, StaticInt => {StaticInt} ");
        }

        public static void StaticFunction()
        {
            StaticInt = 20;
        }
    }
}
