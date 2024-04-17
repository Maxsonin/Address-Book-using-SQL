using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace AddressBookWeb.Pages.Employees
{
    public class IndexModel : PageModel
    {
        public List<EmployeeInfo> employees = new List<EmployeeInfo>();

        private const string SERVERNAME = "LENOVOLEGION3";
        private const string USERNAME = "admin";
        private const string PASSWORD = "admin1";
        private const string DATABASE = "addressbook";
        private const string TABLE = "employeesinfo";

        public void OnGet()
        {
            try
            {
                string connectionString = $"Data Source={SERVERNAME}; Initial Catalog={DATABASE}; User ID={USERNAME}; Password={PASSWORD}";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string quary = $"SELECT * FROM {TABLE}";
                    using (SqlCommand cmd = new SqlCommand(quary, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EmployeeInfo employeeInfo = new EmployeeInfo();
                                employeeInfo.ID = reader.GetInt32(0);
                                employeeInfo.FullName = reader.GetString(1);
                                employeeInfo.City = reader.GetString(2);
                                employeeInfo.Street = reader.GetString(3);
                                employeeInfo.Position = reader.GetString(4);
                                employeeInfo.Age = reader.GetInt32(5);
                                employeeInfo.Married = reader.GetBoolean(6);

                                employees.Add(employeeInfo);
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }
    }

    public class EmployeeInfo
    {
        public int ID;
        public string FullName;
        public string City;
        public string Street;
        public string Position;
        public int Age;
		public bool Married;
    }
}
