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
    public partial class AdminAddUserAccount : Form
    {
        public AddUserDataMgr userDataMgr = new AddUserDataMgr("UserData");
        public AdminAddUserAccount()
        {
            InitializeComponent();
            userDataMgr.UserDataList = userDataMgr.readFromJson<AddUserData>();

            //Adding the roles admin and user to the combo box for role
            RoleComboBox.Items.Add("Admin");
            RoleComboBox.Items.Add("User");
        }

        private void RoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //click event will hide the admin add user form
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //Add user button click event adds user data to the data manager
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            //create an instance of the StudentData object
            AddUserData userData = new AddUserData();

            //Get the selected role from the combo box
            string selectedRole = RoleComboBox.SelectedItem?.ToString();

            //Get data from the fields and save it to the object
            userData.role = selectedRole;
            userData.name = NameBox.Text;
            userData.username = UsernameBox.Text;
            userData.password = PasswordBox.Text;

            //create a new list if the list is null
            if (null == userDataMgr.UserDataList)
            {
                userDataMgr.UserDataList = new List<AddUserData>();
            }

            //add the object to the list
            userDataMgr.UserDataList.Add(userData);

            //write the current list to the file
            userDataMgr.writeToJson(userDataMgr.UserDataList);

            //close the form
            this.Dispose();

            //Show message box
            MessageBox.Show("New user added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}
