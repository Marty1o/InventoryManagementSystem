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
    public partial class ManageCustomers : Form
    {

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Marty\Documents\imsDB.mdf;Integrated Security=True;Connect Timeout=30");

        void refresh()
        {
            try
            {
                Con.Open();

                string guery = "select * from CustomerTable";
                SqlDataAdapter data = new SqlDataAdapter(guery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(data);
                var dss = new DataSet();
                data.Fill(dss);
                CustomersGV.DataSource = dss.Tables[0];

                Con.Close();
            }
            catch
            {

            }
        }

        public ManageCustomers()
        {
            InitializeComponent();
        }


        private void ExitAppLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addCustomerBT_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    Con.Open();
                    SqlCommand command = new SqlCommand("insert into CustomerTable values('" + customerIdTB.Text + "','" + CemailTB.Text + "','" + CfullNameTB.Text + "','" + CphoneTB.Text + "')", Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Customer has successfully been added!");
                    Con.Close();
                    refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message);
                }
            }
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CustomersGV.SelectedRows.Count > 0)
            {
                customerIdTB.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
                CemailTB.Text = CustomersGV.SelectedRows[0].Cells[1].Value.ToString();
                CfullNameTB.Text = CustomersGV.SelectedRows[0].Cells[2].Value.ToString();
                CphoneTB.Text = CustomersGV.SelectedRows[0].Cells[3].Value.ToString();

                Con.Open();
                SqlDataAdapter conn = new SqlDataAdapter("select Count(*) from OrdersTable where CustId = " + customerIdTB.Text + "", Con);
                DataTable data = new DataTable();
                conn.Fill(data);
                OrderLabel.Text = data.Rows[0][0].ToString();

                SqlDataAdapter conn1 = new SqlDataAdapter("select Sum(TotalAmt) from OrdersTable where CustId = " + customerIdTB.Text + "", Con);
                DataTable data1 = new DataTable();
                conn1.Fill(data1);
                AmountLabel.Text = data1.Rows[0][0].ToString();

                SqlDataAdapter conn2 = new SqlDataAdapter("select Max(OrderDate) from OrdersTable where CustId = " + customerIdTB.Text + "", Con);
                DataTable data2 = new DataTable();
                conn2.Fill(data2);
                DateLabel.Text = data2.Rows[0][0].ToString();

                Con.Close();
            }

            //MessageBox.Show(CustomersGV.SelectedRows.Count.ToString());
        }

        private void deleteCustomerBT_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    Con.Open();

                    string query = "delete from CustomerTable where CustomerId = " + customerIdTB.Text + ";";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Customer has now been deleted");

                    Con.Close();

                    refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user: " + ex.Message);
                }
            }
        }

        private void editCustomerBT_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    Con.Open();
                    SqlCommand command = new SqlCommand("update CustomerTable set CustomerEmail = '" + CemailTB.Text + "', CustomerFullName = '" + CfullNameTB.Text + "', CustomerPhone = '" + CphoneTB.Text + "' where CustomerId = '" + customerIdTB.Text + "'", Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Customer has successfully been updated!");
                    Con.Close();
                    refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message);
                }
            }
        }

        private void CusHomeBT_Click(object sender, EventArgs e)
        {
            HomeForm form = new HomeForm();
            form.Show();
            this.Hide();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(customerIdTB.Text))
            {
                MessageBox.Show("Please enter a value into the Customer ID text box.");
                customerIdTB.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(CemailTB.Text))
            {
                MessageBox.Show("Please enter a value into the Email text box.");
                CemailTB.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(CfullNameTB.Text))
            {
                MessageBox.Show("Please enter a value into the Name text box.");
                CfullNameTB.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(CphoneTB.Text))
            {
                MessageBox.Show("Please enter a value into the Phone Number text box.");
                CphoneTB.Focus();
                return false;
            }

            if (Regex.IsMatch(CphoneTB.Text, "[a-zA-Z]"))
            {
                MessageBox.Show("Textbox contains alphabetical characters. Please enter a valid Phone number");
                CphoneTB.Focus();
                return false;
            }

            if (Regex.IsMatch(customerIdTB.Text, "[a-zA-Z]"))
            {
                MessageBox.Show("Textbox contains alphabetical characters. Please enter a valid Customer ID number");
                customerIdTB.Focus();
                return false;
            }

            return true;
        }
    }
}
