namespace AddressBook.Forms.DBAccess
{
    partial class DBAccess
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
            DeleteButton = new Button();
            AddButton = new Button();
            ReloadButton = new Button();
            DataGridView = new DataGridView();
            label1 = new Label();
            textBoxLogin = new TextBox();
            label2 = new Label();
            textBoxPassword = new TextBox();
            checkBoxCANMODIFY = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteButton.Location = new Point(542, 54);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(120, 50);
            DeleteButton.TabIndex = 21;
            DeleteButton.Text = "DELETE";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddButton.Location = new Point(104, 300);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(120, 50);
            AddButton.TabIndex = 20;
            AddButton.Text = "ADD";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ReloadButton
            // 
            ReloadButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReloadButton.Location = new Point(668, 54);
            ReloadButton.Name = "ReloadButton";
            ReloadButton.Size = new Size(120, 50);
            ReloadButton.TabIndex = 19;
            ReloadButton.Text = "RELOAD";
            ReloadButton.UseVisualStyleBackColor = true;
            ReloadButton.Click += ReloadButton_Click;
            // 
            // DataGridView
            // 
            DataGridView.AllowUserToAddRows = false;
            DataGridView.AllowUserToDeleteRows = false;
            DataGridView.BackgroundColor = Color.FromArgb(231, 239, 254);
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(355, 110);
            DataGridView.Name = "DataGridView";
            DataGridView.ReadOnly = true;
            DataGridView.RowHeadersVisible = false;
            DataGridView.Size = new Size(430, 286);
            DataGridView.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 147);
            label1.Name = "label1";
            label1.Size = new Size(77, 29);
            label1.TabIndex = 23;
            label1.Text = "Login";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLogin.Location = new Point(151, 139);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(179, 37);
            textBoxLogin.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 201);
            label2.Name = "label2";
            label2.Size = new Size(126, 29);
            label2.TabIndex = 25;
            label2.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(151, 193);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(179, 37);
            textBoxPassword.TabIndex = 24;
            // 
            // checkBoxCANMODIFY
            // 
            checkBoxCANMODIFY.AutoSize = true;
            checkBoxCANMODIFY.FlatStyle = FlatStyle.System;
            checkBoxCANMODIFY.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxCANMODIFY.Location = new Point(151, 246);
            checkBoxCANMODIFY.Name = "checkBoxCANMODIFY";
            checkBoxCANMODIFY.Size = new Size(170, 34);
            checkBoxCANMODIFY.TabIndex = 26;
            checkBoxCANMODIFY.Text = "Can Modify";
            checkBoxCANMODIFY.UseVisualStyleBackColor = true;
            // 
            // DBAccess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 239, 254);
            ClientSize = new Size(797, 450);
            Controls.Add(checkBoxCANMODIFY);
            Controls.Add(label2);
            Controls.Add(textBoxPassword);
            Controls.Add(label1);
            Controls.Add(textBoxLogin);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(ReloadButton);
            Controls.Add(DataGridView);
            Name = "DBAccess";
            Text = "DBAccess";
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteButton;
        private Button AddButton;
        private Button ReloadButton;
        private DataGridView DataGridView;
        private Label label1;
        private TextBox textBoxLogin;
        private Label label2;
        private TextBox textBoxPassword;
        private CheckBox checkBoxCANMODIFY;
    }
}