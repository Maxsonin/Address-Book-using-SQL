using MySql.Data.MySqlClient;

namespace AddressBook
{
    public partial class Add : Form
    {

        ConnectedMySqlDatabase connectedMySqlDatabase;
        const string DATABASE = "addressbook";
        const string TABLE = "employeesinfo";

        DataGridView dataGridView;

        const int minEmployeeAge = 16;

        public Add(DataGridView dataGridView)
        {
            InitializeComponent();
            this.dataGridView = dataGridView;
            connectedMySqlDatabase = new ConnectedMySqlDatabase(DATABASE);

            comboBoxCity.Items.AddRange(connectedMySqlDatabase.FetchEnumValues(TABLE, "City").ToArray());
            comboBoxPosition.Items.AddRange(connectedMySqlDatabase.FetchEnumValues(TABLE, "Position").ToArray());
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

                    string query = $"INSERT INTO {TABLE} (`Full Name`, City, Street, Position, Age, Married) " +
                                   "VALUES (@FullName, @City, @Street, @Position, @Age, @Married)";

                    MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

                    cmd.Parameters.AddWithValue("@FullName", textBoxFullName.Text);
                    cmd.Parameters.AddWithValue("@City", selectedCity);
                    cmd.Parameters.AddWithValue("@Street", textBoxStreet.Text);
                    cmd.Parameters.AddWithValue("@Position", selectedPosition);
                    cmd.Parameters.AddWithValue("@Age", textBoxAge.Text);
                    cmd.Parameters.AddWithValue("@Married", selectedMarried);

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

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxAge.Text, out _))
            {
                textBoxAge.Text = "";
            }
        }
    }
}
