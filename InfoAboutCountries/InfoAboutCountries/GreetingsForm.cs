using System;
using System.Windows.Forms;

namespace InfoAboutCountries
{
    public partial class GreetingsForm : Form
    {
        public GreetingsForm()
        {
            InitializeComponent();
        }

        private void SearchByNameButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
            Hide();
        }

        private void AllCountriesButton_Click(object sender, EventArgs e)
        {
            ResultsForm resultsForm = new ResultsForm(new Loader());
            resultsForm.Show();
            Hide();
        }
    }
}