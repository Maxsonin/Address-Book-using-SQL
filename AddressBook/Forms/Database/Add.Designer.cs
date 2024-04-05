namespace AddressBook
{
    partial class Add
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
            AddButton = new Button();
            ExitButton = new Button();
            checkBoxMerried = new CheckBox();
            label5 = new Label();
            comboBoxPosition = new ComboBox();
            label4 = new Label();
            comboBoxCity = new ComboBox();
            label3 = new Label();
            textBoxAge = new TextBox();
            label2 = new Label();
            textBoxStreet = new TextBox();
            label1 = new Label();
            textBoxFullName = new TextBox();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddButton.Location = new Point(189, 299);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(128, 51);
            AddButton.TabIndex = 37;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.White;
            ExitButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(55, 299);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(128, 51);
            ExitButton.TabIndex = 36;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // checkBoxMerried
            // 
            checkBoxMerried.AutoSize = true;
            checkBoxMerried.FlatStyle = FlatStyle.System;
            checkBoxMerried.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxMerried.Location = new Point(223, 237);
            checkBoxMerried.Name = "checkBoxMerried";
            checkBoxMerried.Size = new Size(127, 34);
            checkBoxMerried.TabIndex = 35;
            checkBoxMerried.Text = "Married";
            checkBoxMerried.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(55, 159);
            label5.Name = "label5";
            label5.Size = new Size(105, 29);
            label5.TabIndex = 34;
            label5.Text = "Position";
            // 
            // comboBoxPosition
            // 
            comboBoxPosition.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxPosition.FormattingEnabled = true;
            comboBoxPosition.Location = new Point(171, 151);
            comboBoxPosition.Name = "comboBoxPosition";
            comboBoxPosition.Size = new Size(179, 37);
            comboBoxPosition.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(101, 73);
            label4.Name = "label4";
            label4.Size = new Size(59, 29);
            label4.TabIndex = 32;
            label4.Text = "City";
            // 
            // comboBoxCity
            // 
            comboBoxCity.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(171, 65);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(179, 37);
            comboBoxCity.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(102, 202);
            label3.Name = "label3";
            label3.Size = new Size(58, 29);
            label3.TabIndex = 30;
            label3.Text = "Age";
            // 
            // textBoxAge
            // 
            textBoxAge.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAge.Location = new Point(171, 194);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(179, 37);
            textBoxAge.TabIndex = 29;
            textBoxAge.TextChanged += textBoxAge_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 116);
            label2.Name = "label2";
            label2.Size = new Size(85, 29);
            label2.TabIndex = 28;
            label2.Text = "Street";
            // 
            // textBoxStreet
            // 
            textBoxStreet.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxStreet.Location = new Point(171, 108);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(179, 37);
            textBoxStreet.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 30);
            label1.Name = "label1";
            label1.Size = new Size(131, 29);
            label1.TabIndex = 26;
            label1.Text = "Full Name";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFullName.Location = new Point(171, 22);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(179, 37);
            textBoxFullName.TabIndex = 25;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 239, 254);
            ClientSize = new Size(396, 382);
            Controls.Add(AddButton);
            Controls.Add(ExitButton);
            Controls.Add(checkBoxMerried);
            Controls.Add(label5);
            Controls.Add(comboBoxPosition);
            Controls.Add(label4);
            Controls.Add(comboBoxCity);
            Controls.Add(label3);
            Controls.Add(textBoxAge);
            Controls.Add(label2);
            Controls.Add(textBoxStreet);
            Controls.Add(label1);
            Controls.Add(textBoxFullName);
            Name = "Add";
            Text = "Add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Button ExitButton;
        private CheckBox checkBoxMerried;
        private Label label5;
        private ComboBox comboBoxPosition;
        private Label label4;
        private ComboBox comboBoxCity;
        private Label label3;
        private TextBox textBoxAge;
        private Label label2;
        private TextBox textBoxStreet;
        private Label label1;
        private TextBox textBoxFullName;
    }
}