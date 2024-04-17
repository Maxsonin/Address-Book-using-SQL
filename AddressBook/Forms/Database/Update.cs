using System.Data.SqlClient;

namespace AddressBook
{
    public partial class Update : Form
    {
        ConnectedSqlDatabase connectedSqlDatabase;
        const string DATABASE = "addressbook";
        const string TABLE = "employeesinfo";
        readonly int employeeID;

        private const string CITY_ENUM_TABLE = "CityEnum";
        private const string POSITION_ENUM_TABLE = "PositionEnum";

        const int minEmployeeAge = 16;

        DataGridView dataGridView;

        public struct EmployeeInfo
        {
            public string FullName { get; set; }
            public string City { get; set; }
            public string Street { get; set; }
            public string Position { get; set; }
            public int Age { get; set; }
            public bool Married { get; set; }
        }

        public Update(DataGridView dataGridView, int ID)
        {
            InitializeComponent();
            connectedSqlDatabase = new ConnectedSqlDatabase(DATABASE);
            employeeID = ID;

            this.dataGridView = dataGridView;

            comboBoxCity.Items.AddRange(connectedSqlDatabase.GetEnumValues(CITY_ENUM_TABLE, "City").ToArray());
            comboBoxPosition.Items.AddRange(connectedSqlDatabase.GetEnumValues(POSITION_ENUM_TABLE, "Position").ToArray());

            SetValuesToFields(ReadEmployeeInfo(employeeID));
        }

        private EmployeeInfo ReadEmployeeInfo(int ID)
        {
            SqlConnection sqlConnection = connectedSqlDatabase.GetSqlConnection();
            EmployeeInfo employeeInfo = new EmployeeInfo();

            try
            {
                sqlConnection.Open();
                string query = $"SELECT * FROM employeesinfo WHERE ID = '{ID}'";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employeeInfo.FullName = reader["Full Name"].ToString();
                            employeeInfo.City = reader["City"].ToString();
                            employeeInfo.Street = reader["Street"].ToString();
                            employeeInfo.Position = reader["Position"].ToString();
                            employeeInfo.Age = Convert.ToInt32(reader["Age"]);
                            employeeInfo.Married = reader["Married"].ToString().Equals("True", StringComparison.OrdinalIgnoreCase);
                        }
                        else
                        {
                            MessageBox.Show("No data found for the provided ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            return employeeInfo;
        }

        private void SetValuesToFields(EmployeeInfo employeeInfo)
        {
            textBoxFullName.Text = employeeInfo.FullName;
            comboBoxCity.SelectedItem = employeeInfo.City;
            textBoxStreet.Text = employeeInfo.Street;
            comboBoxPosition.SelectedItem = employeeInfo.Position;
            textBoxAge.Text = employeeInfo.Age.ToString();
            checkBoxMerried.Checked = employeeInfo.Married;
        }

        private int ValidInputs()
        {
            if (string.IsNullOrEmpty(textBoxFullName.Text) || comboBoxCity.SelectedItem == null || string.IsNullOrEmpty(textBoxStreet.Text) || comboBoxPosition.SelectedItem == null)
            {
                return -1;
            }
            else if (!int.TryParse(textBoxAge.Text, out int age) || age < minEmployeeAge)
            {
                return -2;
            }

            return 0;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = connectedSqlDatabase.GetSqlConnection();

            int validationResult = ValidInputs();
            if (validationResult == 0)
            {
                string selectedCity = comboBoxCity.SelectedItem.ToString();
                string selectedPosition = comboBoxPosition.SelectedItem.ToString();

                try
                {
                    sqlConnection.Open();

                    string query = $"UPDATE {TABLE} SET [Full Name] = @FullName, City = @City, Street = @Street, Position = @Position, Age = @Age, Married = @Married WHERE ID = @EmployeeID";

                    SqlCommand cmd = new SqlCommand(query, sqlConnection);

                    cmd.Parameters.AddWithValue("@FullName", textBoxFullName.Text);
                    cmd.Parameters.AddWithValue("@City", selectedCity);
                    cmd.Parameters.AddWithValue("@Street", textBoxStreet.Text);
                    cmd.Parameters.AddWithValue("@Position", selectedPosition);
                    cmd.Parameters.AddWithValue("@Age", int.Parse(textBoxAge.Text));
                    cmd.Parameters.AddWithValue("@Married", checkBoxMerried.Checked);
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data Successfully Updated");
                    }
                    else
                    {
                        MessageBox.Show("No records were updated");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                    dataGridView.DataSource = connectedSqlDatabase.GetDataTable(TABLE);
                }
            }
            else if (validationResult == -1)
            {
                MessageBox.Show("All fields should be filled");
            }
            else if (validationResult == -2)
            {
                MessageBox.Show("Age should be a valid number greater than or equal to 16");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e) => Close();
    }
}
