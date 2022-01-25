using ConsoleDb.ORM.DbFirst;
using System;
using System.Linq;

namespace ConsoleDb
{
    public class DbFirstInfo
    {
        private static ConsoleEntities db=new ConsoleEntities();
        public static void ReadConsoleTable()
        {
            var data = db.Infoes.ToList();
            foreach (var item in data)
            {
                Console.WriteLine(item.Id + ". " + item.first_name + " " + item.last_name);
            }
        }
        public static void CreateInfoRecord()
        {
            var obj = new Info();
            Console.WriteLine("Enter firstname");
            obj.first_name = Console.ReadLine();
            Console.WriteLine("Enter lastname");
            obj.last_name = Console.ReadLine();
            Console.WriteLine("Enter email");
            obj.email = Console.ReadLine();
            Console.WriteLine("Enter gender");
            obj.gender = Console.ReadLine();
            Console.WriteLine("Enter ip address");
            obj.ip_address = Console.ReadLine();

            db.Infoes.Add(obj);
            db.SaveChanges();

        }
        public static void EditInfoRecord()
        {

            Console.WriteLine("Enter Id");
            var id = Convert.ToInt32(Console.ReadLine());
            var existing = db.Infoes.Find(id);
            if (existing != null)
            {
                Console.WriteLine("Enter firstname");
                var firstname = Console.ReadLine();
                existing.first_name = string.IsNullOrWhiteSpace(firstname)?existing.first_name: firstname;
                existing.first_name = Console.ReadLine();
                Console.WriteLine("Enter lastname");
                existing.last_name = Console.ReadLine();
                Console.WriteLine("Enter email");
                existing.email = Console.ReadLine();
                Console.WriteLine("Enter gender");
                existing.gender = Console.ReadLine();
                Console.WriteLine("Enter ip address");
                existing.ip_address = Console.ReadLine();

                db.Entry(existing).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Data not found");
            }

        }

        public static void DeleteInfoRecord()
        {
            Console.WriteLine("Enter Id");
            var id = Convert.ToInt32(Console.ReadLine());
            var existing = db.Infoes.Find(id);
            if (existing != null)
            {
                db.Infoes.Remove(existing);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Data not found");
            }
        }
        public static void ReadInfoById()
        {

            Console.WriteLine("Enter Id");
            var id = Convert.ToInt32(Console.ReadLine());
            var existing = db.Infoes.Find(id);
            if (existing != null)
            {
                Console.WriteLine($"Firstname : {existing.first_name}");
                Console.WriteLine($"Lastname : {existing.last_name}");
                Console.WriteLine($"Email : {existing.email}");
                Console.WriteLine($"Gender : {existing.gender}");
                Console.WriteLine($"Ipaddress : {existing.ip_address}");
            }
            else
            {
                Console.WriteLine("Data not found");
            }
        }
    }
}
