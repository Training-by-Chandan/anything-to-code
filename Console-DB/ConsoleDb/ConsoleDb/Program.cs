using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ConsoleDb
{
    internal class Program
    {
        //connectionstring
        //data source, database, integrated security, userid  password
        static string conStr = "Data Source=DESKTOP-PT71T7O\\SQLCHANDAN;Initial Catalog=Console;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
                        ReadConsoleTable();
                        break;
                    case 2:
                        ReadInfoById();
                        break;
                    case 3:
                        CreateInfoRecord();
                        break;
                    case 4:
                        EditInfoRecord();
                        break;
                    case 5:
                        DeleteInfoRecord();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Do you want to continue more?");
                res= Console.ReadLine();
            }while (res.ToUpper()== "Y");

            Console.ReadLine();
        }
        static void ReadConsoleTable()
        {
            //create the sql connection object
            SqlConnection con = new SqlConnection(conStr);

            //define the query
            string query = "Select * from Info";

            //create the sqlcommand object
            SqlCommand cmd=new SqlCommand(query, con);

            //open the connection
            con.Open();

            //execute the command
            var res = cmd.ExecuteReader();
            while (res.Read())
            {
                //todo our work
                var id = res.GetInt32(0);
                var firstname=res.GetString(1);
                var lastname=res.GetString(2);

                Console.WriteLine(id+". "+ firstname+" "+lastname);
            }
            //close the conenction
            con.Close();

        }

        static void CreateInfoRecord()
        {
            Console.WriteLine("Enter firstname");
            var firstname = Console.ReadLine();
            Console.WriteLine("Enter lastname");
            var lastname = Console.ReadLine();
            Console.WriteLine("Enter email");
            var email = Console.ReadLine();
            Console.WriteLine("Enter gender");
            var gender = Console.ReadLine();
            Console.WriteLine("Enter ip address");
            var ipaddress = Console.ReadLine();
            //create the sql connection object
            SqlConnection con = new SqlConnection(conStr);

            //define the query
            string query = $"insert into info (first_name, last_name,email,gender, ip_address) values ('{firstname}','{lastname}','{email}','{gender}','{ipaddress}')";

            //create the sqlcommand object
            SqlCommand cmd = new SqlCommand(query, con);

            //open the connection
            con.Open();

            //execute the command
            var res = cmd.ExecuteNonQuery();
           
            //close the conenction
            con.Close();
        }
        static void EditInfoRecord()
        {
            Console.WriteLine("Enter Id");
            var id = Console.ReadLine();
            
            Console.WriteLine("Enter firstname");
            var firstname = Console.ReadLine();
            Console.WriteLine("Enter lastname");
            var lastname = Console.ReadLine();
            Console.WriteLine("Enter email");
            var email = Console.ReadLine();
            Console.WriteLine("Enter gender");
            var gender = Console.ReadLine();
            Console.WriteLine("Enter ip address");
            var ipaddress = Console.ReadLine();
            //create the sql connection object
            SqlConnection con = new SqlConnection(conStr);

            //define the query
            string query = $"update info set first_name ='{firstname}', last_name='{lastname}', email ='{email}', gender='{gender}', ip_address='{ipaddress}' where id={id}";

            //create the sqlcommand object
            SqlCommand cmd = new SqlCommand(query, con);

            //open the connection
            con.Open();

            //execute the command
            var res = cmd.ExecuteNonQuery();

            //close the conenction
            con.Close();
        }

        static void DeleteInfoRecord()
        {
            Console.WriteLine("Enter Id");
            var id = Console.ReadLine();

            
            //create the sql connection object
            SqlConnection con = new SqlConnection(conStr);

            //define the query
            string query = $"delete from info where id={id}";

            //create the sqlcommand object
            SqlCommand cmd = new SqlCommand(query, con);

            //open the connection
            con.Open();

            //execute the command
            var res = cmd.ExecuteNonQuery();

            //close the conenction
            con.Close();
        }
        static void ReadInfoById()
        {
            Console.WriteLine("Enter Id");
            var id = Console.ReadLine();

            //create the sql connection object
            SqlConnection con = new SqlConnection(conStr);

            //define the query
            string query = $"Select * from Info where id = {id}";

            //create the sqlcommand object
            SqlCommand cmd = new SqlCommand(query, con);

            //open the connection
            con.Open();

            //execute the command
            var res = cmd.ExecuteReader();
            while (res.Read())
            {
                //todo our work
               
                var firstname = res.GetString(1);
                var lastname = res.GetString(2);
                var email= res.GetString(3);
                var gender= res.GetString(4);
                var ipaddress= res.GetString(5);

                Console.WriteLine($"Firstname : {firstname}");
                Console.WriteLine($"Lastname : {lastname}");
                Console.WriteLine($"Email : {email}");
                Console.WriteLine($"Gender : {gender}");
                Console.WriteLine($"Ipaddress : {ipaddress}");
            }
            //close the conenction
            con.Close();

        }
    }
}
