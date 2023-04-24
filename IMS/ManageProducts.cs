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

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addCustomerBT_Click(object sender, EventArgs e)
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

        private void deleteCustomerBT_Click(object sender, EventArgs e)
        {
            if (productIdTB.Text == "")
            {
                MessageBox.Show("Please enter a valid product id number!");
                return;
            }

            else if (Regex.IsMatch(productIdTB.Text, "[a-zA-Z]"))
            {
                MessageBox.Show("Textbox contains alphabetical characters.");
                return;
            }

            else
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

        private void editCustomerBT_Click(object sender, EventArgs e)
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

        private void prodFilterBT_Click(object sender, EventArgs e)
        {
            filterbycategory();
        }

        private void searchRefreshBT_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void CusHomeBT_Click(object sender, EventArgs e)
        {
            HomeForm prod = new HomeForm();
            prod.Show();
            this.Hide();
        }
    }
}
