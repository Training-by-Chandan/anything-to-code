using ConsoleDb.ORM.DbFirst;
using System;
using System.Linq;

namespace ConsoleDb
{
    public class DbFirstOrder
    {
        private static ConsoleEntities db=new ConsoleEntities();
        public static void ReadConsoleTable()
        {
            var data = db.OrderDetails.ToList();
            foreach (var item in data)
            {
                Console.WriteLine(item.Id + ". " + item.ProductName + " " + item.Price+" "+ item.Quantity+" "+item.Price*item.Quantity);
            }
        }
        public static void CreateInfoRecord()
        {
            var obj = new OrderDetail();
            Console.WriteLine("Enter Info Id");
            obj.InfoId = Convert.ToInt32(Console.ReadLine());
            var existingInfo = db.Infoes.Find(obj.InfoId);
            if (existingInfo!=null)
            {

                Console.WriteLine("Enter ProductName");
                obj.ProductName = Console.ReadLine();
                Console.WriteLine("Enter Price");
                obj.Price = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter Quantity");
                obj.Quantity = Convert.ToInt32(Console.ReadLine());
           

                db.OrderDetails.Add(obj);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Info with that id not found");
            }

        }
        public static void EditInfoRecord()
        {

            //Console.WriteLine("Enter Id");
            //var id = Convert.ToInt32(Console.ReadLine());
            //var existing = db.Infoes.Find(id);
            //if (existing != null)
            //{
            //    Console.WriteLine("Enter firstname");
            //    existing.first_name = Console.ReadLine();
            //    Console.WriteLine("Enter lastname");
            //    existing.last_name = Console.ReadLine();
            //    Console.WriteLine("Enter email");
            //    existing.email = Console.ReadLine();
            //    Console.WriteLine("Enter gender");
            //    existing.gender = Console.ReadLine();
            //    Console.WriteLine("Enter ip address");
            //    existing.ip_address = Console.ReadLine();

            //    db.Entry(existing).State = System.Data.Entity.EntityState.Modified;
            //    db.SaveChanges();
            //}
            //else
            //{
            //    Console.WriteLine("Data not found");
            //}

        }

        public static void DeleteInfoRecord()
        {
            //Console.WriteLine("Enter Id");
            //var id = Convert.ToInt32(Console.ReadLine());
            //var existing = db.Infoes.Find(id);
            //if (existing != null)
            //{
            //    db.Infoes.Remove(existing);
            //    db.SaveChanges();
            //}
            //else
            //{
            //    Console.WriteLine("Data not found");
            //}
        }
        public static void ReadInfoById()
        {

            //Console.WriteLine("Enter Id");
            //var id = Convert.ToInt32(Console.ReadLine());
            //var existing = db.Infoes.Find(id);
            //if (existing != null)
            //{
            //    Console.WriteLine($"Firstname : {existing.first_name}");
            //    Console.WriteLine($"Lastname : {existing.last_name}");
            //    Console.WriteLine($"Email : {existing.email}");
            //    Console.WriteLine($"Gender : {existing.gender}");
            //    Console.WriteLine($"Ipaddress : {existing.ip_address}");
            //}
            //else
            //{
            //    Console.WriteLine("Data not found");
            //}
        }
    }
}
