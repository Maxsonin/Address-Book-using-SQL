using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Database : Form
    {
        ConnectedMySqlDatabase connectedMySqlDatabase;
        const string DATABASE = "addressbook";
        const string TABLE = "employeesinfo";

        public Database()
        {
            InitializeComponent();
            connectedMySqlDatabase = new ConnectedMySqlDatabase(DATABASE);
            DataGridView.DataSource = connectedMySqlDatabase.GetDataTable(TABLE);

            comboBoxColumnsToSearch.Items.AddRange(connectedMySqlDatabase.GetColumnNames(TABLE).ToArray());
            comboBoxColumnsToSearch.SelectedIndex = 2;
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            DataGridView.DataSource = connectedMySqlDatabase.GetDataTable(TABLE);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int employeeToUpdateID = 0;
            if (DataGridView.SelectedCells.Count == 1)
            {
                int selectedRow = DataGridView.SelectedCells[0].RowIndex;
                if (selectedRow > -1)
                {
                    employeeToUpdateID = Convert.ToInt32(DataGridView.Rows[selectedRow].Cells[0].Value);
                }

                Update updatePopup = new Update(DataGridView, employeeToUpdateID);
                updatePopup.Show();
            }
            else
            {
                MessageBox.Show("Select One Employee to Update");
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Add addPopup = new Add(DataGridView);
            addPopup.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = connectedMySqlDatabase.GetMySqlConnection();

            int employeeToDelateID = 0;
            if (DataGridView.SelectedCells.Count == 1)
            {
                int selectedRow = DataGridView.SelectedCells[0].RowIndex;
                if (selectedRow > -1)
                {
                    employeeToDelateID = Convert.ToInt32(DataGridView.Rows[selectedRow].Cells[0].Value);
                }

                try
                {
                    mySqlConnection.Open();
                    string query = $"DELETE FROM {TABLE} WHERE ID = {employeeToDelateID}";

                    MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

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
                    mySqlConnection.Close();
                    DataGridView.DataSource = connectedMySqlDatabase.GetDataTable(TABLE);
                }

            }
            else
            {
                MessageBox.Show("Select One Employee to Delete");
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchTextBoxText = SearchTextBox.Text;
            string? fieldToSearch = comboBoxColumnsToSearch.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(searchTextBoxText) && !string.IsNullOrEmpty(fieldToSearch))
            {
                DataGridView.DataSource = connectedMySqlDatabase.SearchData(TABLE, fieldToSearch, SearchTextBox.Text);
            }
            else
            {
                DataGridView.DataSource = connectedMySqlDatabase.GetDataTable(TABLE);
            }
        }
    }
}
