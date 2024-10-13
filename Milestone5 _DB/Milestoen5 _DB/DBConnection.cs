using System.Data.SqlClient;

namespace Milestone5_DB
{
    internal class DBConnection
    {

        public static SqlConnection CreateConnection()
        {
            SqlConnection con = new
                SqlConnection("Data Source=8516181D2C415F4;Initial Catalog=SampleDB;Integrated Security=True;");
            return con;
        }

        public static void GetData(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("select * from Users", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine(rdr["ID"] + " | " + rdr["Name"]);
            }
            con.Close();
        }

        public static void InsertData(string Name, SqlConnection con)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"insert into Users(Name) Values('{Name}')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void UpdateData(int ID, string Name, SqlConnection con)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"update Users set EmployeeName ='{Name}' where Id={ID}", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void DeleteData(int ID, SqlConnection con)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"Delete Users  where Id={ID}", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        static void Main(string[] args)
        {
            SqlConnection conn = CreateConnection();
            bool isLoopRunning = true;
            while (isLoopRunning)
            {
                Console.WriteLine("Please enter a choice");
                Console.WriteLine("enter the operation you want to perform \n 1. List Users" +
                    "\n 2. Insert Users \n 3.Update Users \n 4.Delete Users \n 5.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                CreateConnection();

                switch (choice)
                {
                    case 1:
                        GetData(conn);
                        break;
                    case 2:
                        Console.WriteLine("Please enter Name");
                        string employeeName = Console.ReadLine();
                        InsertData(employeeName, conn);
                        Console.WriteLine("Your record is being added successfully !");
                        break;
                    case 3:
                        Console.WriteLine("Please enter ID");
                        int employeeID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter new Name");
                        string newEmployeeName = Console.ReadLine();
                        UpdateData(employeeID, newEmployeeName, conn);
                        Console.WriteLine("Your record is being updated successfully !");
                        break;
                    case 4:
                        Console.WriteLine("Please enter ID");
                        int deleteEmployeeID = Convert.ToInt32(Console.ReadLine());
                        DeleteData(deleteEmployeeID, conn);
                        Console.WriteLine("Your record is being deleted successfully !");
                        break;
                    case 5:
                        isLoopRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter correct choice");
                        break;
                }
            }
        }
    }
}