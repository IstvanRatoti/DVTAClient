namespace DVTA
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.Label();
            this.txtRegPass = new System.Windows.Forms.TextBox();
            this.txtCfmPassword = new System.Windows.Forms.Label();
            this.txtRegCfmPass = new System.Windows.Forms.TextBox();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.Location = new System.Drawing.Point(182, 77);
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(142, 20);
            this.txtRegUsername.TabIndex = 1;
            this.txtRegUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Location = new System.Drawing.Point(69, 84);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(55, 13);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Location = new System.Drawing.Point(69, 117);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(53, 13);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Password";
            this.txtPassword.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtRegPass
            // 
            this.txtRegPass.Location = new System.Drawing.Point(182, 114);
            this.txtRegPass.Name = "txtRegPass";
            this.txtRegPass.Size = new System.Drawing.Size(142, 20);
            this.txtRegPass.TabIndex = 4;
            this.txtRegPass.UseSystemPasswordChar = true;
            this.txtRegPass.TextChanged += new System.EventHandler(this.txtRegPass_TextChanged);
            // 
            // txtCfmPassword
            // 
            this.txtCfmPassword.AutoSize = true;
            this.txtCfmPassword.Location = new System.Drawing.Point(69, 157);
            this.txtCfmPassword.Name = "txtCfmPassword";
            this.txtCfmPassword.Size = new System.Drawing.Size(91, 13);
            this.txtCfmPassword.TabIndex = 5;
            this.txtCfmPassword.Text = "Confirm Password";
            // 
            // txtRegCfmPass
            // 
            this.txtRegCfmPass.Location = new System.Drawing.Point(182, 157);
            this.txtRegCfmPass.Name = "txtRegCfmPass";
            this.txtRegCfmPass.Size = new System.Drawing.Size(142, 20);
            this.txtRegCfmPass.TabIndex = 6;
            this.txtRegCfmPass.UseSystemPasswordChar = true;
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.Location = new System.Drawing.Point(182, 195);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(142, 20);
            this.txtRegEmail.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(69, 195);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(46, 13);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Text = "Email ID";
            this.txtEmail.Click += new System.EventHandler(this.label5_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRegEmail);
            this.Controls.Add(this.txtRegCfmPass);
            this.Controls.Add(this.txtCfmPassword);
            this.Controls.Add(this.txtRegPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtRegUsername);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.TextBox txtRegPass;
        private System.Windows.Forms.Label txtCfmPassword;
        private System.Windows.Forms.TextBox txtRegCfmPass;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtEmail;
    }
}