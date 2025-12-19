namespace CS314App_mseibers
{
    partial class LoginForm
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.LoginUsernameLabel = new System.Windows.Forms.Label();
            this.LoginPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoginButton.Location = new System.Drawing.Point(117, 194);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(84, 33);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.QuitButton.Location = new System.Drawing.Point(117, 263);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(84, 33);
            this.QuitButton.TabIndex = 1;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // UsernameText
            // 
            this.UsernameText.Location = new System.Drawing.Point(130, 56);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(150, 20);
            this.UsernameText.TabIndex = 2;
            this.UsernameText.TextChanged += new System.EventHandler(this.UsernameText_TextChanged);
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(130, 114);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(150, 20);
            this.PasswordText.TabIndex = 3;
            this.PasswordText.UseSystemPasswordChar = true;
            this.PasswordText.TextChanged += new System.EventHandler(this.PasswordText_TextChanged);
            // 
            // LoginUsernameLabel
            // 
            this.LoginUsernameLabel.AutoSize = true;
            this.LoginUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoginUsernameLabel.Location = new System.Drawing.Point(37, 54);
            this.LoginUsernameLabel.Name = "LoginUsernameLabel";
            this.LoginUsernameLabel.Size = new System.Drawing.Size(87, 20);
            this.LoginUsernameLabel.TabIndex = 4;
            this.LoginUsernameLabel.Text = "Username:";
            this.LoginUsernameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginPasswordLabel
            // 
            this.LoginPasswordLabel.AutoSize = true;
            this.LoginPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoginPasswordLabel.Location = new System.Drawing.Point(42, 112);
            this.LoginPasswordLabel.Name = "LoginPasswordLabel";
            this.LoginPasswordLabel.Size = new System.Drawing.Size(82, 20);
            this.LoginPasswordLabel.TabIndex = 5;
            this.LoginPasswordLabel.Text = "Password:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 336);
            this.Controls.Add(this.LoginPasswordLabel);
            this.Controls.Add(this.LoginUsernameLabel);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.LoginButton);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label LoginUsernameLabel;
        private System.Windows.Forms.Label LoginPasswordLabel;
    }
}

