using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp
{
    public class Programs
    {
        public static void Main(string[] args)
        {
            var res = "N";
            do
            {
                //CastingExample();
                //ConditionalStatementExample();
                //ArrayExample();
                //LoopingStatements();
                //LoopingStatementsV2();
                LoopingStatementV3();
                Console.Write("Do you want to continue more (y/n)? ");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");

            Console.ReadLine();
        }

        private static void LoopingStatementV3()
        {
            string str = "abc";
            string[] arr = new string[] { "Bibash", "Ashwin", "Aakash", "Chandan" };
            Console.WriteLine("using foreach loop");
            //Console.WriteLine(arr[1]);
            int counter = 0;
            foreach (var item in arr)
            {
                counter++;
                Console.WriteLine(item.Length);
            }

            Console.WriteLine("Using for loop");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].Length);
            }

            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine("{0} => {1}", str[i], (int)str[i]);
            //}
        }

        private static void LoopingStatementsV2()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    //TODO: Bibash will add this later
                    break;
                }
                Console.WriteLine(i);
            }

            ////for loop infinite
            //for (; ; )
            //{
            //}
        }

        private static void LoopingStatements()
        {
            ////infinite looping
            //do
            //{
            //} while (true);
            //while (true)
            //{
            //}
            Console.WriteLine("Enter the number of which table needs to be displayed");
            var num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 100; i++)
            {
                var inputs = new string[] { num.ToString(), i.ToString(), (num * i).ToString() };

                var str = string.Format("{0} x {1} = {2}", inputs);
                Console.WriteLine(str);
            }
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
