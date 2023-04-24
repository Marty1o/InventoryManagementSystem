namespace IMS
{
    partial class ManageUsers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            usernameTB = new TextBox();
            phoneTB = new TextBox();
            passwordTB = new TextBox();
            fullNameTB = new TextBox();
            emailTB = new TextBox();
            addUserBT = new Button();
            editUserBT = new Button();
            deleteUserBT = new Button();
            homeBT = new Button();
            UsersGV = new DataGridView();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OliveDrab;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 107);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(749, 0);
            label3.Name = "label3";
            label3.Size = new Size(31, 33);
            label3.TabIndex = 2;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(174, 9);
            label2.Name = "label2";
            label2.Size = new Size(499, 38);
            label2.TabIndex = 1;
            label2.Text = "Inventory Management System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(335, 56);
            label1.Name = "label1";
            label1.Size = new Size(198, 33);
            label1.TabIndex = 0;
            label1.Text = "Manage Users";
            // 
            // usernameTB
            // 
            usernameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTB.ForeColor = SystemColors.ActiveCaptionText;
            usernameTB.Location = new Point(12, 130);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(204, 29);
            usernameTB.TabIndex = 1;
            usernameTB.Text = "username";
            // 
            // phoneTB
            // 
            phoneTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneTB.ForeColor = SystemColors.ActiveCaptionText;
            phoneTB.Location = new Point(12, 270);
            phoneTB.Name = "phoneTB";
            phoneTB.Size = new Size(204, 29);
            phoneTB.TabIndex = 2;
            phoneTB.Text = "Phone";
            // 
            // passwordTB
            // 
            passwordTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTB.ForeColor = SystemColors.ActiveCaptionText;
            passwordTB.Location = new Point(12, 235);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(204, 29);
            passwordTB.TabIndex = 3;
            passwordTB.Text = "password";
            // 
            // fullNameTB
            // 
            fullNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fullNameTB.ForeColor = SystemColors.ActiveCaptionText;
            fullNameTB.Location = new Point(12, 200);
            fullNameTB.Name = "fullNameTB";
            fullNameTB.Size = new Size(204, 29);
            fullNameTB.TabIndex = 4;
            fullNameTB.Text = "full name";
            // 
            // emailTB
            // 
            emailTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailTB.ForeColor = SystemColors.ActiveCaptionText;
            emailTB.Location = new Point(12, 165);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(204, 29);
            emailTB.TabIndex = 5;
            emailTB.Text = "email";
            // 
            // addUserBT
            // 
            addUserBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            addUserBT.Location = new Point(12, 305);
            addUserBT.Name = "addUserBT";
            addUserBT.Size = new Size(52, 30);
            addUserBT.TabIndex = 6;
            addUserBT.Text = "ADD";
            addUserBT.UseVisualStyleBackColor = true;
            addUserBT.Click += addUserBT_Click;
            // 
            // editUserBT
            // 
            editUserBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            editUserBT.Location = new Point(70, 305);
            editUserBT.Name = "editUserBT";
            editUserBT.Size = new Size(64, 30);
            editUserBT.TabIndex = 7;
            editUserBT.Text = "EDIT";
            editUserBT.UseVisualStyleBackColor = true;
            editUserBT.Click += editUserBT_Click;
            // 
            // deleteUserBT
            // 
            deleteUserBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteUserBT.Location = new Point(140, 305);
            deleteUserBT.Name = "deleteUserBT";
            deleteUserBT.Size = new Size(76, 30);
            deleteUserBT.TabIndex = 8;
            deleteUserBT.Text = "DELETE";
            deleteUserBT.UseVisualStyleBackColor = true;
            deleteUserBT.Click += deleteUserBT_Click;
            // 
            // homeBT
            // 
            homeBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            homeBT.Location = new Point(12, 341);
            homeBT.Name = "homeBT";
            homeBT.Size = new Size(204, 30);
            homeBT.TabIndex = 9;
            homeBT.Text = "HOME";
            homeBT.UseVisualStyleBackColor = true;
            homeBT.Click += homeBT_Click;
            // 
            // UsersGV
            // 
            UsersGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsersGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UsersGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Crimson;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            UsersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            UsersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersGV.Location = new Point(222, 130);
            UsersGV.Name = "UsersGV";
            UsersGV.RowTemplate.Height = 25;
            UsersGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UsersGV.Size = new Size(547, 454);
            UsersGV.TabIndex = 10;
            UsersGV.CellContentClick += UsersGV_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.OliveDrab;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 590);
            panel2.Name = "panel2";
            panel2.Size = new Size(780, 25);
            panel2.TabIndex = 11;
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 615);
            Controls.Add(panel2);
            Controls.Add(UsersGV);
            Controls.Add(homeBT);
            Controls.Add(deleteUserBT);
            Controls.Add(editUserBT);
            Controls.Add(addUserBT);
            Controls.Add(emailTB);
            Controls.Add(fullNameTB);
            Controls.Add(passwordTB);
            Controls.Add(phoneTB);
            Controls.Add(usernameTB);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageUsers";
            Load += ManageUsers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox usernameTB;
        private TextBox phoneTB;
        private TextBox passwordTB;
        private TextBox fullNameTB;
        private TextBox emailTB;
        private Button addUserBT;
        private Button editUserBT;
        private Button deleteUserBT;
        private Button homeBT;
        private Label label3;
        private Panel panel2;
        public DataGridView UsersGV;
    }
}