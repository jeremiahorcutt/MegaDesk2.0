using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();

            //reads file
            string text = File.ReadAllText(@"quotes.txt");

            //seperates quotes by .
            string[] quotes = text.Split('.');
            string[] items;
            //loop to seperate items in quote by ,
            for (int i = 0; i < (quotes.Length -1); i++)
            {
                DataGridViewRow newRow = (DataGridViewRow)allQuotes.Rows[0].Clone();
                items = quotes[i].Split(',');
                for(int j = 0; j < items.Length; j++) {
                    newRow.Cells[j].Value = items[j];
                }
                allQuotes.Rows.Add(newRow);
                foreach (var c in items) { Console.WriteLine(c); };
            }
            
            
        }

        private void backbtn1_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Close();
            menu.Show();
        }
    }
}
