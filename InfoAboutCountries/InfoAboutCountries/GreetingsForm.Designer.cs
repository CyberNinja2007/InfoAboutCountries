using System.ComponentModel;

namespace InfoAboutCountries
{
    partial class GreetingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.ChooseLabel = new System.Windows.Forms.Label();
            this.SearchByNameButton = new System.Windows.Forms.Button();
            this.AllCountriesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseLabel
            // 
            this.ChooseLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChooseLabel.AutoSize = true;
            this.ChooseLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ChooseLabel.Location = new System.Drawing.Point(12, 31);
            this.ChooseLabel.Name = "ChooseLabel";
            this.ChooseLabel.Size = new System.Drawing.Size(264, 25);
            this.ChooseLabel.TabIndex = 0;
            this.ChooseLabel.Text = "Что вы хотите выбрать?";
            this.ChooseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchByNameButton
            // 
            this.SearchByNameButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SearchByNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchByNameButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.SearchByNameButton.Location = new System.Drawing.Point(53, 93);
            this.SearchByNameButton.Name = "SearchByNameButton";
            this.SearchByNameButton.Size = new System.Drawing.Size(187, 41);
            this.SearchByNameButton.TabIndex = 1;
            this.SearchByNameButton.Text = "Поиск по названию";
            this.SearchByNameButton.UseVisualStyleBackColor = false;
            this.SearchByNameButton.Click += new System.EventHandler(this.SearchByNameButton_Click);
            // 
            // AllCountriesButton
            // 
            this.AllCountriesButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AllCountriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllCountriesButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.AllCountriesButton.Location = new System.Drawing.Point(53, 182);
            this.AllCountriesButton.Name = "AllCountriesButton";
            this.AllCountriesButton.Size = new System.Drawing.Size(187, 39);
            this.AllCountriesButton.TabIndex = 2;
            this.AllCountriesButton.Text = "Вывод всех стран";
            this.AllCountriesButton.UseVisualStyleBackColor = false;
            this.AllCountriesButton.Click += new System.EventHandler(this.AllCountriesButton_Click);
            // 
            // GreetingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(289, 282);
            this.Controls.Add(this.AllCountriesButton);
            this.Controls.Add(this.SearchByNameButton);
            this.Controls.Add(this.ChooseLabel);
            this.Name = "GreetingsForm";
            this.Text = "CI";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label ChooseLabel;

        private System.Windows.Forms.Button SearchByNameButton;

        private System.Windows.Forms.Button AllCountriesButton;

        private System.Windows.Forms.Label chooseLabel;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        #endregion
    }
}