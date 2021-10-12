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
            cutomizeDesign();
        }

        private void cutomizeDesign()
        {
            panelMediaSubMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelMediaSubMenu.Visible == true)
                panelMediaSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
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

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        private void addQuoteBtn1_Click(object sender, EventArgs e)
        {
            AddQuote newQuote = new AddQuote();
            this.Hide();
            newQuote.Show();
        }

        private void viewQuoteBtn1_Click(object sender, EventArgs e)
        {
            ViewAllQuotes allQuotes = new ViewAllQuotes();
            this.Hide();
            allQuotes.Show();
        }

        private void searchQuoteBtn1_Click(object sender, EventArgs e)
        {
            SearchQuote newSearch = new SearchQuote();
            this.Hide();
            newSearch.Show();
        }

        private void exitBtn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
