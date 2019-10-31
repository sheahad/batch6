using System;
using System.Collections.Generic;
using System.ComponentModel;
using MyWindowsFormsApp.Model.Model;
using MyWindowsFormsApp.BLL.BLL;



using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWindowsFormsApp.BLL;
using MyWindowsFormsApp.Model;
namespace MyWindowsFormsApp
{
    public partial class ItemUi : Form
    {
        ItemManager _itemManager = new ItemManager();
        Item _item = new Item();
        public ItemUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //_item.Name = nameTextBox.Text;
            
            ////Check UNIQUE
            //if (_itemManager.IsNameExists(_item.Name))
            //{
            //    MessageBox.Show(nameTextBox.Text + "Already Exists!");
            //    return;
            //}

            ////Set Price as Mandatory
            //if (String.IsNullOrEmpty(priceTextBox.Text))            
            //{
            //    MessageBox.Show("Price Can not be Empty!!!");
            //    return;
            //}

            //_item.Price = Convert.ToDouble(priceTextBox.Text);
            ////Add/Insert Item
            ////bool isAdded = _itemManager.Add(_item.Name, _item.Price);
            //bool isAdded = _itemManager.Add(_item);
            
            //if (isAdded)
            //{

            //    MessageBox.Show("Saved");
            //}
            //else
            //{
            //    MessageBox.Show("Not Saved");
            //}

            ////showDataGridView.DataSource = dataTable;
            //showDataGridView.DataSource = _itemManager.Display();

            ////

            MessageBox.Show("Name: " + itemComboBox.Text + " Id: "+ itemComboBox.SelectedValue);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //showDataGridView.DataSource = dataTable;
            showDataGridView.DataSource = _itemManager.Display();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Set Id as Mandatory
            if (String.IsNullOrEmpty(idtextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }

            //Delete
            if (_itemManager.Delete(Convert.ToInt32(idtextBox.Text)))
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }

            //showDataGridView.DataSource = dataTable;
            showDataGridView.DataSource = _itemManager.Display();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //Set Id as Mandatory
            if (String.IsNullOrEmpty(idtextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }
            //Set Price as Mandatory
            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Price Can not be Empty!!!");
                return;
            }

            if (_itemManager.Update(nameTextBox.Text, Convert.ToDouble(priceTextBox.Text), Convert.ToInt32(idtextBox.Text)))
            {
                MessageBox.Show("Updated");
                _itemManager.Display();
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //showDataGridView.DataSource = dataTable;
            showDataGridView.DataSource =_itemManager.Search(nameTextBox.Text);
        }

        private void ItemUi_Load(object sender, EventArgs e)
        {
            itemComboBox.DataSource = _itemManager.ItemCombo();
        }

        
    }
}
