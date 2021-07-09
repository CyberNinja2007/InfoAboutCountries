using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InfoAboutCountries
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        
        private void searchText_TextChanged(object sender, EventArgs e)
        {
            searchButton.Enabled = Regex.IsMatch(searchText.Text, @"^[A-Z][a-z]+$") ? true : false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ResultsForm resultsForm = new ResultsForm( new Loader($"https://restcountries.eu/rest/v2/name/{searchText.Text}"));
            resultsForm.Show();
            Close();
        }
    }
}