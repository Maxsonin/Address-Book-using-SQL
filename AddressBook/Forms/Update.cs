using MySql.Data.MySqlClient;

namespace AddressBook
{
    public partial class Update : Form
    {
        ConnectedMySqlDatabase connectedMySqlDatabase;
        const string DATABASE = "addressbook";
        const string TABLE = "employeesinfo";
        readonly int employeeID;

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
            connectedMySqlDatabase = new ConnectedMySqlDatabase(DATABASE);
            employeeID = ID;

            this.dataGridView = dataGridView;

            comboBoxCity.Items.AddRange(connectedMySqlDatabase.FetchEnumValues(TABLE, "City").ToArray());
            comboBoxPosition.Items.AddRange(connectedMySqlDatabase.FetchEnumValues(TABLE, "Position").ToArray());

            SetValuesToFields(ReadEmployeeInfo(employeeID));
        }

        private EmployeeInfo ReadEmployeeInfo(int ID)
        {
            MySqlConnection mySqlConnection = connectedMySqlDatabase.GetMySqlConnection();
            EmployeeInfo employeeInfo = new EmployeeInfo();

            try
            {
                mySqlConnection.Open();
                string query = $"SELECT * FROM employeesinfo WHERE ID = '{ID}'";
                using (MySqlCommand cmd = new MySqlCommand(query, mySqlConnection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employeeInfo.FullName = reader["Full Name"].ToString();
                            employeeInfo.City = reader["City"].ToString();
                            employeeInfo.Street = reader["Street"].ToString();
                            employeeInfo.Position = reader["Position"].ToString();
                            employeeInfo.Age = Convert.ToInt32(reader["Age"]);
                            employeeInfo.Married = reader["Married"].ToString().Equals("Yes", StringComparison.OrdinalIgnoreCase);
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
                mySqlConnection.Close();
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
            MySqlConnection mySqlConnection = connectedMySqlDatabase.GetMySqlConnection();

            int validationResult = ValidInputs();
            if (validationResult == 0)
            {
                string selectedCity = comboBoxCity.SelectedItem.ToString();
                string selectedPosition = comboBoxPosition.SelectedItem.ToString();
                string selectedMarried = checkBoxMerried.Checked ? "Yes" : "No";

                try
                {
                    mySqlConnection.Open();
                    string query = $"UPDATE {TABLE} SET `Full Name` = '{textBoxFullName.Text}', City = '{selectedCity}', Street = '{textBoxStreet.Text}', Position = '{selectedPosition}', Age = '{textBoxAge.Text}', Married = '{selectedMarried}' WHERE ID = '{employeeID}'";
                    MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

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
                    mySqlConnection.Close();
                    dataGridView.DataSource = connectedMySqlDatabase.GetDataTable(TABLE);
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
