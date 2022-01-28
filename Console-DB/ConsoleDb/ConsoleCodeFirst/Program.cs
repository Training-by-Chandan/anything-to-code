using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeFirst
{
    internal class Program
    {
        private static CustomDbContext db = new CustomDbContext();

        private static void Main(string[] args)
        {
            NavigationProperty();
            Console.ReadLine();
        }

        private static void NavigationProperty()
        {
            Console.WriteLine("Enter the class Id");
            var id = Convert.ToInt32(Console.ReadLine());
            var classes = db.Classes.Find(id);
            var teacher = classes.Teachers.FirstOrDefault();
            Console.WriteLine($"Teacher Name : {teacher.Name}");
            Console.WriteLine($"Class Name : {classes.ClassName}");
            Console.WriteLine("\n Info about Students");
            foreach (var item in classes.Students)
            {
                Console.WriteLine($"Student Name : {item.Name}\t\t Email : {item.Email}");
            }
        }
    }
}