using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchAFish
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Random r = new Random();
        private void Fish_MouseEnter(object sender, EventArgs e)
        { 
            int x = r.Next(0, 925);
            int y = r.Next(0, 445);
            this.Fish.Location = new System.Drawing.Point(x, y);
        }
        
        
    }
}
