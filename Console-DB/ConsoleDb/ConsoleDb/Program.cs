using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDb
{
    internal class Program
    {
        //connectionstring
        //data source, database, integrated security, userid  password
      
        static void Main(string[] args)
        {
            var res = "Y";
            do
            {
                Console.Clear();
                Console.WriteLine("Enter the Choice\n1 for GetAll records\n2 for Get By Id\n3 Create new record\n4 Update existing record\n5 Delete record");
                var choice =Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ADONet.ReadConsoleTable();
                        break;
                    case 2:
                        ADONet.ReadInfoById();
                        break;
                    case 3:
                        ADONet.CreateInfoRecord();
                        break;
                    case 4:
                        ADONet.EditInfoRecord();
                        break;
                    case 5:
                        ADONet.DeleteInfoRecord();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Do you want to continue more?");
                res= Console.ReadLine();
            }while (res.ToUpper()== "Y");

            Console.ReadLine();
        }
     
    }
}
