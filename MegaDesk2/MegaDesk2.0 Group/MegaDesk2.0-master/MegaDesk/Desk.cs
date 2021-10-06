using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    //enum for the desktop materials
    public enum DesktopMaterial
    {
        Laminate = 100,
        Oak = 200,
        Rosewood = 300,
        Veneer = 125,
        Pine = 50
    };

    class Desk
    {
        //hard set parameters
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
        public const int MINDRAW = 0;
        public const int MAXDRAW = 7;

        //getters and setters
        public int width { get; set; }
        public int depth { get; set; }
        public int drawers { get; set; }
        public DesktopMaterial surfaceMaterial { get; set; }
        public int area { get; set; }
    }
}
