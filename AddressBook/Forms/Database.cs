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
    }
}
