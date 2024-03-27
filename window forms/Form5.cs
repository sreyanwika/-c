using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowss
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                panel1.BackColor=Color.Red;
            }
            else if(radioButton2.Checked)
            {
                panel1.BackColor = Color.Blue;
            }
            else if(radioButton3.Checked) {
                panel1.BackColor = Color.Orange;
            }
        }
    }
}
