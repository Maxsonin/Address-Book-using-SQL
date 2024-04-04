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
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Database : Form
    {
        string server = "192.168.1.13";
        string uid = "test";
        string password = "admin1";
        string database = "addressbook";
        int port = 3036;

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
            string constring = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);

            try
            {
                con.Open();
                string query = "select * from employeesinfo";
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                DBViewer.DataSource = dt;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close(); // Close the connection when done
            }
        }

    }
}
