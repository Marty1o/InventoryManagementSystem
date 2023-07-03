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

namespace IMS
{
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

        private void ExitAppLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        DataTable table = new DataTable();

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Marty\Documents\imsDB.mdf;Integrated Security=True;Connect Timeout=30");

        void refresj()
        {
            try
            {
                Con.Open();

                string query = "select * from CustomerTable";
                SqlDataAdapter dat = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dat);
                var set = new DataSet();
                dat.Fill(set);
                CustomersGV.DataSource = set.Tables[0];

                Con.Close();
            }
            catch
            {

            }
        }

        void populateproducts()
        {
            try
            {
                Con.Open();

                string query = "select * from ProductTable";
                SqlDataAdapter data = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(data);
                var das = new DataSet();
                data.Fill(das);
                ProductGV.DataSource = das.Tables[0];

                Con.Close();
            }
            catch
            {

            }
        }

        void updateCat()
        {
            string query = "select * from CategoryTable";
            SqlCommand command = new SqlCommand(query, Con);
            SqlDataReader reader;

            try
            {
                Con.Open();

                DataTable data = new DataTable();
                data.Columns.Add("CatName", typeof(string));
                reader = command.ExecuteReader();
                data.Load(reader);

                searchCB.ValueMember = "CatName";
                searchCB.DataSource = data;

                Con.Close();
            }
            catch
            {

            }
        }

        void prodUpdate()
        {

            int id = Convert.ToInt32(ProductGV.SelectedRows[0].Cells[0].Value.ToString());
            int quant = stock - Convert.ToInt32(quantityTB.Text);
            if (quant < 0)
            {
                MessageBox.Show("Failed");
            }
            else
            {
                Con.Open();
                string query = "update ProductTable set ProductQuantity = '" + quant + "' where ProductId = '" + id + "';";
                SqlCommand command = new SqlCommand(query, Con);
                command.ExecuteNonQuery();
                Con.Close();

                populateproducts();
            }
        }

        int num = 0;
        int sum = 0;
        int uprice, totprice, quantity;
        string product;

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            refresj();
            populateproducts();
            updateCat();

            table.Columns.Add("num", typeof(int));
            table.Columns.Add("product", typeof(string));
            table.Columns.Add("qty", typeof(int));
            table.Columns.Add("uprice", typeof(int));
            table.Columns.Add("totprice", typeof(int));
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CustomersGV.SelectedRows.Count > 0)
            {
                customerIdTB.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
                customernameTB.Text = CustomersGV.SelectedRows[0].Cells[2].Value.ToString();

            }

            //MessageBox.Show(CustomersGV.SelectedRows.Count.ToString());
        }

        private void searchCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                string myQuery = "select * from ProductTable where ProductionCat = '" + searchCB.SelectedValue.ToString() + "'";
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

        int flag = 0;
        int stock;

        private void ProductGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (ProductGV.SelectedRows.Count > 0)
            {
                product = ProductGV.SelectedRows[0].Cells[1].Value.ToString();
                stock = Convert.ToInt32(ProductGV.SelectedRows[0].Cells[2].Value.ToString());
                uprice = Convert.ToInt32(ProductGV.SelectedRows[0].Cells[3].Value.ToString());

                flag = 1;
            }
        }

        private void addCustomerBT_Click(object sender, EventArgs e)
        {



            if (quantityTB.Text == "0")
            {
                MessageBox.Show("Enter the Quantity of Products");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select a product please");
            }
            else if (Convert.ToInt32(quantityTB.Text) > stock)
            {
                MessageBox.Show("Not enough items in stock to cover this order, please select less of this item");
            }
            else
            {
                num = num + 1;
                quantity = Convert.ToInt32(quantityTB.Text);
                totprice = quantity * uprice;
                table.Rows.Add(num, product, quantity, uprice, totprice);
                OrderGV.DataSource = table;
                flag = 0;

            }

            sum = sum + totprice;
            totalAmountLB.Text = sum.ToString();
            prodUpdate();

        }

        private void insertOrderBT_Click(object sender, EventArgs e)
        {
            if (orderIdTB.Text == "" || customerIdTB.Text == "" || customernameTB.Text == "" || totalAmountLB.Text == "")
            {
                MessageBox.Show("Make sure all data is selected or filled out please");
            }
            else
            {
                Con.Open();
                SqlCommand command = new SqlCommand("insert into OrdersTable values('" + orderIdTB.Text + "','" + customerIdTB.Text + "','" + customernameTB.Text + "','" + orderDate.Text + "','" + totalAmountLB.Text + "');", Con);
                command.ExecuteNonQuery();
                MessageBox.Show("Order has successfully been added!");
                Con.Close();
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message);
                }
            }
        }

        private void viewOrderBT_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeForm form = new HomeForm();
            form.Show();
            this.Hide();
        }
    }
}
