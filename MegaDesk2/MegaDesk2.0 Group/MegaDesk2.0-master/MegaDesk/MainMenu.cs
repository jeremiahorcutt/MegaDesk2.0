using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

     
        private void addQuoteBtn_Click(object sender, EventArgs e)
        {
            AddQuote newQuote = new AddQuote();
            this.Hide();
            newQuote.Show();
        }

        private void viewQuoteBtn_Click(object sender, EventArgs e)
        {
            ViewAllQuotes allQuotes= new ViewAllQuotes();
            this.Hide();
            allQuotes.Show();
        }

        private void searchQuoteBtn_Click(object sender, EventArgs e)
        {
            SearchQuote newSearch = new SearchQuote();
            this.Hide();
            newSearch.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
