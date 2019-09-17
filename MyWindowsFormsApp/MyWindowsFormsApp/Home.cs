using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsFormsApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Hello " + nameTextBox.Text);
            showLabel.Text = nameTextBox.Text;
        }

       
    }
}
