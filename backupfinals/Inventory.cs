using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace backupfinals
{
    public partial class Inventory : Form
    {

        private MySqlConnection connection;
        public Inventory()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=finalsdb;username=root;password=;");
        }
        private void Inventory_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            try
            {
                connection.Open();
                string showallrecords = "SELECT ID, Brand, Price, Flavor FROM user ORDER BY ID ASC";
                MySqlCommand command = new MySqlCommand(showallrecords, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtBrand.Text = row.Cells["Brand"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtFlavor.Text = row.Cells["Flavor"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Brand= txtBrand.Text;
            string Price=txtPrice.Text;
            string Flavor=txtFlavor.Text;
          

            if (string.IsNullOrWhiteSpace(Brand) || string.IsNullOrWhiteSpace(Price) || string.IsNullOrWhiteSpace(Flavor))
            {
                MessageBox.Show("Please enter both Brand, Price and Flavor");
            }
            try
            {
                connection.Open();
                string registerquery = "INSERT INTO user (Brand, Price, Flavor,) VALUES (@Brand, @Price, @Flavor)";
                MySqlCommand command = new MySqlCommand(registerquery, connection);
                command.Parameters.AddWithValue("@Brand", Brand);
                command.Parameters.AddWithValue("@Price", Price);
                command.Parameters.AddWithValue("@Flavor", Flavor);
             
                int rowaffected = command.ExecuteNonQuery();
                if (rowaffected > 0)
                {
                    MessageBox.Show("Account Successfully Registered");
                }
                else
                {
                    MessageBox.Show("Account Failed to Register!, Please Try Again.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                loaddata();
            }
        }
    }

}
