using MySql.Data.MySqlClient;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
namespace AddressBook
{
    public partial class Update : Form
    {
        string server = "192.168.1.13";
        string uid = "test";
        string password = "admin1";
        string database = "addressbook";

        List<string> cities = new List<string>();
        List<string> positions = new List<string>();

        int employeeID;

        public Update(int ID)
        {
            employeeID = ID;

            InitializeComponent();
            FetchEnumValuesFromDatabase("City", cities);
            comboBoxCity.Items.AddRange(cities.ToArray());

            FetchEnumValuesFromDatabase("Position", positions);
            comboBoxPosition.Items.AddRange(positions.ToArray());

            ReadDataFromColumn(ID);
        }

        private void FetchEnumValuesFromDatabase(string fieldName, List<string> arrayToAdd)
        {
            string constring = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);

            try
            {
                con.Open();
                string query = $"SHOW COLUMNS FROM employeesinfo WHERE Field = '{fieldName}'";
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string enumValues = reader["Type"].ToString();
                    string[] parts = enumValues.Replace("enum(", "").Replace(")", "").Replace("'", "").Split(',');
                    foreach (string part in parts)
                    {
                        arrayToAdd.Add(part.Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void ReadDataFromColumn(int ID)
        {
            string constring = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);

            try
            {
                con.Open();
                string query = $"SELECT * FROM employeesinfo WHERE ID = '{ID}'";
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBoxFullName.Text = reader["Full Name"].ToString();
                    comboBoxCity.SelectedItem = reader["City"].ToString();
                    textBoxStreet.Text = reader["Street"].ToString();
                    comboBoxPosition.SelectedItem = reader["Position"].ToString();
                    textBoxAge.Text = reader["Age"].ToString();
                    checkBoxMerried.Checked = reader["Married"].ToString().Equals("Yes", StringComparison.OrdinalIgnoreCase);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No data found for the provided ID.");
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private int ValidInputs()
        {
            if (string.IsNullOrEmpty(textBoxFullName.Text) || comboBoxCity.SelectedItem == null || string.IsNullOrEmpty(textBoxStreet.Text) || comboBoxPosition.SelectedItem == null)
            {
                return -1;
            }

            if (!int.TryParse(textBoxAge.Text, out int age) || age < 16)
            {
                return -2;
            }

            return 0;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int validationResult = ValidInputs();
            if (validationResult == 0)
            {
                string connectionString = $"SERVER={server}; UID={uid}; PWD={password}; DATABASE={database}";
                using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
                {
                    string selectedCity = comboBoxCity.SelectedItem.ToString();
                    string selectedPosition = comboBoxPosition.SelectedItem.ToString();
                    string selectedMarried = checkBoxMerried.Checked ? "Yes" : "No";

                    try
                    {
                        mySqlConnection.Open();
                        string query = $"UPDATE employeesinfo SET `Full Name` = '{textBoxFullName.Text}', City = '{selectedCity}', Street = '{textBoxStreet.Text}', Position = '{selectedPosition}', Age = '{textBoxAge.Text}', Married = '{selectedMarried}' WHERE ID = '{employeeID}'";
                        MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            System.Windows.Forms.MessageBox.Show("Data Successfully Updated");
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("No records were updated");
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        mySqlConnection.Close();
                    }
                }
            }
            else if (validationResult == -1)
            {
                System.Windows.Forms.MessageBox.Show("All fields should be filled");
            }
            else if (validationResult == -2)
            {
                System.Windows.Forms.MessageBox.Show("Age should be a valid number greater than or equal to 16");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
