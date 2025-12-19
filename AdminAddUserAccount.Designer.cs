namespace CS314App_mseibers
{
    partial class AdminAddUserAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddRoleLabel = new System.Windows.Forms.Label();
            this.AddNameLabel = new System.Windows.Forms.Label();
            this.AddUsernameLabel = new System.Windows.Forms.Label();
            this.AddPasswordLabel = new System.Windows.Forms.Label();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddRoleLabel
            // 
            this.AddRoleLabel.AutoSize = true;
            this.AddRoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddRoleLabel.Location = new System.Drawing.Point(76, 54);
            this.AddRoleLabel.Name = "AddRoleLabel";
            this.AddRoleLabel.Size = new System.Drawing.Size(41, 17);
            this.AddRoleLabel.TabIndex = 0;
            this.AddRoleLabel.Text = "Role:";
            // 
            // AddNameLabel
            // 
            this.AddNameLabel.AutoSize = true;
            this.AddNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddNameLabel.Location = new System.Drawing.Point(68, 109);
            this.AddNameLabel.Name = "AddNameLabel";
            this.AddNameLabel.Size = new System.Drawing.Size(49, 17);
            this.AddNameLabel.TabIndex = 1;
            this.AddNameLabel.Text = "Name:";
            // 
            // AddUsernameLabel
            // 
            this.AddUsernameLabel.AutoSize = true;
            this.AddUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddUsernameLabel.Location = new System.Drawing.Point(40, 163);
            this.AddUsernameLabel.Name = "AddUsernameLabel";
            this.AddUsernameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddUsernameLabel.Size = new System.Drawing.Size(77, 17);
            this.AddUsernameLabel.TabIndex = 2;
            this.AddUsernameLabel.Text = "Username:";
            // 
            // AddPasswordLabel
            // 
            this.AddPasswordLabel.AutoSize = true;
            this.AddPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddPasswordLabel.Location = new System.Drawing.Point(44, 217);
            this.AddPasswordLabel.Name = "AddPasswordLabel";
            this.AddPasswordLabel.Size = new System.Drawing.Size(73, 17);
            this.AddPasswordLabel.TabIndex = 3;
            this.AddPasswordLabel.Text = "Password:";
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Location = new System.Drawing.Point(158, 53);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(169, 21);
            this.RoleComboBox.TabIndex = 4;
            this.RoleComboBox.SelectedIndexChanged += new System.EventHandler(this.RoleComboBox_SelectedIndexChanged);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(158, 108);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(169, 20);
            this.NameBox.TabIndex = 5;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(158, 162);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(169, 20);
            this.UsernameBox.TabIndex = 6;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(158, 216);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(169, 20);
            this.PasswordBox.TabIndex = 7;
            // 
            // AddUserButton
            // 
            this.AddUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddUserButton.Location = new System.Drawing.Point(47, 296);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(122, 50);
            this.AddUserButton.TabIndex = 8;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CloseButton.Location = new System.Drawing.Point(227, 296);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(128, 50);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AdminAddUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 396);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.AddPasswordLabel);
            this.Controls.Add(this.AddUsernameLabel);
            this.Controls.Add(this.AddNameLabel);
            this.Controls.Add(this.AddRoleLabel);
            this.Name = "AdminAddUserAccount";
            this.Text = "Admin - Add User Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddRoleLabel;
        private System.Windows.Forms.Label AddNameLabel;
        private System.Windows.Forms.Label AddUsernameLabel;
        private System.Windows.Forms.Label AddPasswordLabel;
        private System.Windows.Forms.ComboBox RoleComboBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button CloseButton;
    }
}