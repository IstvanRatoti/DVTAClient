namespace DVTA
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.welcome = new System.Windows.Forms.Label();
            this.userLoggedIn = new System.Windows.Forms.Label();
            this.btnMainLogout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTestDBConn = new System.Windows.Forms.Button();
            this.AdminToolsLabel = new System.Windows.Forms.Label();
            this.btnBackupFiles = new System.Windows.Forms.Button();
            this.btnCheckLogs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.SystemColors.Control;
            this.welcome.Location = new System.Drawing.Point(49, 34);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(58, 13);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome..";
            this.welcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // userLoggedIn
            // 
            this.userLoggedIn.AutoSize = true;
            this.userLoggedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLoggedIn.Location = new System.Drawing.Point(113, 32);
            this.userLoggedIn.Name = "userLoggedIn";
            this.userLoggedIn.Size = new System.Drawing.Size(0, 16);
            this.userLoggedIn.TabIndex = 1;
            this.userLoggedIn.Click += new System.EventHandler(this.userLoggedIn_Click);
            // 
            // btnMainLogout
            // 
            this.btnMainLogout.Location = new System.Drawing.Point(650, 25);
            this.btnMainLogout.Name = "btnMainLogout";
            this.btnMainLogout.Size = new System.Drawing.Size(75, 23);
            this.btnMainLogout.TabIndex = 2;
            this.btnMainLogout.Text = "Logout";
            this.btnMainLogout.UseVisualStyleBackColor = true;
            this.btnMainLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(86, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(386, 188);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(524, 78);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(186, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add  Expenses";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(524, 107);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(186, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "View Expenses";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(524, 138);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(186, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Clear Expenses";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTestDBConn
            // 
            this.btnTestDBConn.Enabled = false;
            this.btnTestDBConn.Location = new System.Drawing.Point(524, 218);
            this.btnTestDBConn.Name = "btnTestDBConn";
            this.btnTestDBConn.Size = new System.Drawing.Size(186, 23);
            this.btnTestDBConn.TabIndex = 9;
            this.btnTestDBConn.Text = "Test DB Connection";
            this.btnTestDBConn.UseVisualStyleBackColor = true;
            this.btnTestDBConn.Visible = false;
            this.btnTestDBConn.Click += new System.EventHandler(this.btnTestDBConn_Click);
            // 
            // AdminToolsLabel
            // 
            this.AdminToolsLabel.AutoSize = true;
            this.AdminToolsLabel.Enabled = false;
            this.AdminToolsLabel.Location = new System.Drawing.Point(573, 184);
            this.AdminToolsLabel.Name = "AdminToolsLabel";
            this.AdminToolsLabel.Size = new System.Drawing.Size(96, 13);
            this.AdminToolsLabel.TabIndex = 10;
            this.AdminToolsLabel.Text = "Administrator Tools";
            this.AdminToolsLabel.Visible = false;
            this.AdminToolsLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnBackupFiles
            // 
            this.btnBackupFiles.Enabled = false;
            this.btnBackupFiles.Location = new System.Drawing.Point(524, 247);
            this.btnBackupFiles.Name = "btnBackupFiles";
            this.btnBackupFiles.Size = new System.Drawing.Size(186, 23);
            this.btnBackupFiles.TabIndex = 11;
            this.btnBackupFiles.Text = "Backup Files";
            this.btnBackupFiles.UseVisualStyleBackColor = true;
            this.btnBackupFiles.Visible = false;
            this.btnBackupFiles.Click += new System.EventHandler(this.btnBackupFiles_Click);
            // 
            // btnCheckLogs
            // 
            this.btnCheckLogs.Enabled = false;
            this.btnCheckLogs.Location = new System.Drawing.Point(524, 276);
            this.btnCheckLogs.Name = "btnCheckLogs";
            this.btnCheckLogs.Size = new System.Drawing.Size(186, 23);
            this.btnCheckLogs.TabIndex = 12;
            this.btnCheckLogs.Text = "Check Logs";
            this.btnCheckLogs.UseVisualStyleBackColor = true;
            this.btnCheckLogs.Visible = false;
            this.btnCheckLogs.Click += new System.EventHandler(this.btnCheckLogs_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(758, 386);
            this.Controls.Add(this.btnCheckLogs);
            this.Controls.Add(this.btnBackupFiles);
            this.Controls.Add(this.AdminToolsLabel);
            this.Controls.Add(this.btnTestDBConn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMainLogout);
            this.Controls.Add(this.userLoggedIn);
            this.Controls.Add(this.welcome);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label userLoggedIn;
        private System.Windows.Forms.Button btnMainLogout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnTestDBConn;
        private System.Windows.Forms.Label AdminToolsLabel;
        private System.Windows.Forms.Button btnBackupFiles;
        private System.Windows.Forms.Button btnCheckLogs;
    }
}

