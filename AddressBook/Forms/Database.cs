using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AddressBook
{
    public partial class Database : Form
    {
        string server = "192.168.1.13";
        string uid = "test";
        string password = "admin1";
        string database = "addressbook";

        public Database()
        {
            InitializeComponent();
            ReloadDB();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            ReloadDB();
        }

        private void ReloadDB()
        {
            string connectionString = $"SERVER={server}; UID={uid}; PWD={password}; DATABASE={database}";
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

            try
            {
                mySqlConnection.Open();
                string query = "SELECT * FROM employeesinfo";
                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                DBViewer.DataSource = dt;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int cellcalue = 0;
            if (DBViewer.SelectedCells.Count > 0)
            {
                int selectedRow = DBViewer.SelectedCells[0].RowIndex;
                if (selectedRow > -1)
                {
                    var num = DBViewer.Rows[selectedRow].Cells[0].Value;
                    cellcalue = Convert.ToInt32(num);
                }
            }

            Update updatePopup = new Update(cellcalue);
            updatePopup.Show();
        }
    }
}
