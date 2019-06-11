using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dodge
{
    public partial class frmdodge : Form
    {
        Graphics g; //declare a graphics object called g
                    // declare space for an array of 7 objects called planet 
        planet[] planet = new planet[7];


        public frmdodge()
        {
            InitializeComponent();
        }

        private void frmdodge_Load(object sender, EventArgs e)
        {

        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        { 
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawPlanet method to draw the image planet1 
            planet1.drawPlanet(g);
        }

    }
}

