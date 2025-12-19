using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS314App_mseibers
{
    public partial class AdminHomeForm : Form
    {
        public AdminHomeForm()
        {
            InitializeComponent();
        }

        //Add new user button click event to show the admin add user form
        private void AddNewUserButton_Click(object sender, EventArgs e)
        {
            AdminAddUserAccount adminAddUserForm = new AdminAddUserAccount();
            adminAddUserForm.ShowDialog(); //ShowDialog() not Show()
        }

        //Modify new user button click event to show the admin modify user form
        private void ModifyNewUserButton_Click(object sender, EventArgs e)
        {
            AdminModifyUserAccount adminModifyUserForm = new AdminModifyUserAccount();
            adminModifyUserForm.ShowDialog(); //ShowDialog() not Show()
        }

        //Sign out button click event to show login screen again and close the admin home form
        private void SignOutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog(); //ShowDialog() not Show()

            this.Close();
        }
    }
}
