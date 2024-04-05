namespace AddressBook
{
    partial class MainFormReadOnly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormReadOnly));
            logoPanel = new Panel();
            ToHomeButton = new PictureBox();
            DatabaseButton = new FontAwesome.Sharp.IconButton();
            PanelMenu = new Panel();
            panelTitleBar = new Panel();
            titleOfCurChild = new Label();
            iconCurrentChield = new FontAwesome.Sharp.IconPictureBox();
            panelDesktop = new Panel();
            logoMainForm = new PictureBox();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ToHomeButton).BeginInit();
            PanelMenu.SuspendLayout();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChield).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoMainForm).BeginInit();
            SuspendLayout();
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
            // PanelMenu
            // 
            PanelMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PanelMenu.BackColor = Color.FromArgb(5, 103, 251);
            PanelMenu.Controls.Add(DatabaseButton);
            PanelMenu.Controls.Add(logoPanel);
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(220, 761);
            PanelMenu.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            panelTitleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTitleBar.BackColor = Color.FromArgb(5, 103, 251);
            panelTitleBar.Controls.Add(titleOfCurChild);
            panelTitleBar.Controls.Add(iconCurrentChield);
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1066, 75);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // titleOfCurChild
            // 
            titleOfCurChild.AutoSize = true;
            titleOfCurChild.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleOfCurChild.ForeColor = Color.FromArgb(239, 244, 255);
            titleOfCurChild.Location = new Point(68, 23);
            titleOfCurChild.Name = "titleOfCurChild";
            titleOfCurChild.Size = new Size(90, 29);
            titleOfCurChild.TabIndex = 1;
            titleOfCurChild.Text = "Home";
            // 
            // iconCurrentChield
            // 
            iconCurrentChield.BackColor = Color.FromArgb(5, 103, 251);
            iconCurrentChield.ForeColor = Color.FromArgb(239, 244, 255);
            iconCurrentChield.IconChar = FontAwesome.Sharp.IconChar.Paypal;
            iconCurrentChield.IconColor = Color.FromArgb(239, 244, 255);
            iconCurrentChield.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChield.IconSize = 56;
            iconCurrentChield.Location = new Point(6, 12);
            iconCurrentChield.Name = "iconCurrentChield";
            iconCurrentChield.Size = new Size(56, 63);
            iconCurrentChield.TabIndex = 0;
            iconCurrentChield.TabStop = false;
            // 
            // panelDesktop
            // 
            panelDesktop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDesktop.BackColor = Color.FromArgb(231, 239, 254);
            panelDesktop.Controls.Add(logoMainForm);
            panelDesktop.Location = new Point(220, 75);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1066, 686);
            panelDesktop.TabIndex = 2;
            // 
            // logoMainForm
            // 
            logoMainForm.Anchor = AnchorStyles.None;
            logoMainForm.Image = Properties.Resources.logo;
            logoMainForm.Location = new Point(137, 34);
            logoMainForm.Margin = new Padding(0);
            logoMainForm.MaximumSize = new Size(800, 600);
            logoMainForm.MinimumSize = new Size(500, 300);
            logoMainForm.Name = "logoMainForm";
            logoMainForm.Size = new Size(800, 600);
            logoMainForm.SizeMode = PictureBoxSizeMode.Zoom;
            logoMainForm.TabIndex = 0;
            logoMainForm.TabStop = false;
            // 
            // MainFormReadOnly
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 239, 254);
            ClientSize = new Size(1284, 761);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(PanelMenu);
            DoubleBuffered = true;
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MainFormReadOnly";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Adress Book";
            logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ToHomeButton).EndInit();
            PanelMenu.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChield).EndInit();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoMainForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel logoPanel;
        private PictureBox ToHomeButton;
        private FontAwesome.Sharp.IconButton DatabaseButton;
        private Panel PanelMenu;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChield;
        private Label titleOfCurChild;
        private Panel panelDesktop;
        private PictureBox logoMainForm;
    }
}
