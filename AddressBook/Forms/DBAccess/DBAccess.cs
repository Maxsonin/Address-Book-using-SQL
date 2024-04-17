using System.Data.SqlClient;

namespace AddressBook.Forms.DBAccess
{
    public partial class DBAccess : Form
    {
        ConnectedSqlDatabase connectedSqlDatabase;
        const string DATABASE = "addressbook";
        const string TABLE = "accessinfo";

        public DBAccess()
        {
            InitializeComponent();
            connectedSqlDatabase = new ConnectedSqlDatabase(DATABASE);
            DataGridView.DataSource = connectedSqlDatabase.GetDataTable(TABLE);
        }

        private int ValidInputs()
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                return -1;
            }
            else if (ValueExistsInTable(TABLE, "NAME", textBoxLogin.Text))
            {
                return -2;
            }

            return 0;
        }

        public bool ValueExistsInTable(string tableName, string columnName, string valueToCheck)
        {
            SqlConnection sqlConnection = connectedSqlDatabase.GetSqlConnection();

            bool valueExists = false;
            try
            {
                string query = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = @ValueToCheck";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@ValueToCheck", valueToCheck);
                    sqlConnection.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        valueExists = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            return valueExists;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = connectedSqlDatabase.GetSqlConnection();

            int validationResult = ValidInputs();
            if (validationResult == 0)
            {
                try
                {
                    sqlConnection.Open();

                    string query = $"INSERT INTO {TABLE} (NAME, PASSWORD, CANMODIFY) " +
                                   "VALUES (@NAME, @PASSWORD, @CANMODIFY)";

                    SqlCommand cmd = new SqlCommand(query, sqlConnection);
                   
                    cmd.Parameters.AddWithValue("@NAME", textBoxLogin.Text);
                    cmd.Parameters.AddWithValue("@PASSWORD", textBoxPassword.Text);
                    cmd.Parameters.AddWithValue("@CANMODIFY", checkBoxCANMODIFY.Checked);

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
                    DataGridView.DataSource = connectedSqlDatabase.GetDataTable(TABLE);
                }
            }
            else if (validationResult == -1)
            {
                MessageBox.Show("All fields should be filled");
            }
            else if (validationResult == -2)
            {
                MessageBox.Show("Name is Already in use");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = connectedSqlDatabase.GetSqlConnection();

            string userToDelateNAME = "";
            if (DataGridView.SelectedCells.Count == 1)
            {
                int selectedRow = DataGridView.SelectedCells[0].RowIndex;
                if (selectedRow > -1)
                {
                    userToDelateNAME = DataGridView.Rows[selectedRow].Cells[0].Value.ToString();
                }

                try
                {
                    sqlConnection.Open();
                    string query = $"DELETE FROM {TABLE} WHERE NAME = '{userToDelateNAME}'";

                    SqlCommand cmd = new SqlCommand(query, sqlConnection);

                    int rowDeleted = cmd.ExecuteNonQuery();
                    if (rowDeleted > 0)
                    {
                        MessageBox.Show("Data Successfully Deleted");
                    }
                    else
                    {
                        MessageBox.Show("No records were deleted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                    DataGridView.DataSource = connectedSqlDatabase.GetDataTable(TABLE);
                }
            }
            else
            {
                MessageBox.Show("Select One Employee to Delete");
            }
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            DataGridView.DataSource = connectedSqlDatabase.GetDataTable(TABLE);
        }
    }
}
