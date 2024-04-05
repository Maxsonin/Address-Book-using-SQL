using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class DatabaseReadOnly : Form
    {
        ConnectedMySqlDatabase connectedMySqlDatabase;
        const string DATABASE = "addressbook";
        const string TABLE = "employeesinfo";

        public DatabaseReadOnly()
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
