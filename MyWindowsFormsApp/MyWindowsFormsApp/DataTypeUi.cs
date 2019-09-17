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
    public partial class DataTypeUi : Form
    {
        public DataTypeUi()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //int age= 0 ;
            //double salary = 5000.50;
            //string name = "Hasan";
            //bool isDone = true;

            string name = nameTextBox.Text;

            int firstNumber =Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber =Convert.ToInt32(secondNumberTextBox.Text);

            int result = firstNumber + secondNumber;

            MessageBox.Show("Name: " + name + " Result =" + result.ToString());

            //int firstNumber = 10;
            //int secondNumber = firstNumber;
            //double thirdNumber = 10.10;

            //secondNumber = (int)thirdNumber;
            //secondNumber = Convert.ToInt32(thirdNumber);



        }
    }
}
