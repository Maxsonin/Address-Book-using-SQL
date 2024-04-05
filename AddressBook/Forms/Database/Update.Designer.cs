namespace AddressBook
{
    partial class Update
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
            ExitButton = new Button();
            UpdateButton = new Button();
            SuspendLayout();
            // 
            // checkBoxMerried
            // 
            checkBoxMerried.AutoSize = true;
            checkBoxMerried.FlatStyle = FlatStyle.System;
            checkBoxMerried.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxMerried.Location = new Point(227, 248);
            checkBoxMerried.Name = "checkBoxMerried";
            checkBoxMerried.Size = new Size(127, 34);
            checkBoxMerried.TabIndex = 22;
            checkBoxMerried.Text = "Married";
            checkBoxMerried.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(59, 170);
            label5.Name = "label5";
            label5.Size = new Size(105, 29);
            label5.TabIndex = 21;
            label5.Text = "Position";
            // 
            // comboBoxPosition
            // 
            comboBoxPosition.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxPosition.FormattingEnabled = true;
            comboBoxPosition.Location = new Point(175, 162);
            comboBoxPosition.Name = "comboBoxPosition";
            comboBoxPosition.Size = new Size(179, 37);
            comboBoxPosition.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(105, 84);
            label4.Name = "label4";
            label4.Size = new Size(59, 29);
            label4.TabIndex = 19;
            label4.Text = "City";
            // 
            // comboBoxCity
            // 
            comboBoxCity.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(175, 76);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(179, 37);
            comboBoxCity.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(106, 213);
            label3.Name = "label3";
            label3.Size = new Size(58, 29);
            label3.TabIndex = 17;
            label3.Text = "Age";
            // 
            // textBoxAge
            // 
            textBoxAge.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAge.Location = new Point(175, 205);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(179, 37);
            textBoxAge.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 127);
            label2.Name = "label2";
            label2.Size = new Size(85, 29);
            label2.TabIndex = 15;
            label2.Text = "Street";
            // 
            // textBoxStreet
            // 
            textBoxStreet.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxStreet.Location = new Point(175, 119);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(179, 37);
            textBoxStreet.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 41);
            label1.Name = "label1";
            label1.Size = new Size(131, 29);
            label1.TabIndex = 13;
            label1.Text = "Full Name";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFullName.Location = new Point(175, 33);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(179, 37);
            textBoxFullName.TabIndex = 12;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.White;
            ExitButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(59, 310);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(128, 51);
            ExitButton.TabIndex = 23;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateButton.Location = new Point(193, 310);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(128, 51);
            UpdateButton.TabIndex = 24;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 239, 254);
            ClientSize = new Size(400, 382);
            Controls.Add(UpdateButton);
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
            Name = "Update";
            Text = "Update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Button ExitButton;
        private Button UpdateButton;
    }
}