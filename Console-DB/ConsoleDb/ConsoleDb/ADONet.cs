using System;
using System.Data.SqlClient;

namespace ConsoleDb
{
    public class ADONet
    {
        static string conStr = "Data Source=DESKTOP-PT71T7O\\SQLCHANDAN;Initial Catalog=Console;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static void ReadConsoleTable()
        {
            //create the sql connection object
            SqlConnection con = new SqlConnection(conStr);

            //define the query
            string query = "Select * from Info";

            //create the sqlcommand object
            SqlCommand cmd = new SqlCommand(query, con);

            //open the connection
            con.Open();

            //execute the command
            var res = cmd.ExecuteReader();
            while (res.Read())
            {
                //todo our work
                var id = res.GetInt32(0);
                var firstname = res.GetString(1);
                var lastname = res.GetString(2);

                Console.WriteLine(id + ". " + firstname + " " + lastname);
            }
            //close the conenction
            con.Close();

        }

        public static void CreateInfoRecord()
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
        public static void EditInfoRecord()
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

        public static void DeleteInfoRecord()
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
        public static void ReadInfoById()
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
                var email = res.GetString(3);
                var gender = res.GetString(4);
                var ipaddress = res.GetString(5);

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
