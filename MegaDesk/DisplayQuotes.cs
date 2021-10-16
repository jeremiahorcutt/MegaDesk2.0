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
    public partial class DisplayQuotes : Form
    {
        public DisplayQuotes()
        {
            InitializeComponent();
        }

        private void DisplayQuotes_Load(object sender, EventArgs e)
        {
            nameOuput.Text = AddQuote.nameValue;
            widthOutput.Text = AddQuote.widthValue;
            depthOutput.Text = AddQuote.depthValue;
            drawersOutput.Text = AddQuote.drawersValue;
            surfaceOutput.Text = AddQuote.surfaceValue;
            rushOutput.Text = AddQuote.rushValue;
            quoteOutput.Text = "$" + AddQuote.quotePriceString;
            dateOutput.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        
        private void menubtn_Click_1(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Hide();
            menu.Show();
        }
    }
}
