using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;

namespace AddressBookWeb.Pages.Employees
{
    public class EditModel : PageModel
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
			string id = Request.Query["id"];

			try
			{
				string connectionString = $"Data Source={SERVERNAME}; Initial Catalog={DATABASE}; User ID={USERNAME}; Password={PASSWORD}";
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();
					string quary = $"SELECT * FROM {TABLE} where ID=@ID";
					using (SqlCommand cmd = new SqlCommand(quary, connection))
					{
						cmd.Parameters.AddWithValue("@ID", id);
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								employeeInfo.ID = reader.GetInt32(0);
								employeeInfo.FullName = reader.GetString(1);
								employeeInfo.City = reader.GetString(2);
								employeeInfo.Street = reader.GetString(3);
								employeeInfo.Position = reader.GetString(4);
								employeeInfo.Age = reader.GetInt32(5);
								employeeInfo.Married = reader.GetBoolean(6);
							}
						}
						cmd.ExecuteNonQuery();
					}
					connection.Close();
				}
			}
			catch (Exception ex)
			{
				errorMessage = ex.Message;
			}
		}

		public void OnPost()
		{
			string id = Request.Query["id"];

			cities = GetEnumValues("CityEnum", "City");
			positions = GetEnumValues("PositionEnum", "Position");

			employeeInfo.FullName = Request.Form["name"];
			employeeInfo.City = Request.Form["city"];
			employeeInfo.Street = Request.Form["street"];
			employeeInfo.Position = Request.Form["position"];
			employeeInfo.Age = int.Parse(Request.Form["age"]);
			employeeInfo.Married = Request.Form["married"] == "on" ? true : false;

			if (!isInputValid()) { return; }

			try
			{
				string connectionString = $"Data Source={SERVERNAME}; Initial Catalog={DATABASE}; User ID={USERNAME}; Password={PASSWORD}";
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();
					string query = $"UPDATE {TABLE} SET [Full Name] = @FullName, City = @City, Street = @Street, " +
								   $"Position = @Position, Age = @Age, Married = @Married WHERE ID = @ID";

					using (SqlCommand cmd = new SqlCommand(query, connection))
					{
						cmd.Parameters.AddWithValue("@FullName", employeeInfo.FullName);
						cmd.Parameters.AddWithValue("@City", employeeInfo.City);
						cmd.Parameters.AddWithValue("@Street", employeeInfo.Street);
						cmd.Parameters.AddWithValue("@Position", employeeInfo.Position);
						cmd.Parameters.AddWithValue("@Age", employeeInfo.Age);
						cmd.Parameters.AddWithValue("@Married", employeeInfo.Married);
						cmd.Parameters.AddWithValue("@ID", id);

						cmd.ExecuteNonQuery();
					}
					connection.Close();
				}
			}
			catch (Exception ex)
			{
				errorMessage = ex.Message;
				return;
			}

			Response.Redirect("/Employees/Index");
		}

		private bool isInputValid()
		{
			bool isValid = true;

			if (employeeInfo.Age < MINIMUM_AGE && employeeInfo.Age > MAXIMUM_AGE)
			{
				isValid = false;
				errorMessage = "The employye is to young";
			}

			if (employeeInfo.FullName.Length == 0 || employeeInfo.City.Length == 0 ||
				employeeInfo.Street.Length == 0 || employeeInfo.Position.Length == 0)
			{
				isValid = false;
				errorMessage = "All fields requaired";
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
