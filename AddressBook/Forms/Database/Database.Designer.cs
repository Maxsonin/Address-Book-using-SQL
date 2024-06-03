namespace AddressBook
{
    partial class Database
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridView = new DataGridView();
            ReloadButton = new Button();
            AddButton = new Button();
            UpdateButton = new Button();
            searchPrompt = new Label();
            SearchTextBox = new TextBox();
            DeleteButton = new Button();
            SearchByPrompt = new Label();
            comboBoxColumnsToSearch = new ComboBox();
            STTButton = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // DataGridView
            // 
            DataGridView.AllowUserToAddRows = false;
            DataGridView.AllowUserToDeleteRows = false;
            DataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView.BackgroundColor = Color.FromArgb(231, 239, 254);
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(42, 123);
            DataGridView.MinimumSize = new Size(800, 0);
            DataGridView.Name = "DataGridView";
            DataGridView.ReadOnly = true;
            DataGridView.RowHeadersVisible = false;
            DataGridView.Size = new Size(988, 286);
            DataGridView.TabIndex = 0;
            // 
            // ReloadButton
            // 
            ReloadButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReloadButton.Location = new Point(909, 67);
            ReloadButton.Name = "ReloadButton";
            ReloadButton.Size = new Size(120, 50);
            ReloadButton.TabIndex = 12;
            ReloadButton.Text = "RELOAD";
            ReloadButton.UseVisualStyleBackColor = true;
            ReloadButton.Click += ReloadButton_Click;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddButton.Location = new Point(531, 67);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(120, 50);
            AddButton.TabIndex = 13;
            AddButton.Text = "ADD";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateButton.Location = new Point(657, 67);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(120, 50);
            UpdateButton.TabIndex = 14;
            UpdateButton.Text = "UPDATE";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // searchPrompt
            // 
            searchPrompt.AutoSize = true;
            searchPrompt.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchPrompt.Location = new Point(41, 78);
            searchPrompt.Name = "searchPrompt";
            searchPrompt.Size = new Size(114, 29);
            searchPrompt.TabIndex = 15;
            searchPrompt.Text = "Search: ";
            // 
            // SearchTextBox
            // 
            SearchTextBox.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchTextBox.Location = new Point(145, 75);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(380, 37);
            SearchTextBox.TabIndex = 16;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteButton.Location = new Point(783, 67);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(120, 50);
            DeleteButton.TabIndex = 17;
            DeleteButton.Text = "DELETE";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SearchByPrompt
            // 
            SearchByPrompt.AutoSize = true;
            SearchByPrompt.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchByPrompt.Location = new Point(42, 27);
            SearchByPrompt.Name = "SearchByPrompt";
            SearchByPrompt.Size = new Size(151, 29);
            SearchByPrompt.TabIndex = 18;
            SearchByPrompt.Text = "Search by: ";
            // 
            // comboBoxColumnsToSearch
            // 
            comboBoxColumnsToSearch.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxColumnsToSearch.FormattingEnabled = true;
            comboBoxColumnsToSearch.Location = new Point(189, 24);
            comboBoxColumnsToSearch.Name = "comboBoxColumnsToSearch";
            comboBoxColumnsToSearch.Size = new Size(179, 37);
            comboBoxColumnsToSearch.TabIndex = 32;
            // 
            // STTButton
            // 
            STTButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            STTButton.Location = new Point(810, 16);
            STTButton.Name = "STTButton";
            STTButton.Size = new Size(219, 40);
            STTButton.TabIndex = 33;
            STTButton.Text = "Use STT";
            STTButton.UseVisualStyleBackColor = true;
            STTButton.Click += STTButton_Click;
            // 
            // Database
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 239, 254);
            ClientSize = new Size(1070, 437);
            Controls.Add(STTButton);
            Controls.Add(comboBoxColumnsToSearch);
            Controls.Add(SearchByPrompt);
            Controls.Add(DeleteButton);
            Controls.Add(SearchTextBox);
            Controls.Add(searchPrompt);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Controls.Add(ReloadButton);
            Controls.Add(DataGridView);
            Name = "Database";
            Text = "Database";
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridView;
        private Button ReloadButton;
        private Button AddButton;
        private Button UpdateButton;
        private Label searchPrompt;
        private TextBox SearchTextBox;
        private Button DeleteButton;
        private Label SearchByPrompt;
        private ComboBox comboBoxColumnsToSearch;
        private Button STTButton;
    }
}