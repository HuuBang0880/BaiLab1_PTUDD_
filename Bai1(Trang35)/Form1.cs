using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Bai1_Trang35_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strURL = "mailto:ctk45@gmail.com";
            this.linkLabel1.Links.Add(0,strURL.Length,strURL);
            strURL = "https://www.cnttk45.net";
            this.linkLabel2.Links.Add(0,strURL.Length,strURL);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.ToString());   
            if(strURL.StartsWith("mailto:"))
            {
               Process.Start(strURL + "?subject=hello");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.ToString());
            if(strURL.StartsWith("https://"))
            {
                Process.Start(strURL);
            }
        }
    }
}
