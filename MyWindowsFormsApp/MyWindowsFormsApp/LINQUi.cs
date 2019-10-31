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
    public partial class LINQUi : Form
    {
        public LINQUi()
        {
            InitializeComponent();
            string[] countries = { "India", "Australia", "USA", "Argentina", "Peru", "China" };



            IEnumerable<string> result = countries.Where(x => x.StartsWith("A"));

            // displayDataGridView.DataSource = result;
        }
    }
}
