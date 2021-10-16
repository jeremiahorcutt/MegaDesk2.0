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
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelMediaSubmenu.Visible = false;
        }

        private void hideMediaSubmenu()
        {
            if (panelMediaSubmenu.Visible == true)
                panelMediaSubmenu.Visible = false;
        }

        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideMediaSubmenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }
     

        

       
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchQuoteBtn_Click_1(object sender, EventArgs e)
        {
            SearchQuote newSearch = new SearchQuote();
            this.Hide();
            newSearch.Show();
        }

        private void viewQuoteBtn_Click_1(object sender, EventArgs e)
        {
            ViewAllQuotes allQuotes = new ViewAllQuotes();
            this.Hide();
            allQuotes.Show();
        }

        private void addQuoteBtn_Click_1(object sender, EventArgs e)
        {
            AddQuote newQuote = new AddQuote();
            this.Hide();
            newQuote.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubmenu);
                
         
        }
    }
}
