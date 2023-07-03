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
    public partial class ManageCategories : Form
    {
        //connections string to use later on
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Marty\Documents\imsDB.mdf;Integrated Security=True;Connect Timeout=30");

        //method to be called on when we can to refresh the data
        void refresh()
        {
            try
            {
                Con.Open();

                string myQuery = "select * from CategoryTable";
                SqlDataAdapter da = new SqlDataAdapter(myQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CategoryGV.DataSource = ds.Tables[0];

                Con.Close();
            }
            catch
            {

            }
        }

        public ManageCategories()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void ManageCategories_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void CategoryGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CategoryGV.SelectedRows.Count > 0)
            {
                prodCategoryIdTB.Text = CategoryGV.SelectedRows[0].Cells[0].Value.ToString();
                categoryNameTB.Text = CategoryGV.SelectedRows[0].Cells[1].Value.ToString();

            }

            //MessageBox.Show(CategoryGV.SelectedRows.Count.ToString());
        }

        private void addCategoryBT_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    Con.Open();
                    SqlCommand command = new SqlCommand("insert into CategoryTable values('" + prodCategoryIdTB.Text + "','" + categoryNameTB.Text + "')", Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category has successfully been added!");
                    Con.Close();
                    refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message);
                }
            }
        }

        private void deleteCategoryBT_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    Con.Open();

                    string query = "delete from CategoryTable where CatId = '" + prodCategoryIdTB.Text + "';";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category has now been deleted");

                    Con.Close();

                    refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user: " + ex.Message);
                }
            }
        }

        // method used to edit the categories, data is pulled and then updated via cat id
        private void editCategoryBT_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    Con.Open();
                    SqlCommand command = new SqlCommand("update CategoryTable set CatName = '" + categoryNameTB.Text + "' where CatId = '" + prodCategoryIdTB.Text + "'", Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category has successfully been updated!");
                    Con.Close();
                    refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message);
                }
            }
        }

        private void CatHomeBT_Click(object sender, EventArgs e)
        {
            HomeForm form = new HomeForm();
            form.Show();
            this.Hide();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(prodCategoryIdTB.Text))
            {
                MessageBox.Show("Please enter a value into the Category ID text box.");
                prodCategoryIdTB.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(categoryNameTB.Text))
            {
                MessageBox.Show("Please enter a name into the Category Name text box.");
                categoryNameTB.Focus();
                return false;
            }

            if (Regex.IsMatch(prodCategoryIdTB.Text, "[a-zA-Z]"))
            {
                MessageBox.Show("Textbox contains alphabetical characters. Please enter a valid ID number");
                categoryNameTB.Focus();
                return false;
            }

            return true;
        }
    }
}
