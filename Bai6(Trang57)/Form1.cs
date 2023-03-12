using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6_Trang57_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(this.checkBox1.Checked)
            {
                this.bt.BackColor = Color.LightCyan;

            }
            else
            {
                this.bt.BackColor = Color.Black;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(this.checkBox2.Checked)
            {
                this.bt.ForeColor = Color.Red;
            }
            else 
                this.bt.ForeColor = Color.Black;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(this.radioButton1.Checked)
            {
                this.btFlat.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                this.btFlat.FlatStyle = FlatStyle.Popup;
            }
        }
    }
}
