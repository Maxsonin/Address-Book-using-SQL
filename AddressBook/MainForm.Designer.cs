namespace AddressBook
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelMenu = new Panel();
            DatabaseAccessButton = new FontAwesome.Sharp.IconButton();
            DatabaseInfoButton = new FontAwesome.Sharp.IconButton();
            DatabaseButton = new FontAwesome.Sharp.IconButton();
            logoPanel = new Panel();
            ToHomeButton = new PictureBox();
            PanelMenu.SuspendLayout();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ToHomeButton).BeginInit();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.Anchor = AnchorStyles.Left;
            PanelMenu.BackColor = Color.FromArgb(5, 103, 251);
            PanelMenu.Controls.Add(DatabaseAccessButton);
            PanelMenu.Controls.Add(DatabaseInfoButton);
            PanelMenu.Controls.Add(DatabaseButton);
            PanelMenu.Controls.Add(logoPanel);
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(220, 540);
            PanelMenu.TabIndex = 0;
            // 
            // DatabaseAccessButton
            // 
            DatabaseAccessButton.Dock = DockStyle.Top;
            DatabaseAccessButton.FlatAppearance.BorderSize = 0;
            DatabaseAccessButton.FlatStyle = FlatStyle.Flat;
            DatabaseAccessButton.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DatabaseAccessButton.ForeColor = Color.FromArgb(239, 244, 255);
            DatabaseAccessButton.IconChar = FontAwesome.Sharp.IconChar.ArrowsDownToPeople;
            DatabaseAccessButton.IconColor = Color.FromArgb(239, 244, 255);
            DatabaseAccessButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DatabaseAccessButton.ImageAlign = ContentAlignment.MiddleLeft;
            DatabaseAccessButton.Location = new Point(0, 260);
            DatabaseAccessButton.Name = "DatabaseAccessButton";
            DatabaseAccessButton.Padding = new Padding(10, 0, 20, 0);
            DatabaseAccessButton.Size = new Size(220, 60);
            DatabaseAccessButton.TabIndex = 2;
            DatabaseAccessButton.Text = "DB Access";
            DatabaseAccessButton.TextAlign = ContentAlignment.MiddleLeft;
            DatabaseAccessButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            DatabaseAccessButton.UseVisualStyleBackColor = true;
            DatabaseAccessButton.Click += DatabaseAccessButton_Click;
            // 
            // DatabaseInfoButton
            // 
            DatabaseInfoButton.Dock = DockStyle.Top;
            DatabaseInfoButton.FlatAppearance.BorderSize = 0;
            DatabaseInfoButton.FlatStyle = FlatStyle.Flat;
            DatabaseInfoButton.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DatabaseInfoButton.ForeColor = Color.FromArgb(239, 244, 255);
            DatabaseInfoButton.IconChar = FontAwesome.Sharp.IconChar.ArrowsTurnToDots;
            DatabaseInfoButton.IconColor = Color.FromArgb(239, 244, 255);
            DatabaseInfoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DatabaseInfoButton.ImageAlign = ContentAlignment.MiddleLeft;
            DatabaseInfoButton.Location = new Point(0, 200);
            DatabaseInfoButton.Name = "DatabaseInfoButton";
            DatabaseInfoButton.Padding = new Padding(10, 0, 20, 0);
            DatabaseInfoButton.Size = new Size(220, 60);
            DatabaseInfoButton.TabIndex = 1;
            DatabaseInfoButton.Text = "DB Info";
            DatabaseInfoButton.TextAlign = ContentAlignment.MiddleLeft;
            DatabaseInfoButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            DatabaseInfoButton.UseVisualStyleBackColor = true;
            DatabaseInfoButton.Click += DatabaseInfoButton_Click;
            // 
            // DatabaseButton
            // 
            DatabaseButton.Dock = DockStyle.Top;
            DatabaseButton.FlatAppearance.BorderSize = 0;
            DatabaseButton.FlatStyle = FlatStyle.Flat;
            DatabaseButton.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DatabaseButton.ForeColor = Color.FromArgb(239, 244, 255);
            DatabaseButton.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            DatabaseButton.IconColor = Color.FromArgb(239, 244, 255);
            DatabaseButton.IconFont = FontAwesome.Sharp.IconFont.Regular;
            DatabaseButton.ImageAlign = ContentAlignment.MiddleLeft;
            DatabaseButton.Location = new Point(0, 140);
            DatabaseButton.Name = "DatabaseButton";
            DatabaseButton.Padding = new Padding(10, 0, 20, 0);
            DatabaseButton.Size = new Size(220, 60);
            DatabaseButton.TabIndex = 0;
            DatabaseButton.Text = "Database";
            DatabaseButton.TextAlign = ContentAlignment.MiddleLeft;
            DatabaseButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            DatabaseButton.UseVisualStyleBackColor = true;
            DatabaseButton.Click += DatabaseButton_Click;
            // 
            // logoPanel
            // 
            logoPanel.Controls.Add(ToHomeButton);
            logoPanel.Dock = DockStyle.Top;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(220, 140);
            logoPanel.TabIndex = 0;
            // 
            // ToHomeButton
            // 
            ToHomeButton.Dock = DockStyle.Top;
            ToHomeButton.Image = Properties.Resources.logo;
            ToHomeButton.Location = new Point(0, 0);
            ToHomeButton.Name = "ToHomeButton";
            ToHomeButton.Size = new Size(220, 140);
            ToHomeButton.SizeMode = PictureBoxSizeMode.Zoom;
            ToHomeButton.TabIndex = 0;
            ToHomeButton.TabStop = false;
            ToHomeButton.Click += ToHomeButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 239, 254);
            ClientSize = new Size(1143, 540);
            Controls.Add(PanelMenu);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            PanelMenu.ResumeLayout(false);
            logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ToHomeButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenu;
        private Panel logoPanel;
        private FontAwesome.Sharp.IconButton DatabaseButton;
        private FontAwesome.Sharp.IconButton DatabaseAccessButton;
        private FontAwesome.Sharp.IconButton DatabaseInfoButton;
        private PictureBox ToHomeButton;
    }
}
