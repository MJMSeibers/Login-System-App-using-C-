namespace CS314App_mseibers
{
    partial class AdminModifyUserAccount
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
            this.UserAccountsLabel = new System.Windows.Forms.Label();
            this.UserAccountsComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.UpdateAccountButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserAccountsLabel
            // 
            this.UserAccountsLabel.AutoSize = true;
            this.UserAccountsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UserAccountsLabel.Location = new System.Drawing.Point(20, 41);
            this.UserAccountsLabel.Name = "UserAccountsLabel";
            this.UserAccountsLabel.Size = new System.Drawing.Size(104, 17);
            this.UserAccountsLabel.TabIndex = 0;
            this.UserAccountsLabel.Text = "User Accounts:";
            // 
            // UserAccountsComboBox
            // 
            this.UserAccountsComboBox.FormattingEnabled = true;
            this.UserAccountsComboBox.Location = new System.Drawing.Point(145, 41);
            this.UserAccountsComboBox.Name = "UserAccountsComboBox";
            this.UserAccountsComboBox.Size = new System.Drawing.Size(223, 21);
            this.UserAccountsComboBox.TabIndex = 1;
            this.UserAccountsComboBox.SelectedIndexChanged += new System.EventHandler(this.UserAccountsComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PasswordBox);
            this.panel1.Controls.Add(this.UsernameBox);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.RoleComboBox);
            this.panel1.Controls.Add(this.PasswordLabel);
            this.panel1.Controls.Add(this.UsernameLabel);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.RoleLabel);
            this.panel1.Location = new System.Drawing.Point(23, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 264);
            this.panel1.TabIndex = 2;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(108, 206);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(189, 20);
            this.PasswordBox.TabIndex = 7;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(105, 147);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(192, 20);
            this.UsernameBox.TabIndex = 6;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(105, 93);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(192, 20);
            this.NameBox.TabIndex = 5;
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Location = new System.Drawing.Point(105, 32);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(192, 21);
            this.RoleComboBox.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PasswordLabel.Location = new System.Drawing.Point(22, 207);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(73, 17);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UsernameLabel.Location = new System.Drawing.Point(22, 150);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(77, 17);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NameLabel.Location = new System.Drawing.Point(33, 94);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 17);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RoleLabel.Location = new System.Drawing.Point(41, 33);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(41, 17);
            this.RoleLabel.TabIndex = 0;
            this.RoleLabel.Text = "Role:";
            // 
            // UpdateAccountButton
            // 
            this.UpdateAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UpdateAccountButton.Location = new System.Drawing.Point(38, 381);
            this.UpdateAccountButton.Name = "UpdateAccountButton";
            this.UpdateAccountButton.Size = new System.Drawing.Size(139, 40);
            this.UpdateAccountButton.TabIndex = 3;
            this.UpdateAccountButton.Text = "Update Account";
            this.UpdateAccountButton.UseVisualStyleBackColor = true;
            this.UpdateAccountButton.Click += new System.EventHandler(this.UpdateAccountButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CloseButton.Location = new System.Drawing.Point(215, 381);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(134, 40);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AdminModifyUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 446);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.UpdateAccountButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UserAccountsComboBox);
            this.Controls.Add(this.UserAccountsLabel);
            this.Name = "AdminModifyUserAccount";
            this.Text = "Admin - Modify User Account";
            this.Load += new System.EventHandler(this.AdminModifyUserAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserAccountsLabel;
        private System.Windows.Forms.ComboBox UserAccountsComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.ComboBox RoleComboBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Button UpdateAccountButton;
        private System.Windows.Forms.Button CloseButton;
    }
}