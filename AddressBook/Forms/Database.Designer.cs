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
            DBViewer = new DataGridView();
            textBoxFullName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxStreet = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            comboBoxCity = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            comboBoxAge = new ComboBox();
            checkBoxMerried = new CheckBox();
            ReloadButton = new Button();
            AddButton = new Button();
            UpdateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)DBViewer).BeginInit();
            SuspendLayout();
            // 
            // DBViewer
            // 
            DBViewer.AllowUserToAddRows = false;
            DBViewer.AllowUserToDeleteRows = false;
            DBViewer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DBViewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DBViewer.Location = new Point(366, 162);
            DBViewer.Name = "DBViewer";
            DBViewer.ReadOnly = true;
            DBViewer.Size = new Size(402, 259);
            DBViewer.TabIndex = 0;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFullName.Location = new Point(154, 12);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(179, 37);
            textBoxFullName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(131, 29);
            label1.TabIndex = 2;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 106);
            label2.Name = "label2";
            label2.Size = new Size(85, 29);
            label2.TabIndex = 4;
            label2.Text = "Street";
            // 
            // textBoxStreet
            // 
            textBoxStreet.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxStreet.Location = new Point(154, 98);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(179, 37);
            textBoxStreet.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(85, 192);
            label3.Name = "label3";
            label3.Size = new Size(58, 29);
            label3.TabIndex = 6;
            label3.Text = "Age";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(154, 184);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(179, 37);
            textBox3.TabIndex = 5;
            // 
            // comboBoxCity
            // 
            comboBoxCity.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(154, 55);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(179, 37);
            comboBoxCity.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(84, 63);
            label4.Name = "label4";
            label4.Size = new Size(59, 29);
            label4.TabIndex = 8;
            label4.Text = "City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(85, 149);
            label5.Name = "label5";
            label5.Size = new Size(58, 29);
            label5.TabIndex = 10;
            label5.Text = "Age";
            // 
            // comboBoxAge
            // 
            comboBoxAge.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxAge.FormattingEnabled = true;
            comboBoxAge.Location = new Point(154, 141);
            comboBoxAge.Name = "comboBoxAge";
            comboBoxAge.Size = new Size(179, 37);
            comboBoxAge.TabIndex = 9;
            // 
            // checkBoxMerried
            // 
            checkBoxMerried.AutoSize = true;
            checkBoxMerried.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxMerried.Location = new Point(212, 227);
            checkBoxMerried.Name = "checkBoxMerried";
            checkBoxMerried.Size = new Size(121, 33);
            checkBoxMerried.TabIndex = 11;
            checkBoxMerried.Text = "Merried";
            checkBoxMerried.UseVisualStyleBackColor = true;
            // 
            // ReloadButton
            // 
            ReloadButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReloadButton.Location = new Point(648, 106);
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
            AddButton.Location = new Point(366, 106);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(120, 50);
            AddButton.TabIndex = 13;
            AddButton.Text = "ADD";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            UpdateButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateButton.Location = new Point(509, 106);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(120, 50);
            UpdateButton.TabIndex = 14;
            UpdateButton.Text = "UPDATE";
            UpdateButton.UseVisualStyleBackColor = true;
            // 
            // Database
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Controls.Add(ReloadButton);
            Controls.Add(checkBoxMerried);
            Controls.Add(label5);
            Controls.Add(comboBoxAge);
            Controls.Add(label4);
            Controls.Add(comboBoxCity);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBoxStreet);
            Controls.Add(label1);
            Controls.Add(textBoxFullName);
            Controls.Add(DBViewer);
            Name = "Database";
            Text = "Database";
            ((System.ComponentModel.ISupportInitialize)DBViewer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DBViewer;
        private TextBox textBoxFullName;
        private Label label1;
        private Label label2;
        private TextBox textBoxStreet;
        private Label label3;
        private TextBox textBox3;
        private ComboBox comboBoxCity;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxAge;
        private CheckBox checkBoxMerried;
        private Button ReloadButton;
        private Button AddButton;
        private Button UpdateButton;
    }
}