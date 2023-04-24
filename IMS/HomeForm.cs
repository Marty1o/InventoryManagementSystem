using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

            // pressing the x will exit the program
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //none

        }

        // this will route the user to the product page
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManageProducts form = new ManageProducts();
            form.Show();
            this.Hide();
        }

        // this will route the user the cosumers page
        private void consumerBox_Click(object sender, EventArgs e)
        {
            ManageCustomers form = new ManageCustomers();
            form.Show();
            this.Hide();
        }

        // this will route the user to the categories page
        private void CatergoryBox_Click(object sender, EventArgs e)
        {
            ManageCategories form = new ManageCategories();
            form.Show();
            this.Hide();
        }

        //this will route the user to the users page
        private void usersBox_Click(object sender, EventArgs e)
        {
            ManageUsers form = new ManageUsers();
            form.Show();
            this.Hide();
        }

        //this will route the user to the orders page
        private void ordersBox_Click(object sender, EventArgs e)
        {
            ManageOrders form = new ManageOrders();
            form.Show();
            this.Hide();
        }

        //this will log out the user and take them back to the home page
        private void logoutBT_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
