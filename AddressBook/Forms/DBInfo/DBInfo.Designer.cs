namespace AddressBook.Forms.DBInfo
{
    partial class DBInfo
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
            NewCityPrompt = new Label();
            textBoxNewCity = new TextBox();
            DataGridViewCities = new DataGridView();
            dataGridViewPositions = new DataGridView();
            AddPosButton = new Button();
            NewPosLabel = new Label();
            textBoxPosition = new TextBox();
            DeleteCityButton = new Button();
            AddNewCityButton = new Button();
            DeletePositionButton = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCities).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPositions).BeginInit();
            SuspendLayout();
            // 
            // NewCityPrompt
            // 
            NewCityPrompt.AutoSize = true;
            NewCityPrompt.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewCityPrompt.Location = new Point(12, 35);
            NewCityPrompt.Name = "NewCityPrompt";
            NewCityPrompt.Size = new Size(130, 29);
            NewCityPrompt.TabIndex = 39;
            NewCityPrompt.Text = "New City:";
            // 
            // textBoxNewCity
            // 
            textBoxNewCity.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNewCity.Location = new Point(148, 32);
            textBoxNewCity.Name = "textBoxNewCity";
            textBoxNewCity.Size = new Size(142, 37);
            textBoxNewCity.TabIndex = 38;
            // 
            // DataGridViewCities
            // 
            DataGridViewCities.AllowUserToAddRows = false;
            DataGridViewCities.AllowUserToDeleteRows = false;
            DataGridViewCities.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewCities.BackgroundColor = Color.FromArgb(231, 239, 254);
            DataGridViewCities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCities.Location = new Point(12, 84);
            DataGridViewCities.Name = "DataGridViewCities";
            DataGridViewCities.ReadOnly = true;
            DataGridViewCities.RowHeadersVisible = false;
            DataGridViewCities.Size = new Size(412, 286);
            DataGridViewCities.TabIndex = 41;
            // 
            // dataGridViewPositions
            // 
            dataGridViewPositions.AllowUserToAddRows = false;
            dataGridViewPositions.AllowUserToDeleteRows = false;
            dataGridViewPositions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPositions.BackgroundColor = Color.FromArgb(231, 239, 254);
            dataGridViewPositions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPositions.Location = new Point(473, 84);
            dataGridViewPositions.MinimumSize = new Size(450, 0);
            dataGridViewPositions.Name = "dataGridViewPositions";
            dataGridViewPositions.ReadOnly = true;
            dataGridViewPositions.RowHeadersVisible = false;
            dataGridViewPositions.Size = new Size(450, 286);
            dataGridViewPositions.TabIndex = 45;
            // 
            // AddPosButton
            // 
            AddPosButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddPosButton.Location = new Point(798, 27);
            AddPosButton.Name = "AddPosButton";
            AddPosButton.Size = new Size(128, 51);
            AddPosButton.TabIndex = 44;
            AddPosButton.Text = "ADD";
            AddPosButton.UseVisualStyleBackColor = true;
            AddPosButton.Click += AddPosButton_Click;
            // 
            // NewPosLabel
            // 
            NewPosLabel.AutoSize = true;
            NewPosLabel.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewPosLabel.Location = new Point(473, 35);
            NewPosLabel.Name = "NewPosLabel";
            NewPosLabel.Size = new Size(176, 29);
            NewPosLabel.TabIndex = 43;
            NewPosLabel.Text = "New Position:";
            // 
            // textBoxPosition
            // 
            textBoxPosition.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPosition.Location = new Point(650, 32);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new Size(142, 37);
            textBoxPosition.TabIndex = 42;
            // 
            // DeleteCityButton
            // 
            DeleteCityButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeleteCityButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteCityButton.Location = new Point(148, 376);
            DeleteCityButton.Name = "DeleteCityButton";
            DeleteCityButton.Size = new Size(128, 51);
            DeleteCityButton.TabIndex = 46;
            DeleteCityButton.Text = "DELETE";
            DeleteCityButton.UseVisualStyleBackColor = true;
            DeleteCityButton.Click += DeleteCityButton_Click;
            // 
            // AddNewCityButton
            // 
            AddNewCityButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddNewCityButton.Location = new Point(296, 27);
            AddNewCityButton.Name = "AddNewCityButton";
            AddNewCityButton.Size = new Size(128, 51);
            AddNewCityButton.TabIndex = 40;
            AddNewCityButton.Text = "ADD";
            AddNewCityButton.UseVisualStyleBackColor = true;
            AddNewCityButton.Click += AddNewCityButton_Click;
            // 
            // DeletePositionButton
            // 
            DeletePositionButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeletePositionButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeletePositionButton.Location = new Point(664, 376);
            DeletePositionButton.Name = "DeletePositionButton";
            DeletePositionButton.Size = new Size(128, 51);
            DeletePositionButton.TabIndex = 47;
            DeletePositionButton.Text = "DELETE";
            DeletePositionButton.UseVisualStyleBackColor = true;
            DeletePositionButton.Click += DeletePositionButton_Click;
            // 
            // DBInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 239, 254);
            ClientSize = new Size(948, 458);
            Controls.Add(DeletePositionButton);
            Controls.Add(DeleteCityButton);
            Controls.Add(dataGridViewPositions);
            Controls.Add(AddPosButton);
            Controls.Add(NewPosLabel);
            Controls.Add(textBoxPosition);
            Controls.Add(DataGridViewCities);
            Controls.Add(AddNewCityButton);
            Controls.Add(NewCityPrompt);
            Controls.Add(textBoxNewCity);
            Name = "DBInfo";
            Text = "DBInfo";
            ((System.ComponentModel.ISupportInitialize)DataGridViewCities).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPositions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label NewCityPrompt;
        private TextBox textBoxNewCity;
        private DataGridView DataGridViewCities;
        private DataGridView dataGridViewPositions;
        private Button AddPosButton;
        private Label NewPosLabel;
        private TextBox textBoxPosition;
        private Button DeleteCityButton;
        private Button AddNewCityButton;
        private Button DeletePositionButton;
    }
}