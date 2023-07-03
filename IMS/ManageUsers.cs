using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace IMS
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Marty\Documents\imsDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populate()
        {
            try
            {
                Con.Open();

                string myQuery = "select * from UserTable";
                SqlDataAdapter da = new SqlDataAdapter(myQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UsersGV.DataSource = ds.Tables[0];

                Con.Close();
            }
            catch
            {

            }
        }

        private void addUserBT_Click(object sender, EventArgs e)
        {

            if (ValidateInput())
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into UserTable values('" + usernameTB.Text + "','" + emailTB.Text + "','" + fullNameTB.Text + "','" + passwordTB.Text + "','" + phoneTB.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User has successfully been added!");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message);
                }
            }

        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void deleteUserBT_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    Con.Open();

                    string myquery = "delete from UserTable where Uphone = '" + phoneTB.Text + "';";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User has now been deleted");

                    Con.Close();

                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user: " + ex.Message);
                }
            }
        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UsersGV.SelectedRows.Count > 0)
            {
                usernameTB.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
                emailTB.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
                fullNameTB.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
                passwordTB.Text = UsersGV.SelectedRows[0].Cells[3].Value.ToString();
                phoneTB.Text = UsersGV.SelectedRows[0].Cells[4].Value.ToString();
            }

            //MessageBox.Show(UsersGV.SelectedRows.Count.ToString());

        }

        private void editUserBT_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update UserTable set username = '" + usernameTB.Text + "', Uemail = '" + emailTB.Text + "', Ufullname = '" + fullNameTB.Text + "', Upassword = '" + passwordTB.Text + "' where Uphone = '" + phoneTB.Text + "'", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User has successfully been updated!");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message);
                }
            }
        }

        private void homeBT_Click(object sender, EventArgs e)
        {
            HomeForm prod = new HomeForm();
            prod.Show();
            this.Hide();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(usernameTB.Text))
            {
                MessageBox.Show("Please enter a value into the Username text box.");
                usernameTB.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(emailTB.Text))
            {
                MessageBox.Show("Please enter a value into the Email text box.");
                emailTB.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(fullNameTB.Text))
            {
                MessageBox.Show("Please enter a value into the Name text box.");
                fullNameTB.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(passwordTB.Text))
            {
                MessageBox.Show("Please enter a value into the Password text box.");
                passwordTB.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(phoneTB.Text))
            {
                MessageBox.Show("Please enter a value into the Phone Number text box.");
                phoneTB.Focus();
                return false;
            }

            if (Regex.IsMatch(phoneTB.Text, "[a-zA-Z]"))
            {
                MessageBox.Show("Textbox contains alphabetical characters. Please enter a valid Phone number.");
                phoneTB.Focus();
                return false;
            }

            

            return true;
        }
    }
}
