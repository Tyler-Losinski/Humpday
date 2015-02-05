using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Humpday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Activate_Click(object sender, EventArgs e)
        {
            // Check what day it is
            int day = (int)System.DateTime.Now.DayOfWeek;
            if(day == 3)
            {
                // it is Hump Day
                Banner.Text = "Ya it is!";
            }
            else
            {
                Banner.Text = "Not yet silly.";
            }
        }
    }
}
