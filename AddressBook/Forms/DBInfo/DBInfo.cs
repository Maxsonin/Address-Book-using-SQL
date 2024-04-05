using System.Windows.Forms;

namespace AddressBook.Forms.DBInfo
{
    public partial class DBInfo : Form
    {
        ConnectedMySqlDatabase connectedMySqlDatabase;
        const string DATABASE = "addressbook";
        const string TABLE = "employeesinfo";

        public DBInfo()
        {
            connectedMySqlDatabase = new ConnectedMySqlDatabase(DATABASE);
            InitializeComponent();

            DataGridViewCities.Columns.Add("CityColumn", "City");
            var cityEnumValues = connectedMySqlDatabase.FetchEnumValues(TABLE, "City");
            foreach (var city in cityEnumValues)
            {
                DataGridViewCities.Rows.Add(city.ToString());
            }

            dataGridViewPositions.Columns.Add("PositionColumn", "Position");
            var positionEnumValues = connectedMySqlDatabase.FetchEnumValues(TABLE, "Position");
            foreach (var position in positionEnumValues)
            {
                dataGridViewPositions.Rows.Add(position.ToString());
            }
        }

        private void AddNewCityButton_Click(object sender, EventArgs e)
        {
            string userCityValueToAdd = textBoxNewCity.Text;
            if (!string.IsNullOrEmpty(userCityValueToAdd))
            {
                connectedMySqlDatabase.AddEnumValue(TABLE, "City", textBoxNewCity.Text);
                DataGridViewCities.Rows.Add(userCityValueToAdd);
            }
        }

        private void AddPosButton_Click(object sender, EventArgs e)
        {
            string userPositionValueToAdd = textBoxPosition.Text;
            if (!string.IsNullOrEmpty(userPositionValueToAdd))
            {
                connectedMySqlDatabase.AddEnumValue(TABLE, "Position", textBoxPosition.Text);
                dataGridViewPositions.Rows.Add(userPositionValueToAdd);
            }
        }

        private void DeleteCityButton_Click(object sender, EventArgs e)
        {
            if (DataGridViewCities.SelectedCells.Count == 1)
            {
                string valueToRemove = DataGridViewCities.SelectedCells[0].Value.ToString();
                if (!string.IsNullOrEmpty(valueToRemove))
                {
                    connectedMySqlDatabase.DeleteEnumValue(TABLE, "City", valueToRemove);
                    foreach (DataGridViewRow row in DataGridViewCities.Rows)
                    {
                        if (row.Cells["CityColumn"].Value.ToString() == valueToRemove)
                        {
                            DataGridViewCities.Rows.Remove(row);
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a single cell.");
            }
        }

        private void DeletePositionButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewPositions.SelectedCells.Count == 1)
            {
                string valueToRemove = dataGridViewPositions.SelectedCells[0].Value.ToString();
                if (!string.IsNullOrEmpty(valueToRemove))
                {
                    connectedMySqlDatabase.DeleteEnumValue(TABLE, "Position", valueToRemove);
                    //dataGridViewPositions.Rows.Remove(dataGridViewPositions.SelectedRows[0]);
                    foreach (DataGridViewRow row in DataGridViewCities.Rows)
                    {
                        if (row.Cells["CityColumn"].Value.ToString() == valueToRemove)
                        {
                            DataGridViewCities.Rows.Remove(row);
                            break;
                        }
                    }
                }
            }
            else 
            {
                MessageBox.Show("Please select a single cell.");
            }
        }
    }
}
