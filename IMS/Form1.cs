using System.Data;
using System.Data.SqlClient;

namespace IMS
{
    public partial class Form1 : Form
    {
        // connection string
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Marty\Documents\imsDB.mdf;Integrated Security=True;Connect Timeout=30");


        public Form1()
        {
            InitializeComponent();
        }

        // this will clear both the username and password
        private void clearLabel_Click(object sender, EventArgs e)
        {
            usernameTB.Text = "";
            passwordTB.Text = "";
        }

        //checkbot that will toggel the visibility of the password
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

        // when the login button is pressed this will establish and connection with the database to validate the data, user will them be routed to the home page or be told if the data is wrong
        private void loginBT_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}