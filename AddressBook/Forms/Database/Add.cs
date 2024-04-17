using System.Data.SqlClient;

namespace AddressBook
{
    public partial class Add : Form
    {
        private const string DATABASE = "addressbook";
        private const string TABLE = "employeesinfo";
        private const string CITY_ENUM_TABLE = "CityEnum";
        private const string POSITION_ENUM_TABLE = "PositionEnum";

        private ConnectedSqlDatabase connectedSqlDatabase;

        private DataGridView dataGridView;

        private const int minEmployeeAge = 16;

        public Add(DataGridView dataGridView)
        {
            InitializeComponent();
            this.dataGridView = dataGridView;
            connectedSqlDatabase = new ConnectedSqlDatabase(DATABASE);

            comboBoxCity.Items.AddRange(connectedSqlDatabase.GetEnumValues(CITY_ENUM_TABLE, "City").ToArray());
            comboBoxPosition.Items.AddRange(connectedSqlDatabase.GetEnumValues(POSITION_ENUM_TABLE, "Position").ToArray());
        }

        private void ExitButton_Click(object sender, EventArgs e) => Close();

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

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxAge.Text, out _))
            {
                textBoxAge.Text = "";
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
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

                    string query = $"INSERT INTO {TABLE} ([Full Name], City, Street, Position, Age, Married) VALUES (@FullName, @City, @Street, @Position, @Age, @Married)";

                    SqlCommand cmd = new SqlCommand(query, sqlConnection);

                    cmd.Parameters.AddWithValue("@FullName", textBoxFullName.Text);
                    cmd.Parameters.AddWithValue("@City", selectedCity);
                    cmd.Parameters.AddWithValue("@Street", textBoxStreet.Text);
                    cmd.Parameters.AddWithValue("@Position", selectedPosition);
                    cmd.Parameters.AddWithValue("@Age", int.Parse(textBoxAge.Text));
                    cmd.Parameters.AddWithValue("@Married", checkBoxMerried.Checked);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data Successfully Added");
                    }
                    else
                    {
                        MessageBox.Show("No elements were added");
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
    }
}
