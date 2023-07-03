using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class ManageProducts : Form
    {

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Marty\Documents\imsDB.mdf;Integrated Security=True;Connect Timeout=30");

        void fillCategory()
        {
            string query = "select * from CategoryTable";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;

            try
            {
                Con.Open();

                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                prodCategoryCB.ValueMember = "CatName";
                prodCategoryCB.DataSource = dt;
                FilterCatCB.ValueMember = "CatName";
                FilterCatCB.DataSource = dt;

                Con.Close();
            }
            catch
            {

            }
        }



        void populate()
        {
            try
            {
                Con.Open();

                string myQuery = "select * from ProductTable";
                SqlDataAdapter da = new SqlDataAdapter(myQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductGV.DataSource = ds.Tables[0];

                Con.Close();
            }
            catch
            {

            }
        }

        void filterbycategory()
        {
            try
            {
                Con.Open();

                string myQuery = "select * from ProductTable where ProductionCat = '" + FilterCatCB.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(myQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductGV.DataSource = ds.Tables[0];

                Con.Close();
            }
            catch
            {

            }
        }

        public ManageProducts()
        {
            InitializeComponent();
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {

            fillCategory();
            populate();
        }

        private void ExitAppLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addProductBT_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ProductTable values('" + productIdTB.Text + "','" + prodNameTB.Text + "','" + prodQuantityTB.Text + "','" + prodPriceTB.Text + "','" + prodDesTB.Text + "','" + prodCategoryCB.SelectedValue.ToString() + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product has successfully been added!");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message);
                }
            }
        }

        private void deleteProductBT_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    Con.Open();

                    string myquery = "delete from ProductTable where ProductId = '" + productIdTB.Text + "';";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product has now been deleted");

                    Con.Close();

                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user: " + ex.Message);
                }
            }
        }

        private void ProductGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductGV.SelectedRows.Count > 0)
            {
                productIdTB.Text = ProductGV.SelectedRows[0].Cells[0].Value.ToString();
                prodNameTB.Text = ProductGV.SelectedRows[0].Cells[1].Value.ToString();
                prodQuantityTB.Text = ProductGV.SelectedRows[0].Cells[2].Value.ToString();
                prodPriceTB.Text = ProductGV.SelectedRows[0].Cells[3].Value.ToString();
                prodDesTB.Text = ProductGV.SelectedRows[0].Cells[4].Value.ToString();
                prodCategoryCB.SelectedValue = ProductGV.SelectedRows[0].Cells[5].Value.ToString();
            }

            //MessageBox.Show(CustomersGV.SelectedRows.Count.ToString());
        }

        private void editProductBT_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update ProductTable set ProductName = '" + prodNameTB.Text + "', ProductQuantity = '" + prodQuantityTB.Text + "', ProductPrice = '" + prodPriceTB.Text + "', ProductDescription = '" + prodDesTB.Text + "', ProductionCat = '" + prodCategoryCB.SelectedValue.ToString() + "' where ProductId = '" + productIdTB.Text + "'", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product has successfully been updated!");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message);
                }
            }
        }

        private void prodFilterBT_Click(object sender, EventArgs e)
        {
            filterbycategory();
        }

        private void searchRefreshBT_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void ProdHomeBT_Click(object sender, EventArgs e)
        {
            HomeForm prod = new HomeForm();
            prod.Show();
            this.Hide();
        }

        private bool ValidateInput()
        {

            //empty check
            if (string.IsNullOrWhiteSpace(productIdTB.Text))
            {
                MessageBox.Show("Please enter a value into the Product ID text box.");
                productIdTB.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(prodNameTB.Text))
            {
                MessageBox.Show("Please enter a name into the Product Name text box.");
                prodNameTB.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(prodQuantityTB.Text))
            {
                MessageBox.Show("Please enter a number into the Quantity text box.");
                prodQuantityTB.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(prodPriceTB.Text))
            {
                MessageBox.Show("Please enter a number into the Product Price text box.");
                prodPriceTB.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(prodDesTB.Text))
            {
                MessageBox.Show("Please enter a description into the description text box.");
                prodDesTB.Focus();
                return false;
            }

            //int check
            if (Regex.IsMatch(productIdTB.Text, "[a-zA-Z]"))
            {
                MessageBox.Show("Textbox contains alphabetical characters. Please enter a valid ID number.");
                productIdTB.Focus();
                return false;
            }

            if (Regex.IsMatch(prodQuantityTB.Text, "[a-zA-Z]"))
            {
                MessageBox.Show("Textbox contains alphabetical characters. Please enter a valid quantity number.");
                prodQuantityTB.Focus();
                return false;
            }

            if (Regex.IsMatch(prodPriceTB.Text, "[a-zA-Z]"))
            {
                MessageBox.Show("Textbox contains alphabetical characters. Please enter a valid Price.");
                prodPriceTB.Focus();
                return false;
            }

            return true;
        }
    }
}
