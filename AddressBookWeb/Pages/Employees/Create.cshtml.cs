using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace AddressBookWeb.Pages.Employees
{
    public class CreateModel : PageModel
    {
        public EmployeeInfo employeeInfo = new EmployeeInfo();
        public string errorMessage = "";
        public string successMessage = "";
        private const int MINIMUM_AGE = 16;
		private const int MAXIMUM_AGE = 75;

		private const string SERVERNAME = "LENOVOLEGION3";
		private const string USERNAME = "admin";
		private const string PASSWORD = "admin1";
		private const string DATABASE = "addressbook";
		private const string TABLE = "employeesinfo";

		public List<string> cities;
		public List<string> positions;

		public void OnGet()
		{
			cities = GetEnumValues("CityEnum", "City");
			positions = GetEnumValues("PositionEnum", "Position");
		}


		public void OnPost()
        {
            employeeInfo.FullName = Request.Form["name"];
            employeeInfo.City = Request.Form["city"];
            employeeInfo.Street = Request.Form["street"];
            employeeInfo.Position = Request.Form["position"];
            employeeInfo.Age = int.Parse(Request.Form["age"]);
            employeeInfo.Married = Request.Form["married"] == "on" ? true : false;

			if (!isInputValid())
			{
				return;
			}

			try
			{
				string connectionString = $"Data Source={SERVERNAME}; Initial Catalog={DATABASE}; User ID={USERNAME}; Password={PASSWORD}";
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();
					string quary = $"INSERT INTO {TABLE} ([Full Name], City, Street, Position, Age, Married) VALUES (@FullName, @City, @Sreet, @Position, @Age, @Married)"; ;
					using (SqlCommand cmd = new SqlCommand(quary, connection))
					{
						cmd.Parameters.AddWithValue("@FullName", employeeInfo.FullName);
						cmd.Parameters.AddWithValue("@City", employeeInfo.City);
						cmd.Parameters.AddWithValue("@Sreet", employeeInfo.Street);
						cmd.Parameters.AddWithValue("@Position", employeeInfo.Position);
						cmd.Parameters.AddWithValue("@Age", employeeInfo.Age);
						cmd.Parameters.AddWithValue("@Married", employeeInfo.Married);

						cmd.ExecuteNonQuery();
					}
					connection.Close();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error:" + ex.Message);
			}

			employeeInfo.FullName = ""; employeeInfo.City = ""; employeeInfo.Street = ""; employeeInfo.Position = ""; employeeInfo.Age = MINIMUM_AGE; employeeInfo.Married = false;
            successMessage = "New Employee Added Sucsesfully";

			Response.Redirect("/Employees/Index");
        }

        private bool isInputValid()
        {
            bool isValid = true;

			if (employeeInfo.FullName.Length == 0 || employeeInfo.City.Length == 0 ||
			    employeeInfo.Street.Length == 0 || employeeInfo.Position.Length == 0)
			{
				isValid = false;
				errorMessage = "All fields requaired";
			}

			if (employeeInfo.Age < MINIMUM_AGE || employeeInfo.Age > MAXIMUM_AGE)
			{
				isValid = false;
				errorMessage = "The employye is to young";
			}

            return isValid;
        }

		public List<string> GetEnumValues(string enumTableName, string enumColumnName)
		{
			List<string> values = new List<string>();

			try
			{
				string connectionString = $"Data Source={SERVERNAME}; Initial Catalog={DATABASE}; User ID={USERNAME}; Password={PASSWORD}";
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();
					string quary = $"SELECT DISTINCT {enumColumnName} FROM {enumTableName}";
					using (SqlCommand cmd = new SqlCommand(quary, connection))
					{
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								string value = reader[enumColumnName].ToString();
								values.Add(value);
							}
						}
					}
					connection.Close();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}

			return values;
		}
	}
}
