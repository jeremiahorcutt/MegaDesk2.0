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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            Desk desk = new Desk();
            DeskQuote deskquote = new DeskQuote();
            InitializeComponent();
            currentDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
        }

        private void returnToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu openMainMenu = new MainMenu();
            openMainMenu.Tag = this;
            openMainMenu.Show(this);
            Hide();
        }

        public void validateCustomer(string input)
        {
        }

        private void customerNameBox_Validating(object sender, CancelEventArgs e)
        {
            customerNameBox.BackColor = default(Color);
            string value = customerNameBox.Text;
            validateCustomer(value);
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            materialBox.SelectedIndex = -1;
        }

        private void viewQuoteButton_Click(object sender, EventArgs e)
        {
            DeskQuote quote = new DeskQuote();
            Desk desk = new Desk();
            // If Desk object is empty catch the exception
            try
            {

                desk.Width = Convert.ToInt32(widthBox.Text);
                desk.Depth = Convert.ToInt32(depthBox.Text);
                desk.NumberOfDrawers = Convert.ToInt32(drawerBox.Text);
                desk.SurfaceMaterial = (DesktopMaterial) materialBox.SelectedIndex - 1;
                desk.CustomerName = customerNameBox.Text;
                desk.ShippingCost =
                    quote.CalcShipping(Convert.ToInt32(shippingBox.SelectedIndex), desk.Width, desk.Depth);
                desk.Date = quote.ShowDate();
                desk.OversizeCost = quote.CalcOversizeCost(desk.Width, desk.Depth);
                desk.DrawerCost = quote.CalcDrawerCost(desk.NumberOfDrawers);
                desk.MaterialCost = quote.CalcMaterialCost(Convert.ToInt32(materialBox.SelectedIndex));
                desk.Area = desk.Width * desk.Depth;
                desk.MaterialNotEmpty = materialBox.SelectedIndex;
                desk.ShippingNotEmpty = shippingBox.SelectedIndex;

                if (desk.MaterialNotEmpty == -1 || desk.ShippingNotEmpty == -1)
                {
                    errorLabel.Text = "Please make sure that all fields are filled or selected!";

                }
                else
                {
                    DisplayQuote openDisplayQuote = new DisplayQuote(desk);
                    openDisplayQuote.Tag = this;
                    openDisplayQuote.Show(this);
                    Hide();
                }


            }
            catch
            {
                errorLabel.Text = "Please make sure that all fields are filled or selected!";
            }
        }

        private void MainMenu2_Click(object sender, EventArgs e)
        {
            Mainmenu2 openMainmenu2 = new Mainmenu2();
            openMainmenu2.Tag = this;
            openMainmenu2.Show(this);
            Hide();
        }
    }

} 


