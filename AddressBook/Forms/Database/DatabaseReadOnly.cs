namespace AddressBook
{
    public partial class DatabaseReadOnly : Form
    {
        ConnectedSqlDatabase connectedSqlDatabase;
        const string DATABASE = "addressbook";
        const string TABLE = "employeesinfo";

        public DatabaseReadOnly()
        {
            InitializeComponent();
            connectedSqlDatabase = new ConnectedSqlDatabase(DATABASE);
            DataGridView.DataSource = connectedSqlDatabase.GetDataTable(TABLE);

            comboBoxColumnsToSearch.Items.AddRange(connectedSqlDatabase.GetColumnNames(TABLE).ToArray());
            comboBoxColumnsToSearch.SelectedIndex = 1;
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            DataGridView.DataSource = connectedSqlDatabase.GetDataTable(TABLE);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchTextBoxText = SearchTextBox.Text;
            string? fieldToSearch = comboBoxColumnsToSearch.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(searchTextBoxText) && !string.IsNullOrEmpty(fieldToSearch))
            {
                DataGridView.DataSource = connectedSqlDatabase.SearchDataBy(TABLE, fieldToSearch, SearchTextBox.Text);
            }
            else
            {
                DataGridView.DataSource = connectedSqlDatabase.GetDataTable(TABLE);
            }
        }
    }
}
