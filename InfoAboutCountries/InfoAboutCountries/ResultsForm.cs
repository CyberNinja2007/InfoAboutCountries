using System;
using System.Data;
using System.Windows.Forms;

namespace InfoAboutCountries
{
    public partial class ResultsForm : Form
    {
        private Loader _loader;
        
        public ResultsForm(Loader loader)
        {
            _loader = loader;
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            resultsDataGridView.DataSource = _loader.LoadData();
            if (resultsDataGridView.DataSource == null)
            {
                addToDBButton.Enabled = false;
                MessageBox.Show("Вы допустили ошибку в названии страны.");
            }
        }

        private void AddToDBButton_Click(object sender, EventArgs e)
        {
            _loader.LoadCountryToDB((DataTable)resultsDataGridView.DataSource);
            Application.OpenForms[0].Show();
            Close();
        }

        private void NotAddButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Close();
        }
    }
}