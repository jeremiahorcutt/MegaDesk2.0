using Newtonsoft.Json;
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

            if (File.Exists(@"quotes.json"))
            {
                //creates a reader to read the file
                using (StreamReader reader = new StreamReader(@"quotes.json"))
                {
                    //continues to read lines until it reaches the end
                    while (!reader.EndOfStream)
                    {
                        //deserializes information and reads the line
                        DeskQuote deserializedQuotes = JsonConvert.DeserializeObject<DeskQuote>(reader.ReadLine());
                        Console.WriteLine(deserializedQuotes.Name);
                        //checks to see if inputed value is equal to surface value material in file then writes to data grid
                        if (surfaceValue == deserializedQuotes.desk.surfaceMaterial.ToString())
                        {
                            DataGridViewRow newRow = (DataGridViewRow)searchQuotesGrid.Rows[0].Clone();
                            newRow.Cells[0].Value = deserializedQuotes.Name;
                            newRow.Cells[1].Value = deserializedQuotes.date;
                            newRow.Cells[2].Value = deserializedQuotes.desk.width;
                            newRow.Cells[3].Value = deserializedQuotes.desk.depth;
                            newRow.Cells[4].Value = deserializedQuotes.desk.drawers;
                            newRow.Cells[5].Value = deserializedQuotes.desk.surfaceMaterial;
                            newRow.Cells[6].Value = deserializedQuotes.Rush;
                            newRow.Cells[7].Value = "$" + deserializedQuotes.quotePrice;
                            searchQuotesGrid.Rows.Add(newRow);
                        }
                    }
                }

            }

            //code for reading from file
            //for (int i = 0; i < (quotes.Length - 1); i++)
            //{
            //    items = quotes[i].Split(',');
            //    if (surfaceValue == items[5])
            //    {
            //        DataGridViewRow newRow = (DataGridViewRow)searchQuotesGrid.Rows[0].Clone();
            //        for (int j = 0; j < items.Length; j++)
            //        {
            //            newRow.Cells[j].Value = items[j];
            //        }
            //        searchQuotesGrid.Rows.Add(newRow);
            //    }
            //}
        }

        

        private void backbtn1_Click_1(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Close();
            menu.Show();
        }
    }
}
