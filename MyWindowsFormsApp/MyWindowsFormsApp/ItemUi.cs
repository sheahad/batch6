using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWindowsFormsApp.BLL;

namespace MyWindowsFormsApp
{
    public partial class ItemUi : Form
    {
        ItemManager _itemManager = new ItemManager();
        public ItemUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Check UNIQUE
            if (_itemManager.IsNameExists(nameTextBox.Text))
            {
                MessageBox.Show(nameTextBox.Text + "Already Exists!");
                return;
            }

            //Set Price as Mandatory
            if (String.IsNullOrEmpty(priceTextBox.Text))            
            {
                MessageBox.Show("Price Can not be Empty!!!");
                return;
            }

            //Add/Insert Item
            bool isAdded = _itemManager.Add(nameTextBox.Text, Convert.ToDouble(priceTextBox.Text));

            if (isAdded)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }

            //showDataGridView.DataSource = dataTable;
            showDataGridView.DataSource = _itemManager.Display();
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
            if (Delete(Convert.ToInt32(idtextBox.Text)))
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
            Search(nameTextBox.Text);
        }

        //Method
       
       
        private bool Delete(int id)
        {
            try
            {
                //Connection
                string connectionString = @"Server=BITM-TRAINER-30\SQLEXPRESS; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //DELETE FROM Items WHERE ID = 3
                string commandString = @"DELETE FROM Items WHERE ID = " + id + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Delete
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }
                

                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }

            return false;
        }
        
        private void Search(string name)
        {
            try
            {
                //Connection
                string connectionString = @"Server=BITM-TRAINER-30\SQLEXPRESS; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM Items WHERE Name='" + name + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    showDataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No Data Found");
                }

                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
        }
    }
}
