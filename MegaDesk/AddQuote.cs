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
        public bool nameBool = false;
        public bool widthBool = true;
        public bool depthBool = true;
        public bool drawersBool = true;
        Regex numberchk = new Regex(@"^([0-9]*|\d*)$");
        Regex letterchk = new Regex(@"^[\p{L} \.'\-]+$");


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
            if (nameBool && widthBool && depthBool && drawersBool && canAccessRushPrices)
            {
                MessageBox.Show("Your quote has been generated!");
                DisplayQuotes quote = new DisplayQuotes();

                //get values of input from from and convert to string where necessary
                nameValue = nameTB.Text;
                widthValue = widthTB.Text;
                depthValue = depthTB.Text;
                drawersValue = drawersTB.Text;
                surfaceValue = this.listBoxSurface.GetItemText(listBoxSurface.SelectedItem);
                rushValue = this.listboxRush.GetItemText(listboxRush.SelectedItem);


                //interpretation of rush selection
                if (rushValue == "Normal 14 Days")
                {
                    rush = 0;
                }
                else if (rushValue == "Rush 7 Days")
                {
                    rush = 7;
                }
                else if (rushValue == "Rush 5 Days")
                {
                    rush = 5;
                }
                else
                {
                    rush = 3;
                }


                //convert width, depth, and drawers to Integers from decimals
                widthInt = int.Parse(widthTB.Text);
                depthInt = int.Parse(depthTB.Text);
                drawersInt = int.Parse(drawersTB.Text);
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


        /********************************************************************
         *  drawersTB VALUECHANGED
         *      This Function will validate if the desk's drawer amount consits 
         *      of only integers and is not empty.
         * ******************************************************************/
        private void drawersTB_ValueChanged(object sender, EventArgs e)
        {
            if (drawersTB.Text == string.Empty)
            {
                errorProvider1.SetError(drawersTB, "Please provide Number between 0\" and 7\"");
                errorProvider2.SetError(drawersTB, "");
                errorProvider3.SetError(drawersTB, "");
                drawersBool = false;
            }
            else
            {
                if (numberchk.IsMatch(drawersTB.Text))
                {
                    int inputNum = int.Parse(drawersTB.Text);
                    if (inputNum >= 0 && inputNum <= 7)
                    {
                        errorProvider1.SetError(drawersTB, "");
                        errorProvider2.SetError(drawersTB, "");
                        errorProvider3.SetError(drawersTB, "Correct");
                        drawersBool = true;

                    }
                    else
                    {
                        errorProvider1.SetError(drawersTB, "");
                        errorProvider2.SetError(drawersTB, "Wrong format, Please provide Number between 0\" and 7\"");
                        errorProvider3.SetError(drawersTB, "");
                        drawersBool = false;
                    }
                }
                else
                {
                    errorProvider1.SetError(drawersTB, "");
                    errorProvider2.SetError(drawersTB, "Wrong format, Please provide Number between 0\" and 7\"");
                    errorProvider3.SetError(drawersTB, "");
                    drawersBool = false;
                }
            }
        }

        #region VALIDATION
        /********************************************************************
         *  NAMETB VALIDATED
         *      This Function will validate if the user name consits of correct 
         *      chars
         * ******************************************************************/
        private void nameTB_Validated(object sender, EventArgs e)
        {
            if (nameTB.Text == string.Empty)
            {
                errorProvider1.SetError(nameTB, "Please Enter Last Name");
                errorProvider2.SetError(nameTB, "");
                errorProvider3.SetError(nameTB, "");
                nameBool = false;
            }
            else if (letterchk.IsMatch(nameTB.Text))
            {
                errorProvider1.SetError(nameTB, "");
                errorProvider2.SetError(nameTB, "");
                errorProvider3.SetError(nameTB, "Correct");
                nameBool = true;




            }

            else
            {
                errorProvider1.SetError(nameTB, "");
                errorProvider2.SetError(nameTB, "Characters Only");
                errorProvider3.SetError(nameTB, "");
                nameBool = false;
            }
        }


        /********************************************************************
         *  WIDTHTB VALUECHANGED
         *      This Function will validate if the desk width consits of only
         *      integers.
         * ******************************************************************/
        private void widthTB_ValueChanged(object sender, EventArgs e)
        {
            if (widthTB.Text == string.Empty)
            {
                errorProvider1.SetError(widthTB, "Please provide Number between 24\" and 96\"");
                errorProvider2.SetError(widthTB, "");
                errorProvider3.SetError(widthTB, "");
                widthBool = false;
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
                        widthBool = true;

                    }
                    else
                    {
                        errorProvider1.SetError(widthTB, "");
                        errorProvider2.SetError(widthTB, "Wrong format, Please provide Number between 24\" and 96\"");
                        errorProvider3.SetError(widthTB, "");
                        widthBool = false;
                    }
                }
                else
                {
                    errorProvider1.SetError(widthTB, "");
                    errorProvider2.SetError(widthTB, "Wrong format, Please provide Number between 24\" and 96\"");
                    errorProvider3.SetError(widthTB, "");
                    widthBool = false;
                }
            }
        }

        /********************************************************************
         *  DEPTHTB VALUECHANGED
         *      This Function will validate if the desk depth consits of only
         *      integers and is not empty.
         * ******************************************************************/
        private void depthTB_ValueChanged(object sender, EventArgs e)
        {
            if (depthTB.Text == string.Empty)
            {
                errorProvider1.SetError(depthTB, "Please provide Number between 12\" and 48\"");
                errorProvider2.SetError(depthTB, "");
                errorProvider3.SetError(depthTB, "");
                depthBool = false;
            }
            else
            {
                if (numberchk.IsMatch(depthTB.Text))
                {
                    int inputNum = int.Parse(depthTB.Text);
                    if (inputNum >= 12 && inputNum <= 48)
                    {
                        errorProvider1.SetError(depthTB, "");
                        errorProvider2.SetError(depthTB, "");
                        errorProvider3.SetError(depthTB, "Correct");
                        depthBool = true;

                    }
                    else
                    {
                        errorProvider1.SetError(depthTB, "");
                        errorProvider2.SetError(depthTB, "Wrong format, Please provide Number between 12\" and 48\"");
                        errorProvider3.SetError(depthTB, "");
                        depthBool = false;
                    }
                }
                else
                {
                    errorProvider1.SetError(depthTB, "");
                    errorProvider2.SetError(depthTB, "Wrong format, Please provide Number between 12\" and 48\"");
                    errorProvider3.SetError(depthTB, "");
                    depthBool = false;
                }
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
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        #endregion



    }
}