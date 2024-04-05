namespace AddressBook.Forms.LogIn
{
    partial class LogIn
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
            label2 = new Label();
            textBoxPassword = new TextBox();
            label1 = new Label();
            textBoxLogin = new TextBox();
            LogInButton = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(384, 224);
            label2.Name = "label2";
            label2.Size = new Size(126, 29);
            label2.TabIndex = 30;
            label2.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(521, 216);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(179, 37);
            textBoxPassword.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(433, 170);
            label1.Name = "label1";
            label1.Size = new Size(77, 29);
            label1.TabIndex = 28;
            label1.Text = "Login";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLogin.Location = new Point(521, 162);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(179, 37);
            textBoxLogin.TabIndex = 27;
            // 
            // LogInButton
            // 
            LogInButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogInButton.Location = new Point(486, 274);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(120, 50);
            LogInButton.TabIndex = 26;
            LogInButton.Text = "Log in";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 239, 254);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBoxPassword);
            Controls.Add(label1);
            Controls.Add(textBoxLogin);
            Controls.Add(LogInButton);
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBoxPassword;
        private Label label1;
        private TextBox textBoxLogin;
        private Button LogInButton;
    }
}