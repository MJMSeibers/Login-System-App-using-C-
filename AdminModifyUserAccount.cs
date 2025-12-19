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
    public partial class AdminModifyUserAccount : Form
    {
        //Data manager
        public AddUserDataMgr addUserDataMgr = new AddUserDataMgr("UserData");

        //stores the selected index
        int index;

        public AdminModifyUserAccount()
        {
            InitializeComponent();

            //load user data from the json file
            addUserDataMgr.UserDataList = addUserDataMgr.readFromJson<AddUserData>();

            //Get the items for the user list box
            updateUserList();

            //Disable the user data panel
            //update button initially
            panel1.Enabled = false;
            UpdateAccountButton.Enabled = false;

            //Form load event
            this.Load += AdminModifyUserAccount_Load;
        }

        //Method called getCurrentUsers()
        public void updateUserList()
        {
            //Clear all items first
            UserAccountsComboBox.Items.Clear();
            UserAccountsComboBox.SelectedIndex = -1;
            RoleComboBox.Items.Clear();
            RoleComboBox.SelectedIndex = -1;
            NameBox.Text = "";
            UsernameBox.Text = "";
            PasswordBox.Text = "";

            //If the list is null, then return
            if (null == addUserDataMgr.UserDataList) { return; }

            //Loop through the data list table and add the names to the list
            foreach (var data in  addUserDataMgr.UserDataList)
            {
                //Take the name field and add it to the students combo list
                UserAccountsComboBox.Items.Add(data.name);
            }

        }
        private void UserAccountsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Enable the data panel and the update button
            panel1.Enabled = true;
            UpdateAccountButton.Enabled = true;

            //Get the index of the selected iteme
            index = UserAccountsComboBox.SelectedIndex;

            //Adding the roles admin and user to the combo box for role
            RoleComboBox.Items.Add("Admin");
            RoleComboBox.Items.Add("User");

            //Fill in the text boxes with the data from data table
            RoleComboBox.Text = addUserDataMgr.UserDataList[index].role;
            NameBox.Text = addUserDataMgr.UserDataList[index].name;
            UsernameBox.Text = addUserDataMgr.UserDataList[index].username;
            PasswordBox.Text = addUserDataMgr.UserDataList[index].password;

        }

        //Update account button click event has added call to the getCurrentUsers() method
        //It also shows message Coming Soon 
        private void UpdateAccountButton_Click(object sender, EventArgs e)
        {
            //Read the data and update the list
            //get data from the field and save it to the object
            addUserDataMgr.UserDataList[index].name= NameBox.Text;
            addUserDataMgr.UserDataList[index].username= UsernameBox.Text;
            addUserDataMgr.UserDataList[index].password= PasswordBox.Text;
            addUserDataMgr.UserDataList[index].role = RoleComboBox.Text;

            //get the items for the student list box
            updateUserList();

            //Disable the user data panel and the update button again
            panel1.Enabled = false;
            UpdateAccountButton.Enabled = false;

            //write the current list to the file
            addUserDataMgr.writeToJson(addUserDataMgr.UserDataList);

            //successfully updated message
            MessageBox.Show("User account modified successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Close button click event will close this form by hiding it
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Form load event with added call to the getCurrentUsers() method
        private void AdminModifyUserAccount_Load(object sender, EventArgs e)
        {
            updateUserList();
        }

    }
}
