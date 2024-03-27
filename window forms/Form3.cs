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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] s = { "a", "b", "c" };
            listBox1.Items.AddRange(s);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedIndex.ToString());

        }
    }
}
