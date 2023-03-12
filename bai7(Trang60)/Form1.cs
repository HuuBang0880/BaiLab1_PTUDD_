using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai7_Trang60_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)

                if (this.checkedListBox1.GetItemChecked(i) == true)

                    s += this.checkedListBox1.Items[i].ToString() + ",";


            MessageBox.Show($"Danh sach mon hoc:{s}");


        }

       
    }
}
