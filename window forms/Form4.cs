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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.Text = "item  checkeddd";
            }
            else if (checkBox2.Checked)
            {
                label1.Text = "item   checkeddd";
            }
            else
            {
                label1.Text = "un checkeddd";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
