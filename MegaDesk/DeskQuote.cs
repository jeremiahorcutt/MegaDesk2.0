using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
        public static int[,] RushPrices;
        public int quotePrice;
        public Desk desk = new Desk();

        //constants
        public const int PRICE_BASE = 200;
        public const int LOWER_SIZE_LIMIT = 1000;
        public const int UPPER_SIZE_LIMIT = 2000;
        public const int PRICE_PER_AREA = 1;
        public const int PRICE_PER_DRAWER= 50;
        public const int _3_DAYS = 0;
        public const int _5_DAYS = 1;
        public const int _7_DAYS = 2;
        public const int _LT_1K = 0;
        public const int _1K_2K = 1;
        public const int _GT_2K = 2;


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

        //method for reading rush order prices from file "rushOrderPrices.txt"
        public static bool GetRushOrder()
        {
            const string URL = "./rushOrderPrices.txt";
            string[] fs;
            try
            {
                fs = File.ReadAllLines(URL);
                Console.WriteLine("Reading file...");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error reading file: {e}");
                return false;
            }

            RushPrices = new int[3, 3];
            int pIndex = 0;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    RushPrices[row, col] = Int32.Parse(fs[pIndex]);
                    pIndex++;
                }
            }
            return true;
        }

        //method for determining the rush costs
        private int CalculateRushOrderCost(int rush) {
            int cost = 0;
            switch (rush)
            {
                case 7:
                    if(desk.area < LOWER_SIZE_LIMIT)
                    {
                        cost = RushPrices[_7_DAYS,_LT_1K];
                    }
                    else if(desk.area > UPPER_SIZE_LIMIT)
                    {
                        cost = RushPrices[_7_DAYS, _1K_2K];
                    }
                    else
                    {
                        cost = RushPrices[_7_DAYS, _GT_2K];
                    }
                    break;
                case 5:
                    if (desk.area < LOWER_SIZE_LIMIT)
                    {
                        cost = RushPrices[_5_DAYS, _LT_1K];
                    }
                    else if (desk.area > UPPER_SIZE_LIMIT)
                    {
                        cost = RushPrices[_5_DAYS, _1K_2K];
                    }
                    else
                    {
                        cost = RushPrices[_5_DAYS, _GT_2K];
                    }
                    break;
                case 3:
                    if (desk.area < LOWER_SIZE_LIMIT)
                    {
                        cost = RushPrices[_3_DAYS, _LT_1K];
                    }
                    else if (desk.area > UPPER_SIZE_LIMIT)
                    {
                        cost = RushPrices[_3_DAYS, _1K_2K];
                    }
                    else
                    {
                        cost = RushPrices[_3_DAYS, _GT_2K];
                    }
                    break;
            }
            return cost;
        }
    }
 }

