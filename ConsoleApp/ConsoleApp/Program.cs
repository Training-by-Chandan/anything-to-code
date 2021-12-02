using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    public class Programs
    {
        public static void Main(string[] args)
        {
            //CastingExample();

            //ConditionalStatementExample();

            ArrayExample();

            Console.ReadLine();
        }

        private static void ArrayExample()
        {
            int[] a = new int[5];
            a[1] = 10;
            Array.Resize(ref a, a.Length - 1);
            Array.Reverse(a);
            int[] x = new int[] { 1, 2, 23, 4, -10, 20, 19, 4 };
            int[] y = new int[5];
            Array.Copy(x, 1, y, 2, 2);
            Array.Sort(x);
        }

        private static void ConditionalStatementExample()
        {
            Console.WriteLine("Enter the number");
            var val = Convert.ToInt32(Console.ReadLine());
            string day = "";
            if (val == 1)
            {
                day = "Sunday";
            }
            else if (val == 2)
            {
                day = "Monday";
            }
            else
            {
                day = "Holiday";
            }

            if (val == 1) day = "Sunday";
            else if (val == 2) day = "Monday";
            else day = "Holiday";

            //(Condition) ? <true statement> : <false statement>
            day = (val == 1) ? "Sunday" : (val == 2) ? "Monday" : "Holiday";

            switch (val)
            {
                case 1:
                    day = "Sunday";
                    break;

                case 2:
                    day = "Monday";
                    break;

                default:
                    break;
            }

            string weekend = "";
            if (val == 1 || val == 7)
            {
                weekend = "Its weekend! enjoy";
            }
            else if (val == 2 || val == 3 || val == 4 || val == 5 || val == 6)
            {
                weekend = "Well its weekdays! lets work hard";
            }

            switch (val)
            {
                case 1:
                case 7:
                    weekend = "Its weekend! enjoy";
                    break;

                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    weekend = "Well its weekdays! lets work hard";
                    break;

                default:
                    break;
            }
        }

        private static void CastingExample()
        {
            char c = 'A';
            int i = c;
            long j = i;
            float k = j;
            double l = k;

            short h = (short)c;
            k = (float)l;
            j = (long)k;
            i = (int)j;
            c = (char)i;

            string s = "1";
            i = Convert.ToInt32(s);

            string str = "abc";
            var a = 1;
            // a = Convert.ToInt32("abc"); //not valid (input format exception)
        }
    }
}
