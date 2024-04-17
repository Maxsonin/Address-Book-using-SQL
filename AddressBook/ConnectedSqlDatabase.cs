using System.Data.SqlClient;
using System.Data;

namespace AddressBook
{
    internal class ConnectedSqlDatabase
    {
        private const string SERVERNAME = "LENOVOLEGION3";
        private const string USERNAME = "admin";
        private const string PASSWORD = "admin1";
        private readonly string DATABASE;

        private SqlConnection sqlConnection;

        public ConnectedSqlDatabase(string databaseName)
        {
            DATABASE = databaseName;
            string connectionString = $"Data Source={SERVERNAME}; Initial Catalog={DATABASE}; User ID={USERNAME}; Password={PASSWORD}";
            sqlConnection = new SqlConnection(connectionString);
        }

        public SqlConnection GetSqlConnection() => sqlConnection;

        public DataTable GetDataTable(string tableName)
        {
            DataTable updatedInfoDataTable = new DataTable();
            try
            {
                sqlConnection.Open();
                string query = $"SELECT * FROM {tableName}";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
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
                sqlConnection.Close();
            }

            return updatedInfoDataTable;
        }

        public List<string> GetColumnNames(string tableName)
        {
            List<string> columnNames = new List<string>();
            try
            {
                sqlConnection.Open();
                string query = $"SELECT COLUMN_NAME FROM information_schema.columns WHERE table_name = '{tableName}'";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string columnName = reader.GetString(0);
                            columnNames.Add(columnName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                sqlConnection.Close();
            }

            return columnNames;
        }

        public DataTable SearchDataBy(string tableName, string columnToSearchIn, string valueToSearch)
        {
            DataTable updatedInfoDataTable = new DataTable();
            try
            {
                sqlConnection.Open();
                string query = $"SELECT * FROM {tableName} WHERE [{columnToSearchIn}] LIKE @valueToSearch";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@valueToSearch", $"%{valueToSearch}%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        updatedInfoDataTable.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                sqlConnection.Close();
            }

            return updatedInfoDataTable;
        }

        #region EnumValuesChangers

        public List<string> GetEnumValues(string enumTableName, string enumColumnName)
        {
            List<string> values = new List<string>();

            try
            {
                sqlConnection.Open();
                string query = $"SELECT DISTINCT {enumColumnName} FROM {enumTableName}";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string value = reader[enumColumnName].ToString();
                            values.Add(value);
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
                sqlConnection.Close();
            }

            return values;
        }

        public void AddEnumValue(string enumTableName, string enumColumnName, string valueToAdd)
        {
            try
            {
                sqlConnection.Open();
                string query = $"INSERT INTO {enumTableName} ({enumColumnName}) VALUES (@ValueToAdd)";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@ValueToAdd", valueToAdd);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void DeleteEnumValue(string enumTableName, string enumColumnName, string valueToDelete)
        {
            try
            {
                sqlConnection.Open();
                string query = $"DELETE FROM {enumTableName} WHERE {enumColumnName} = @ValueToDelete";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@ValueToDelete", valueToDelete);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        #endregion EnumValuesEditors
    }
}
