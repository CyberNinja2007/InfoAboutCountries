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
            this.resultsLabel = new System.Windows.Forms.Label();
            this.addToDBButton = new System.Windows.Forms.Button();
            this.notAddToDBButton = new System.Windows.Forms.Button();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize) (this.resultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // resultsLabel
            // 
            this.resultsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.resultsLabel.Location = new System.Drawing.Point(38, 15);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(149, 29);
            this.resultsLabel.TabIndex = 0;
            this.resultsLabel.Text = "Результаты";
            // 
            // addToDBButton
            // 
            this.addToDBButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addToDBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToDBButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.addToDBButton.Location = new System.Drawing.Point(130, 320);
            this.addToDBButton.Name = "addToDBButton";
            this.addToDBButton.Size = new System.Drawing.Size(130, 38);
            this.addToDBButton.TabIndex = 2;
            this.addToDBButton.Text = "Добавить";
            this.addToDBButton.UseVisualStyleBackColor = false;
            this.addToDBButton.Click += new System.EventHandler(this.AddToDBButton_Click);
            // 
            // notAddToDBButton
            // 
            this.notAddToDBButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.notAddToDBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notAddToDBButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.notAddToDBButton.Location = new System.Drawing.Point(428, 320);
            this.notAddToDBButton.Name = "notAddToDBButton";
            this.notAddToDBButton.Size = new System.Drawing.Size(130, 38);
            this.notAddToDBButton.TabIndex = 3;
            this.notAddToDBButton.Text = "Не добавлять";
            this.notAddToDBButton.UseVisualStyleBackColor = false;
            this.notAddToDBButton.Click += new System.EventHandler(this.NotAddButton_Click);
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.AllowUserToAddRows = false;
            this.resultsDataGridView.AllowUserToDeleteRows = false;
            this.resultsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.resultsDataGridView.Location = new System.Drawing.Point(38, 77);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.ReadOnly = true;
            this.resultsDataGridView.Size = new System.Drawing.Size(630, 207);
            this.resultsDataGridView.TabIndex = 4;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(706, 390);
            this.ControlBox = false;
            this.Controls.Add(this.resultsDataGridView);
            this.Controls.Add(this.notAddToDBButton);
            this.Controls.Add(this.addToDBButton);
            this.Controls.Add(this.resultsLabel);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(722, 429);
            this.MinimumSize = new System.Drawing.Size(722, 429);
            this.Name = "ResultsForm";
            this.RightToLeftLayout = true;
            this.Text = "CI";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.resultsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button addToDBButton;
        private System.Windows.Forms.Button notAddToDBButton;

        private System.Windows.Forms.Label resultsLabel;

        private System.Windows.Forms.DataGridView resultsDataGridView;

        #endregion
    }
}