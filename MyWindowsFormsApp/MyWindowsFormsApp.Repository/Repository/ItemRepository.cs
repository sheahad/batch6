using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MyWindowsFormsApp.Model.Model;
using System.Configuration;

namespace MyWindowsFormsApp.Repository.Repository
{
    public class ItemRepository
    {
        //public bool Add(string name, double price)
        //string connectionString = @"Server=BITM-TRAINER-30\SQLEXPRESS; Database=CoffeeShop; Integrated Security=True";
        //SqlConnection sqlConnection = new SqlConnection(connectionString);
        //SqlConnection sqlConnection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]);
        SqlConnection sqlConnection = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);

        public bool Add(Item item)
        {
            bool isAdded = false;


            try
            {
                //Connection
                //string connectionString = @"Server=BITM-TRAINER-30\SQLEXPRESS; Database=CoffeeShop; Integrated Security=True";
                //SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"INSERT INTO Items (Name, Price) Values ('" + item.Name + "', " + item.Price + ")";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();
                //Insert
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isAdded = true;
                }

                //if (!isNameExists(nameTextBox.Text))
                //{
                //    //Insert
                //    int isExecuted = sqlCommand.ExecuteNonQuery();
                //    if (isExecuted > 0)
                //    {
                //        isAdded = true;
                //    }

                //}
                //else
                //{
                //    MessageBox.Show(nameTextBox.Text + "Already Exists!");
                //}


                //Close
                sqlConnection.Close();


            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }

            return isAdded;
        }
        public bool IsNameExists(string name)
        {
            bool exists = false;
            try
            {
                //Connection
                //string connectionString = @"Server=BITM-TRAINER-30\SQLEXPRESS; Database=CoffeeShop; Integrated Security=True";
                //SqlConnection sqlConnection = new SqlConnection(connectionString);

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
                    exists = true;
                }
                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }

            return exists;
        }
        public bool Update(string name, double price, int id)
        {
            try
            {
                //Connection
                //string connectionString = @"Server=BITM-TRAINER-30\SQLEXPRESS; Database=CoffeeShop; Integrated Security=True";
                //SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //UPDATE Items SET Name =  'Hot' , Price = 130 WHERE ID = 1
                string commandString = @"UPDATE Items SET Name =  '" + name + "' , Price = " + price + " WHERE ID = " + id + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Insert
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
                //MessageBox.Show(exeption.Message);
            }

            return false;
        }
        public DataTable Display()
        {

            //Connection
            //string connectionString = @"Server=BITM-TRAINER-30\SQLEXPRESS; Database=CoffeeShop; Integrated Security=True";
            //SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT * FROM Items";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            //Show
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);


            //if (dataTable.Rows.Count > 0)
            //{
            //    return dataTable;
            //    //showDataGridView.DataSource = dataTable;
            //}
            //else
            //{
            //    MessageBox.Show("No Data Found");
            //}

            //Close
            sqlConnection.Close();
            return dataTable;




        }
        public bool Delete(int id)
        {
            try
            {
                //Connection
                //string connectionString = @"Server=BITM-TRAINER-30\SQLEXPRESS; Database=CoffeeShop; Integrated Security=True";
                //SqlConnection sqlConnection = new SqlConnection(connectionString);

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
                //MessageBox.Show(exeption.Message);
            }

            return false;
        }
        public List<Item> Search(string name)
        {
            //DataTable dataTable = new DataTable();
            List<Item> items = new List<Item>();
            try
            {
                //Connection
                //string connectionString = @"Server=BITM-TRAINER-30\SQLEXPRESS; Database=CoffeeShop; Integrated Security=True";
                //SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM Items WHERE Name='" + name + "'";
                //string commandString = @"SELECT * FROM Items";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Show
                //Using DataAdapter
                //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                ////    DataTable dataTable = new DataTable();
                //sqlDataAdapter.Fill(dataTable);

                //Using DataReader
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Item item = new Item();
                    item.Id = Convert.ToInt32(sqlDataReader["Id"]);
                    item.Name = sqlDataReader["Name"].ToString();
                    item.Price = Convert.ToDouble(sqlDataReader["Price"]);
                    items.Add(item);
                }

                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }

            //return dataTable;
            return items;
        }

        public DataTable ItemCombo()
        {

            //Connection
            //string connectionString = @"Server=BITM-TRAINER-30\SQLEXPRESS; Database=CoffeeShop; Integrated Security=True";
            //SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT Id, Name FROM Items";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            //Show
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);


            //if (dataTable.Rows.Count > 0)
            //{
            //    return dataTable;
            //    //showDataGridView.DataSource = dataTable;
            //}
            //else
            //{
            //    MessageBox.Show("No Data Found");
            //}

            //Close
            sqlConnection.Close();
            return dataTable;




        }
    }
}
