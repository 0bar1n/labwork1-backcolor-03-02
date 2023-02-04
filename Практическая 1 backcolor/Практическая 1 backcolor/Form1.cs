using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_1_backcolor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst.SelectedItem == "black")
            {
                txt.BackColor = System.Drawing.Color.Black;
            }
            else if (lst.SelectedItem == "red")
            {
                txt.BackColor = System.Drawing.Color.Red;
            }
            else if (lst.SelectedItem == "blue")
            {
                txt.BackColor = System.Drawing.Color.Blue;
            }
            else if (lst.SelectedItem == "green")
            {
                txt.BackColor = System.Drawing.Color.Green;
            }
        }
    }
}
