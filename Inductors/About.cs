using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inductors
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void richTextBox3_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            //works if the textbox contains one link only
            try
            {
                System.Diagnostics.Process.Start("www.cqf.su");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно открыть ссылку: " + ex.Message);
            }
        }
    }
}
