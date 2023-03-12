using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_Trang52_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int itemSelect = listBox1.SelectedItems.Count - 1;
             for (int i = 0; i < itemSelect; i++)
            {
                listBox2.Items.Add(listBox1.SelectedItems[i]);
                listBox1.Items.RemoveAt(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i=listBox2.SelectedItems.Count - 1;
            while(i>=0)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndices[i]);
                i--;
            }
        }
    }
}
