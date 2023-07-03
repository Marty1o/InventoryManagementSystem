using System.Data;
using System.Data.SqlClient;

namespace IMS
{
    public partial class Login : Form
    {
        // connection string
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Marty\Documents\imsDB.mdf;Integrated Security=True;Connect Timeout=30");


        public Login()
        {
            InitializeComponent();
        }

        // this will clear both the username and password
        private void clearLabel_Click(object sender, EventArgs e)
        {
            usernameTB.Text = "";
            passwordTB.Text = "";
        }

        // checkbot that will toggle the visibility of the password
        private void showPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckbox.Checked)
            {
                passwordTB.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTB.UseSystemPasswordChar = true;
            }
        }

        // when the login button is pressed this will establish a connection with the database to validate the data, user will then be routed to the home page or be told if the data is wrong
        private void loginBT_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Con.Open();
                SqlDataAdapter conn = new SqlDataAdapter("select Count(*) from UserTable where username = '" + usernameTB.Text + "' and Upassword = '" + passwordTB.Text + "'", Con);
                DataTable data = new DataTable();
                conn.Fill(data);
                if (data.Rows[0][0].ToString() == "1")
                {
                    HomeForm form = new HomeForm();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username or password entered!");
                }
                Con.Close();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(usernameTB.Text))
            {
                MessageBox.Show("Please enter a value into the username text box.");
                usernameTB.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(passwordTB.Text))
            {
                MessageBox.Show("Please enter a value into the password text box.");
                passwordTB.Focus();
                return false;
            }

            return true;
        }

        private void ExitAppLabel_Click(object sender, EventArgs e)
        {
            // pressing the x will exit the program
            Application.Exit();
        }
    }
}
