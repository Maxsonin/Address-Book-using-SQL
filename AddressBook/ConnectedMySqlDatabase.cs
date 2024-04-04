using MySql.Data.MySqlClient;
using System.Data;

namespace AddressBook
{
    internal class ConnectedMySqlDatabase
    {
        const string SERVER = "192.168.1.13";
        const string UID = "test";
        const string PWD = "admin1";
        readonly string DATABASE;

        private MySqlConnection mySqlConnection;

        public MySqlConnection GetMySqlConnection() => mySqlConnection;

        public ConnectedMySqlDatabase(string databaseName)
        {
            DATABASE = databaseName;
            string connectionString = $"SERVER={SERVER}; UID={UID}; PWD={PWD}; DATABASE={DATABASE}";
            mySqlConnection = new MySqlConnection(connectionString);
        }

        public DataTable GetDataTable(string tableName)
        {
            DataTable updatedInfoDataTable = new DataTable();
            try
            {
                mySqlConnection.Open();
                string query = $"SELECT * FROM {tableName}";
                using (MySqlCommand cmd = new MySqlCommand(query, mySqlConnection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        updatedInfoDataTable.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mySqlConnection.Close();
            }

            return updatedInfoDataTable;
        }
        
        public List<string> FetchEnumValues(string tableName, string fieldName)
        {
            List<string> enumValues = new List<string>();
            try
            {
                mySqlConnection.Open();
                string query = $"SHOW COLUMNS FROM {tableName} WHERE Field = '{fieldName}'";
                using (MySqlCommand cmd = new MySqlCommand(query, mySqlConnection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    { 
                        if (reader.Read())
                        {
                            string enumValuesString = reader["Type"].ToString();
                            string[] values = enumValuesString.Replace("enum(", "").Replace(")", "").Replace("'", "").Split(',');
                            foreach (string value in values)
                            {
                                enumValues.Add(value.Trim());
                            }
                        }
                        else
                        {
                            MessageBox.Show("No data found for the provided field name.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }

            return enumValues;
        }
    }
}
