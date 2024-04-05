using MySql.Data.MySqlClient;

namespace AddressBook.Forms.LogIn
{
    public partial class LogIn : Form
    {
        ConnectedMySqlDatabase connectedMySqlDatabase;
        const string DATABASE = "addressbook";
        const string TABLE = "accessinfo";

        public LogIn()
        {
            InitializeComponent();
            connectedMySqlDatabase = new ConnectedMySqlDatabase(DATABASE);
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Fill all fields");
            }
            else if (CheckLogIn(TABLE, textBoxLogin.Text, textBoxPassword.Text))
            {
                Hide();
                MainForm main = new MainForm();
                main.FormClosed += (s, args) => this.Close();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid Input or Password");
            }
        }

        public bool CheckLogIn(string tableName, string NAME, string PASSWORD)
        {
            MySqlConnection mySqlConnection = connectedMySqlDatabase.GetMySqlConnection();

            bool valueExists = false;
            try
            {
                string query = $"SELECT COUNT(*) FROM {tableName} WHERE NAME = @NAME AND PASSWORD = @PASSWORD";

                using (MySqlCommand cmd = new MySqlCommand(query, mySqlConnection))
                {
                    cmd.Parameters.AddWithValue("@NAME", NAME);
                    cmd.Parameters.AddWithValue("@PASSWORD", PASSWORD);
                    mySqlConnection.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        valueExists = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }

            return valueExists;
        }
    }
}
