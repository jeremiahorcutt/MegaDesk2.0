using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class DeskQuote
    {
        //declarations
        public String date;
        public string Name;
        public int Rush;
        public int quotePrice;
        public Desk desk = new Desk(); 

        //constants
        public const int PRICE_BASE = 200;
        public const int LOWER_SIZE_LIMIT = 1000;
        public const int UPPER_SIZE_LIMIT = 2000;
        public const int PRICE_PER_AREA = 1;
        public const int PRICE_PER_DRAWER= 50;

        
        public DeskQuote(string name, string quoteDate, int width, int depth, int drawers, DesktopMaterial surface, int rush)
        {
           
            Name = name;
            date = quoteDate;
            desk.width = width;
            desk.depth = depth;
            desk.drawers = drawers;
            desk.surfaceMaterial = surface;
            Rush = rush;
            desk.area = desk.width * desk.depth;
            
        }


        //method for calculating quote price
        public int GetQuote(int rush)
        {
            quotePrice = PRICE_BASE + CalculateAreaCost() + CalculateDrawerCost() + (int)desk.surfaceMaterial + CalculateRushOrderCost(rush);
            return quotePrice;
        }


        //method for calculating the area cost
        private int CalculateAreaCost()
        {
            if (desk.area > LOWER_SIZE_LIMIT)
            {
                return (desk.area - LOWER_SIZE_LIMIT) * PRICE_PER_AREA;
            }
            else
            {
                return 0;
            }
        }

        //method for calculating the drawer cost
        private int CalculateDrawerCost()
        {
            int DrawerCost = desk.drawers * PRICE_PER_DRAWER;
            return DrawerCost;
        }

        //method for determining the rush costs
        private int CalculateRushOrderCost(int rush) {
            int cost = 0;
            switch (rush)
            {
                case 7:
                    if(desk.area < LOWER_SIZE_LIMIT)
                    {
                        cost = 30;
                    }else if(desk.area > UPPER_SIZE_LIMIT){
                        cost = 40;
                    }
                    else
                    {
                        cost = 35;
                    }
                    break;
                case 5:
                    if (desk.area < LOWER_SIZE_LIMIT)
                    {
                        cost = 40;
                    }
                    else if (desk.area > UPPER_SIZE_LIMIT)
                    {
                        cost = 60;
                    }
                    else
                    {
                        cost = 50;
                    }
                    break;
                case 3:
                    if (desk.area < LOWER_SIZE_LIMIT)
                    {
                        cost = 60;
                    }
                    else if (desk.area > UPPER_SIZE_LIMIT)
                    {
                        cost = 80;
                    }
                    else
                    {
                        cost = 70;
                    }
                    break;
            }
            return cost;
        }
    }
 }

