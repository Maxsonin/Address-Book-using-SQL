using System.Windows.Forms;

namespace AddressBook.Forms.DBInfo
{
    public partial class DBInfo : Form
    {
        ConnectedSqlDatabase connectedSqlDatabase;
        const string DATABASE = "addressbook";
        const string TABLE = "employeesinfo";

        private const string CITY_ENUM_TABLE = "CityEnum";
        private const string POSITION_ENUM_TABLE = "PositionEnum";

        public DBInfo()
        {
            connectedSqlDatabase = new ConnectedSqlDatabase(DATABASE);
            InitializeComponent();

            DataGridViewCities.Columns.Add("CityColumn", "City");
            var cityEnumValues = connectedSqlDatabase.GetEnumValues(CITY_ENUM_TABLE, "City");
            foreach (var city in cityEnumValues)
            {
                DataGridViewCities.Rows.Add(city.ToString());
            }

            dataGridViewPositions.Columns.Add("PositionColumn", "Position");
            var positionEnumValues = connectedSqlDatabase.GetEnumValues(POSITION_ENUM_TABLE, "Position");
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
                connectedSqlDatabase.AddEnumValue(CITY_ENUM_TABLE, "City", textBoxNewCity.Text);
                DataGridViewCities.Rows.Add(userCityValueToAdd);
            }
        }

        private void AddPosButton_Click(object sender, EventArgs e)
        {
            string userPositionValueToAdd = textBoxPosition.Text;
            if (!string.IsNullOrEmpty(userPositionValueToAdd))
            {
                connectedSqlDatabase.AddEnumValue(POSITION_ENUM_TABLE, "Position", textBoxPosition.Text);
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
                    connectedSqlDatabase.DeleteEnumValue(CITY_ENUM_TABLE, "City", valueToRemove);
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
                    connectedSqlDatabase.DeleteEnumValue(POSITION_ENUM_TABLE, "Position", valueToRemove);
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
