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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            label2 = new Label();
            textBoxPassword = new TextBox();
            label1 = new Label();
            textBoxLogin = new TextBox();
            LogInButton = new Button();
            panelLogIn = new Panel();
            pictureBoxLogIn = new PictureBox();
            panelLogIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogIn).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 21.75F, FontStyle.Bold);
            label2.Location = new Point(435, 219);
            label2.Name = "label2";
            label2.Size = new Size(171, 35);
            label2.TabIndex = 30;
            label2.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(435, 257);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(293, 37);
            textBoxPassword.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 21.75F, FontStyle.Bold);
            label1.Location = new Point(435, 124);
            label1.Name = "label1";
            label1.Size = new Size(104, 35);
            label1.TabIndex = 28;
            label1.Text = "Login";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLogin.Location = new Point(435, 162);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(293, 37);
            textBoxLogin.TabIndex = 27;
            // 
            // LogInButton
            // 
            LogInButton.Font = new Font("Verdana", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogInButton.Location = new Point(503, 313);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(137, 58);
            LogInButton.TabIndex = 26;
            LogInButton.Text = "Log in";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click;
            // 
            // panelLogIn
            // 
            panelLogIn.BackColor = Color.FromArgb(5, 103, 251);
            panelLogIn.Controls.Add(pictureBoxLogIn);
            panelLogIn.Dock = DockStyle.Left;
            panelLogIn.Location = new Point(0, 0);
            panelLogIn.Name = "panelLogIn";
            panelLogIn.Size = new Size(358, 461);
            panelLogIn.TabIndex = 31;
            // 
            // pictureBoxLogIn
            // 
            pictureBoxLogIn.Image = Properties.Resources.logomin;
            pictureBoxLogIn.Location = new Point(54, 84);
            pictureBoxLogIn.Name = "pictureBoxLogIn";
            pictureBoxLogIn.Size = new Size(246, 287);
            pictureBoxLogIn.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogIn.TabIndex = 0;
            pictureBoxLogIn.TabStop = false;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 239, 254);
            ClientSize = new Size(784, 461);
            Controls.Add(panelLogIn);
            Controls.Add(label2);
            Controls.Add(textBoxPassword);
            Controls.Add(label1);
            Controls.Add(textBoxLogin);
            Controls.Add(LogInButton);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LogIn";
            Text = "Log In";
            panelLogIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogIn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBoxPassword;
        private Label label1;
        private TextBox textBoxLogin;
        private Button LogInButton;
        private Panel panelLogIn;
        private PictureBox pictureBoxLogIn;
    }
}