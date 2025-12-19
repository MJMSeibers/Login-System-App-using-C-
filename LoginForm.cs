using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CS314App_mseibers
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();

            //Close application
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameText.Text; //Declare username and password text box
            string password = PasswordText.Text;

            if (username == "admin" && password == "admin1") //login for admin
            {
                AdminHomeForm homeForm = new AdminHomeForm(); //go to admin home form
                homeForm.ShowDialog(); //ShowDialog() not Show()

                this.Hide(); //hide login form from user
            }
            if (username == "user1" && password == "user123") //login for user1
            {
                UserHomeForm homeForm = new UserHomeForm(); //go to user home form
                homeForm.ShowDialog(); //ShowDialog() not Show()

                this.Hide(); //hide login form from user
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); //Show invalid message if incorrect login
            }
        }

        private void UsernameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
