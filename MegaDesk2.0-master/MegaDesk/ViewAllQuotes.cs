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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
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

                        DataGridViewRow newRow = (DataGridViewRow)allQuotes.Rows[0].Clone();
                          newRow.Cells[0].Value = deserializedQuotes.Name;
                          newRow.Cells[1].Value = deserializedQuotes.date;
                          newRow.Cells[2].Value = deserializedQuotes.desk.width;
                          newRow.Cells[3].Value = deserializedQuotes.desk.depth;
                          newRow.Cells[4].Value = deserializedQuotes.desk.drawers;
                          newRow.Cells[5].Value = deserializedQuotes.desk.surfaceMaterial;
                          newRow.Cells[6].Value = deserializedQuotes.Rush;
                          newRow.Cells[7].Value = "$" + deserializedQuotes.quotePrice;
                          allQuotes.Rows.Add(newRow);
                    
                    }
                }

            }
            

            //reads txt file
            //string text = File.ReadAllText(@"quotes.txt");

            //seperates quotes by .
            //string[] quotes = text.Split('.');
            //string[] items;
            //loop to seperate items in quote by ,
            //for (int i = 0; i < (quotes.Length -1); i++)
            //{
            //    DataGridViewRow newRow = (DataGridViewRow)allQuotes.Rows[0].Clone();
            //    items = quotes[i].Split(',');
            //    for(int j = 0; j < items.Length; j++) {
            //        newRow.Cells[j].Value = items[j];
            //    }
            //    allQuotes.Rows.Add(newRow);
            //    foreach (var c in items) { Console.WriteLine(c); };
            //}



        }

        private void backbtn1_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Close();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Close();
            menu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Close();
            menu.Show();
        }
    }
}
