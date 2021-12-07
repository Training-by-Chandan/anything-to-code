﻿using Newtonsoft.Json;
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
                //LoopingStatementV3();
                //ClassesExample();
                //PropertiesExample();
                //OperatorOverloadingExample();
                IndexerExample();
                Console.Write("Do you want to continue more (y/n)? ");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");

            Console.ReadLine();
        }

        private static void IndexerExample()
        {
            OurList ol = new OurList(new string[] { "Sunday", "Monday", "Tuesday" });
            Console.WriteLine(ol[1]);
            ol[1] = "monday";
            ol.Resize(5);
            Console.WriteLine(ol[1]);
        }

        private static void OperatorOverloadingExample()
        {
            int x = 10;
            int y = 20;
            int i = x + y;
            Marks m1 = new Marks(50, 20, 20);
            Marks m2 = new Marks(20, 10, 20);
            var m3 = m1 + m2;
            var m4 = m1 + m3;
            var m5 = m1 + m2 + m3 + m4;
            m1++;
            var marks = m1 + 5;
            m1 = new Marks(10, 10, 20);
            m2 = new Marks(10, 10, 20);
            Console.WriteLine(m1 == m2);
        }

        private static void PropertiesExample()
        {
            int x = 10;
            int y = 20;
            int i = x + y;
            Marks m1 = new Marks(50, 20);
            Marks m2 = new Marks(20, 10);
            var my = new Marks(m1);
            var mx = m1 + m2;
            m1++;
            var marks = m1 + 5;
            Console.WriteLine($"M1  has \nScience => {m1.Science}\nMath => {m1.Math}\nTotal => {m1.Total}\nPercentage => {m1.Percentage}\nDivision => {m1.Division} ");
            Console.WriteLine("=======================================");
            Console.WriteLine($"M2  has \nScience => {m2.Science}\nMath => {m2.Math}\nTotal => {m2.Total}\nPercentage => {m2.Percentage}\nDivision => {m2.Division} ");
            m1.Math = 200;
            Console.WriteLine("=======================================");
            Console.WriteLine(JsonConvert.SerializeObject(m1, Formatting.Indented));
            var m3 = JsonConvert.DeserializeObject<Marks>("{\"Math\":200.0,\"Science\":75.0}");
            Console.WriteLine("=======================================");
            Console.WriteLine($"M3  has \nScience => {m3.Science}\nMath => {m3.Math}\nTotal => {m3.Total}\nPercentage => {m3.Percentage}\nDivision => {m3.Division} ");
        }

        private static void ClassesExample()
        {
            HumanBeing h1 = new HumanBeing();
            HumanBeing h2 = new HumanBeing("Bibash");
            //h2 = new HumanBeing();
            h1 = new HumanBeing("Nabin");
            //h1.RaiseHand();
            h1.RaiseHand("left");
            h1.RaiseHand("right");
            h2.RaiseHand("left");
            h2.RaiseHand("right");
            Console.WriteLine(h1._Name);
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
                    continue;
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
