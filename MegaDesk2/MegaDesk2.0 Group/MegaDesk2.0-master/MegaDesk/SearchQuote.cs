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
    public partial class SearchQuote : Form
    {
        string surfaceValue = "";

        //reads file
        public static string text = File.ReadAllText(@"quotes.txt");

        //seperates quotes by .
        string[] quotes = text.Split('.');
        string[] items;
        public SearchQuote()
        {
            InitializeComponent();
            
            //populates Surface Material list
            List<DesktopMaterial> SurfaceList = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            listBoxSurface.DataSource = SurfaceList;

        }

        private void listBoxSurface_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchQuotesGrid.Rows.Clear();
            surfaceValue = this.listBoxSurface.GetItemText(listBoxSurface.SelectedItem);
            for (int i = 0; i < (quotes.Length - 1); i++)
            {
                items = quotes[i].Split(',');
                if (surfaceValue == items[5])
                {
                    DataGridViewRow newRow = (DataGridViewRow)searchQuotesGrid.Rows[0].Clone();
                    for (int j = 0; j < items.Length; j++)
                    {
                        newRow.Cells[j].Value = items[j];
                    }
                    searchQuotesGrid.Rows.Add(newRow);
                }
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
