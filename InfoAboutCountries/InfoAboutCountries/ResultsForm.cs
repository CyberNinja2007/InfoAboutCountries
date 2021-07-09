using System;
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
        }

        private void AddToDBButton_Click(object sender, EventArgs e)
        {
            
        }

        private void NotAddButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ResultsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}