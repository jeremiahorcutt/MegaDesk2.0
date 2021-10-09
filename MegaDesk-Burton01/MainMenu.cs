using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Burton01
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addNewQuote_Click(object sender, EventArgs e)
        {
            AddQuote openAddQuote = new AddQuote();
            openAddQuote.Tag = this;
            openAddQuote.Show(this);
            Hide();
        }

        private void viewQuote_Click(object sender, EventArgs e)
        {
            Mainmenu2 openViewAllQuotes = new Mainmenu2();
            openViewAllQuotes.Tag = this;
            openViewAllQuotes.Show(this);
            Hide();
        }

        private void searchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes openSearchQuotes = new SearchQuotes();
            openSearchQuotes.Tag = this;
            openSearchQuotes.Show(this);
            Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}
