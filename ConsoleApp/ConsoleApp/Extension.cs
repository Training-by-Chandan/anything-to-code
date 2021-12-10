using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Extension
{
    public static class StringExtension
    {
        public static void IsValid(this string s)
        {
            if (s.Contains("1"))
            {
                Console.WriteLine("not valid");
            }
            else
            {
                Console.WriteLine("Valid");
            }
        }

        public static string AddSpace(this string s, int num, string lastStr)
        {
            for (int i = 0; i < num; i++)
            {
                s += " ";
            }
            s += lastStr;
            return s;
        }

        public static bool IsNonZero(this int i)
        {
            return i != 0;
        }
    }
}
