﻿namespace AddressBook
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
            DBViewer.BackgroundColor = Color.FromArgb(231, 239, 254);
            DBViewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DBViewer.Location = new Point(42, 98);
            DBViewer.Name = "DBViewer";
            DBViewer.ReadOnly = true;
            DBViewer.RowHeadersVisible = false;
            DBViewer.Size = new Size(400, 259);
            DBViewer.TabIndex = 0;
            // 
            // ReloadButton
            // 
            ReloadButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReloadButton.Location = new Point(324, 42);
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
            AddButton.Location = new Point(42, 42);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(120, 50);
            AddButton.TabIndex = 13;
            AddButton.Text = "ADD";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            UpdateButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateButton.Location = new Point(182, 42);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(120, 50);
            UpdateButton.TabIndex = 14;
            UpdateButton.Text = "UPDATE";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // Database
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 239, 254);
            ClientSize = new Size(798, 450);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Controls.Add(ReloadButton);
            Controls.Add(DBViewer);
            Name = "Database";
            Text = "Database";
            ((System.ComponentModel.ISupportInitialize)DBViewer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DBViewer;
        private Button ReloadButton;
        private Button AddButton;
        private Button UpdateButton;
    }
}