using System.Data.SqlClient;
using System.Speech.Recognition;

namespace AddressBook
{
    public partial class Database : Form
    {
        const string DATABASE = "addressbook";
        const string TABLE = "employeesinfo";

        ConnectedSqlDatabase connectedSqlDatabase;

        SpeechRecognitionEngine speechRecognizer;
        private bool isSpeechRecognitionActive = false;

        public Database()
        {
            InitializeComponent();
            connectedSqlDatabase = new ConnectedSqlDatabase(DATABASE);
            DataGridView.DataSource = connectedSqlDatabase.GetDataTable(TABLE);

            comboBoxColumnsToSearch.Items.AddRange(connectedSqlDatabase.GetColumnNames(TABLE).ToArray());
            comboBoxColumnsToSearch.SelectedIndex = 1;

            InitializeSpeechRecognition();
            STTButton.BackColor = Color.Red;
            STTButton.ForeColor = Color.White;
        }

        private void InitializeSpeechRecognition()
        {
            // Initialize the speech recognizer
            speechRecognizer = new SpeechRecognitionEngine();
            speechRecognizer.SetInputToDefaultAudioDevice();
            Grammar grammar = new DictationGrammar();
            speechRecognizer.LoadGrammar(grammar);
            speechRecognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(RecogniseSpeech);
        }

        // Speech Recognition
        private void RecogniseSpeech(object sender, SpeechRecognizedEventArgs e)
        {
            SearchTextBox.AppendText(e.Result.Text);
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            DataGridView.DataSource = connectedSqlDatabase.GetDataTable(TABLE);
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            Add addPopup = new Add(DataGridView);
            addPopup.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = connectedSqlDatabase.GetSqlConnection();

            int employeeToDelateID = 0;
            if (DataGridView.SelectedCells.Count == 1)
            {
                int selectedRow = DataGridView.SelectedCells[0].RowIndex;
                if (selectedRow > -1)
                {
                    employeeToDelateID = Convert.ToInt32(DataGridView.Rows[selectedRow].Cells[0].Value);
                }

                try
                {
                    sqlConnection.Open();
                    string query = $"DELETE FROM {TABLE} WHERE ID = {employeeToDelateID}";

                    SqlCommand cmd = new SqlCommand(query, sqlConnection);

                    int rowDeleted = cmd.ExecuteNonQuery();
                    if (rowDeleted > 0)
                    {
                        MessageBox.Show("Data Successfully Deleted");
                    }
                    else
                    {
                        MessageBox.Show("No records were deleted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                    DataGridView.DataSource = connectedSqlDatabase.GetDataTable(TABLE);
                }

            }
            else
            {
                MessageBox.Show("Select One Employee to Delete");
            }
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

        private void STTButton_Click(object sender, EventArgs e)
        {
            // Toggle speech recognition on or off
            if (!isSpeechRecognitionActive)
            {
                // Start speech recognition
                speechRecognizer.RecognizeAsync(RecognizeMode.Multiple);
                isSpeechRecognitionActive = true;
                STTButton.BackColor = Color.Green;
            }
            else
            {
                // Stop speech recognition
                speechRecognizer.RecognizeAsyncStop();
                isSpeechRecognitionActive = false;
                STTButton.BackColor = Color.Red;
            }
        }
    }
}