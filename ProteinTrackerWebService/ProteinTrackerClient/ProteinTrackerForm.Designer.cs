namespace ProteinTrackerClient
{
    partial class ProteinTrackerForm
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
            this.lblSelectUser = new System.Windows.Forms.Label();
            this.cboSelectUser = new System.Windows.Forms.ComboBox();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAddProtein = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalVal = new System.Windows.Forms.Label();
            this.lblGoal1 = new System.Windows.Forms.Label();
            this.lblGoalVal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectUser
            // 
            this.lblSelectUser.AutoSize = true;
            this.lblSelectUser.Location = new System.Drawing.Point(64, 60);
            this.lblSelectUser.Name = "lblSelectUser";
            this.lblSelectUser.Size = new System.Drawing.Size(105, 20);
            this.lblSelectUser.TabIndex = 0;
            this.lblSelectUser.Text = "Select a User";
            // 
            // cboSelectUser
            // 
            this.cboSelectUser.FormattingEnabled = true;
            this.cboSelectUser.Location = new System.Drawing.Point(68, 98);
            this.cboSelectUser.Name = "cboSelectUser";
            this.cboSelectUser.Size = new System.Drawing.Size(121, 28);
            this.cboSelectUser.TabIndex = 1;
            this.cboSelectUser.SelectedIndexChanged += new System.EventHandler(this.OnUserChanged);
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Location = new System.Drawing.Point(64, 159);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(76, 20);
            this.lblAddUser.TabIndex = 2;
            this.lblAddUser.Text = "Add User";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(44, 189);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Location = new System.Drawing.Point(44, 223);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(43, 20);
            this.lblGoal.TabIndex = 4;
            this.lblGoal.Text = "Goal";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 189);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 26);
            this.txtName.TabIndex = 5;
            // 
            // txtGoal
            // 
            this.txtGoal.Location = new System.Drawing.Point(128, 223);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(196, 26);
            this.txtGoal.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(48, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.OnAddNewUser);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGoalVal);
            this.groupBox1.Controls.Add(this.lblGoal1);
            this.groupBox1.Controls.Add(this.lblTotalVal);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.btnAddProtein);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Location = new System.Drawing.Point(512, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 244);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add protein";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(33, 38);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 20);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(141, 40);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 26);
            this.txtAmount.TabIndex = 1;
            // 
            // btnAddProtein
            // 
            this.btnAddProtein.Location = new System.Drawing.Point(23, 84);
            this.btnAddProtein.Name = "btnAddProtein";
            this.btnAddProtein.Size = new System.Drawing.Size(75, 35);
            this.btnAddProtein.TabIndex = 2;
            this.btnAddProtein.Text = "Add";
            this.btnAddProtein.UseVisualStyleBackColor = true;
            this.btnAddProtein.Click += new System.EventHandler(this.OnAddProtein);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(19, 135);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total";
            // 
            // lblTotalVal
            // 
            this.lblTotalVal.AutoSize = true;
            this.lblTotalVal.Location = new System.Drawing.Point(137, 135);
            this.lblTotalVal.Name = "lblTotalVal";
            this.lblTotalVal.Size = new System.Drawing.Size(18, 20);
            this.lblTotalVal.TabIndex = 4;
            this.lblTotalVal.Text = "0";
            // 
            // lblGoal1
            // 
            this.lblGoal1.AutoSize = true;
            this.lblGoal1.Location = new System.Drawing.Point(19, 169);
            this.lblGoal1.Name = "lblGoal1";
            this.lblGoal1.Size = new System.Drawing.Size(43, 20);
            this.lblGoal1.TabIndex = 5;
            this.lblGoal1.Text = "Goal";
            // 
            // lblGoalVal
            // 
            this.lblGoalVal.AutoSize = true;
            this.lblGoalVal.Location = new System.Drawing.Point(137, 169);
            this.lblGoalVal.Name = "lblGoalVal";
            this.lblGoalVal.Size = new System.Drawing.Size(18, 20);
            this.lblGoalVal.TabIndex = 6;
            this.lblGoalVal.Text = "0";
            // 
            // ProteinTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 398);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtGoal);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAddUser);
            this.Controls.Add(this.cboSelectUser);
            this.Controls.Add(this.lblSelectUser);
            this.Name = "ProteinTrackerForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectUser;
        private System.Windows.Forms.ComboBox cboSelectUser;
        private System.Windows.Forms.Label lblAddUser;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGoalVal;
        private System.Windows.Forms.Label lblGoal1;
        private System.Windows.Forms.Label lblTotalVal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAddProtein;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
    }
}

