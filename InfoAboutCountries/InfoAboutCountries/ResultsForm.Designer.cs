namespace InfoAboutCountries
{
    partial class ResultsForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddToDBButton = new System.Windows.Forms.Button();
            this.NotAddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ResultsLabel.Location = new System.Drawing.Point(38, 26);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(149, 29);
            this.ResultsLabel.TabIndex = 0;
            this.ResultsLabel.Text = "Результаты";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.Column1, this.Column2, this.Column3, this.Column4, this.Column5, this.Column6});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(38, 80);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(643, 220);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(643, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(643, 220);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Код страны";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Столица";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Площадь";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Население";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Регион";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // AddToDBButton
            // 
            this.AddToDBButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddToDBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToDBButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.AddToDBButton.Location = new System.Drawing.Point(160, 340);
            this.AddToDBButton.Name = "AddToDBButton";
            this.AddToDBButton.Size = new System.Drawing.Size(130, 38);
            this.AddToDBButton.TabIndex = 2;
            this.AddToDBButton.Text = "Добавить";
            this.AddToDBButton.UseVisualStyleBackColor = false;
            this.AddToDBButton.Click += new System.EventHandler(this.AddToDBButton_Click);
            // 
            // NotAddButton
            // 
            this.NotAddButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NotAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NotAddButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.NotAddButton.Location = new System.Drawing.Point(398, 340);
            this.NotAddButton.Name = "NotAddButton";
            this.NotAddButton.Size = new System.Drawing.Size(130, 38);
            this.NotAddButton.TabIndex = 3;
            this.NotAddButton.Text = "Не добавлять";
            this.NotAddButton.UseVisualStyleBackColor = false;
            this.NotAddButton.Click += new System.EventHandler(this.NotAddButton_Click);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(706, 390);
            this.Controls.Add(this.NotAddButton);
            this.Controls.Add(this.AddToDBButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ResultsLabel);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(722, 429);
            this.MinimumSize = new System.Drawing.Size(722, 429);
            this.Name = "ResultsForm";
            this.RightToLeftLayout = true;
            this.Text = "Результаты";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button NotAddButton;
        private System.Windows.Forms.Button AddToDBButton;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;

        private System.Windows.Forms.Label ResultsLabel;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}