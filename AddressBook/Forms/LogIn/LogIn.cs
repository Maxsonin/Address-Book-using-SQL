using System.Data.SqlClient;

namespace AddressBook.Forms.LogIn
{
    public partial class LogIn : Form
    {
        private ConnectedSqlDatabase connectedSqlDatabase;
        private const string DATABASE = "addressbook";
        private const string TABLE = "accessinfo";

        public LogIn()
        {
            InitializeComponent();
            connectedSqlDatabase = new ConnectedSqlDatabase(DATABASE);

            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Fill all fields");
            }
            else if (CheckLogIn(TABLE, textBoxLogin.Text, textBoxPassword.Text))
            {
                if (CanModify(TABLE, textBoxLogin.Text, textBoxPassword.Text))
                {
                    Hide();
                    MainForm main = new MainForm();
                    main.FormClosed += (s, args) => Close();
                    main.Show();
                }
                else
                {
                    Hide();
                    MainFormReadOnly main = new MainFormReadOnly();
                    main.FormClosed += (s, args) => Close();
                    main.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid Input or Password");
            }
        }

        private bool CanModify(string tableName, string userName, string password)
        {
            bool canModify = false;
            SqlConnection sqlConnection = connectedSqlDatabase.GetSqlConnection();
            try
            {
                string query = $"SELECT CANMODIFY FROM {tableName} WHERE NAME = @NAME AND PASSWORD = @PASSWORD";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@NAME", userName);
                    cmd.Parameters.AddWithValue("@PASSWORD", password);
                    sqlConnection.Open();
                    string result = cmd.ExecuteScalar().ToString();

                    if (result == "True")
                    {
                        canModify = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            return canModify;
        }

        private bool CheckLogIn(string tableName, string userName, string password)
        {
            bool valueExists = false;
            SqlConnection sqlConnection = connectedSqlDatabase.GetSqlConnection();
            try
            {
                string query = $"SELECT COUNT(*) FROM {tableName} WHERE NAME = @NAME AND PASSWORD = @PASSWORD";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@NAME", userName);
                    cmd.Parameters.AddWithValue("@PASSWORD", password);
                    sqlConnection.Open();
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
                sqlConnection.Close();
            }

            return valueExists;
        }
    }
}
