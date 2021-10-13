using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        //declare variables to recieve information from input
        public static string nameValue = "";
        public static string widthValue = "";
        public static string depthValue = "";
        public static string drawersValue = "";
        public static string surfaceValue = "";
        public static string rushValue = "";
        public static string quotePriceString = "";
        public static int quotePrice;
        public static int rush;
        public bool canAccessRushPrices;
        //declared integers for converting from decimals
        public int widthInt;
        public int depthInt;
        public int drawersInt;

        DesktopMaterial surface;
        //declared booleans for validation
        public bool widthBool = true;
        public bool depthBool = true;
        public bool drawersBool = true;
        private bool isValidated = false;
        Regex numberchk = new Regex(@"^([0-9]*|\d*)$");
        Regex letterchk = new Regex(@"^([a-zA-Z]*)$");


        public AddQuote()
        {
            InitializeComponent();
            //populates Surface Material list
            List<DesktopMaterial> SurfaceList = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            listBoxSurface.DataSource = SurfaceList;
            canAccessRushPrices = DeskQuote.GetRushOrder();
        }

        //logic for back button click
        private void backbtn1_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Close();
            menu.Show();
        }

        //logic for handling add quote click
        private void addQuoteBtn2_Click(object sender, EventArgs e)
        {
            if (widthBool && depthBool && drawersBool && canAccessRushPrices)
            {
                MessageBox.Show("Your quote has been generated!");
                DisplayQuotes quote = new DisplayQuotes();

                //get values of input from from and convert to string where necessary
                nameValue = nameTB.Text;
                widthValue = widthTB.Text;
                depthValue = depthTB.Value.ToString();
                drawersValue = drawersTB.Value.ToString();
                surfaceValue = this.listBoxSurface.GetItemText(listBoxSurface.SelectedItem);
                rushValue = this.listboxRush.GetItemText(listboxRush.SelectedItem);
                

                //interpretation of rush selection
                if(rushValue =="Normal 14 Days")
                {
                    rush = 0;
                }else if(rushValue == "Rush 7 Days")
                {
                    rush = 7;
                }else if(rushValue == "Rush 5 Days")
                {
                    rush = 5;
                }
                else
                {
                    rush = 3;
                }


                //convert width, depth, and drawers to Integers from decimals
                widthInt = int.Parse(widthTB.Text);
                depthInt = (int)depthTB.Value;
                drawersInt = (int)drawersTB.Value;
                surface = (DesktopMaterial)listBoxSurface.SelectedValue;
                //create a new DeskQuote, passing information to DeskQuote.cs
                DeskQuote newquote = new DeskQuote(nameValue, DateTime.Now.ToString("MM/dd/yyyy"), widthInt, depthInt, drawersInt, surface, rush);

                //calculate the quote
                quotePrice = newquote.GetQuote(rush);
                quotePriceString = quotePrice.ToString();

                //serialize newquote to be passed to the file.
                string serializedQuote = JsonConvert.SerializeObject(newquote);

                //create file path
                string file = @"quotes.json";

                //write quote to file
                //string fileString = nameValue + "," + DateTime.Now.ToString("MM/dd/yyyy") + "," + widthValue + "," + depthValue + "," + drawersValue + "," + surfaceValue + "," + rushValue + "," + quotePriceString + ".";
                try
                {
                    //creates file if it doesn't already exist (according to: https://stackoverflow.com/questions/10383053/create-file-if-file-does-not-exist)
                    using (StreamWriter sw = File.AppendText(file))
                    {
                        //writes serialized object to JSON file
                        sw.WriteLine(serializedQuote);
                    };
                    
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Writing To File: " + ex);
                }

                quote.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("There was an Error Generating your Quote. Please try again.");
            }
        }


        //method for validation if drawersTB is changed
        private void drawersTB_ValueChanged(object sender, EventArgs e)
        {
            if(drawersTB.Value >= Desk.MINDRAW && drawersTB.Value <= Desk.MAXDRAW)
            {
                drawersBool = true;
            }
            else
            {
                MessageBox.Show("Number of drawers must be between 0 and 7");
                //set value back to acceptable parameters
                drawersTB.Value = 0;
            }
        }

        #region VALIDATION
        //method for validation if widthTB is changed
        private void widthTB_ValueChanged(object sender, EventArgs e)
        {
            if (widthTB.Text == string.Empty)
            {
                errorProvider1.SetError(widthTB, "Please provide Number between 24\" and 96\"");
                errorProvider2.SetError(widthTB, "");
                errorProvider3.SetError(widthTB, "");
            }
            else
            {
                if (numberchk.IsMatch(widthTB.Text))
                {
                    int inputNum = int.Parse(widthTB.Text);
                    if (inputNum >= 24 && inputNum <= 96)
                    {
                        errorProvider1.SetError(widthTB, "");
                        errorProvider2.SetError(widthTB, "");
                        errorProvider3.SetError(widthTB, "Correct");

                    }
                    else
                    {
                        errorProvider1.SetError(widthTB, "");
                        errorProvider2.SetError(widthTB, "Wrong format, Please provide Number between 24\" and 96\"");
                        errorProvider3.SetError(widthTB, "");
                    }
                }
                else
                {
                    errorProvider1.SetError(widthTB, "");
                    errorProvider2.SetError(widthTB, "Wrong format, Please provide Number between 24\" and 96\"");
                    errorProvider3.SetError(widthTB, "");
                }
            }


/*
            if (widthTB.Text >= Desk.MINWIDTH && widthTB.Value <= Desk.MAXWIDTH && IntVerify(widthTB.Value.ToString()))
            {
                widthBool = true;
                
            }
            else
            {
                MessageBox.Show("Desk Width must be a whole number between 24 and 96");
                //set value back to acceptable parameters
                widthTB.Value = (int) 24;
                
            }*/
        }

        #endregion


        //method for validation if depthTB is changed
        private void depthTB_ValueChanged(object sender, EventArgs e)
        {
            if (depthTB.Value >= Desk.MINDEPTH && depthTB.Value <= Desk.MAXDEPTH && IntVerify(depthTB.Value.ToString()))
            {
                depthBool = true;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine(depthTB.Value.ToString());
                MessageBox.Show("Desk Depth must be a whole number between 12 and 48");
                //set value back to acceptable parameters
                depthTB.Value = 12;
            }
        }

        //verification that the entered number is an integer
        public bool IntVerify(String item)
        {
            int count = 0;
            foreach (char c in item)
            {
                if (Char.IsDigit(c))
                {
                    count += 0;               
                }
                else
                {
                    count += 1;
                };
            }
            if(count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}