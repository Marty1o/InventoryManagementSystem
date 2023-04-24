namespace IMS
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            panel1 = new Panel();
            logoutBT = new Button();
            label3 = new Label();
            label2 = new Label();
            productBox = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            consumerBox = new PictureBox();
            label5 = new Label();
            CatergoryBox = new PictureBox();
            label6 = new Label();
            usersBox = new PictureBox();
            label7 = new Label();
            ordersBox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)consumerBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CatergoryBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usersBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ordersBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(logoutBT);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(902, 100);
            panel1.TabIndex = 0;
            // 
            // logoutBT
            // 
            logoutBT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            logoutBT.Location = new Point(12, 47);
            logoutBT.Name = "logoutBT";
            logoutBT.Size = new Size(156, 38);
            logoutBT.TabIndex = 11;
            logoutBT.Text = "LOGOUT";
            logoutBT.UseVisualStyleBackColor = true;
            logoutBT.Click += logoutBT_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(859, 9);
            label3.Name = "label3";
            label3.Size = new Size(31, 33);
            label3.TabIndex = 3;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(202, 31);
            label2.Name = "label2";
            label2.Size = new Size(499, 38);
            label2.TabIndex = 2;
            label2.Text = "Inventory Management System";
            // 
            // productBox
            // 
            productBox.Image = Properties.Resources.prodIcon;
            productBox.Location = new Point(54, 238);
            productBox.Name = "productBox";
            productBox.Size = new Size(100, 94);
            productBox.SizeMode = PictureBoxSizeMode.StretchImage;
            productBox.TabIndex = 1;
            productBox.TabStop = false;
            productBox.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 202);
            label1.Name = "label1";
            label1.Size = new Size(129, 33);
            label1.TabIndex = 2;
            label1.Text = "Products";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(170, 352);
            label4.Name = "label4";
            label4.Size = new Size(159, 33);
            label4.TabIndex = 4;
            label4.Text = "Consumers";
            // 
            // consumerBox
            // 
            consumerBox.Image = (Image)resources.GetObject("consumerBox.Image");
            consumerBox.Location = new Point(193, 388);
            consumerBox.Name = "consumerBox";
            consumerBox.Size = new Size(100, 94);
            consumerBox.SizeMode = PictureBoxSizeMode.StretchImage;
            consumerBox.TabIndex = 3;
            consumerBox.TabStop = false;
            consumerBox.Click += consumerBox_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(328, 202);
            label5.Name = "label5";
            label5.Size = new Size(161, 33);
            label5.TabIndex = 6;
            label5.Text = "Categories";
            // 
            // CatergoryBox
            // 
            CatergoryBox.Image = (Image)resources.GetObject("CatergoryBox.Image");
            CatergoryBox.Location = new Point(356, 238);
            CatergoryBox.Name = "CatergoryBox";
            CatergoryBox.Size = new Size(100, 94);
            CatergoryBox.SizeMode = PictureBoxSizeMode.StretchImage;
            CatergoryBox.TabIndex = 5;
            CatergoryBox.TabStop = false;
            CatergoryBox.Click += CatergoryBox_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(527, 352);
            label6.Name = "label6";
            label6.Size = new Size(78, 33);
            label6.TabIndex = 8;
            label6.Text = "Users";
            // 
            // usersBox
            // 
            usersBox.Image = (Image)resources.GetObject("usersBox.Image");
            usersBox.Location = new Point(515, 388);
            usersBox.Name = "usersBox";
            usersBox.Size = new Size(100, 94);
            usersBox.SizeMode = PictureBoxSizeMode.StretchImage;
            usersBox.TabIndex = 7;
            usersBox.TabStop = false;
            usersBox.Click += usersBox_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(694, 202);
            label7.Name = "label7";
            label7.Size = new Size(101, 33);
            label7.TabIndex = 10;
            label7.Text = "Orders";
            label7.Click += label7_Click;
            // 
            // ordersBox
            // 
            ordersBox.Image = (Image)resources.GetObject("ordersBox.Image");
            ordersBox.Location = new Point(694, 238);
            ordersBox.Name = "ordersBox";
            ordersBox.Size = new Size(100, 94);
            ordersBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ordersBox.TabIndex = 9;
            ordersBox.TabStop = false;
            ordersBox.Click += ordersBox_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(902, 636);
            Controls.Add(label7);
            Controls.Add(ordersBox);
            Controls.Add(label6);
            Controls.Add(usersBox);
            Controls.Add(label5);
            Controls.Add(CatergoryBox);
            Controls.Add(label4);
            Controls.Add(consumerBox);
            Controls.Add(label1);
            Controls.Add(productBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeForm";
            Load += HomeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)consumerBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CatergoryBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)usersBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ordersBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label3;
        private PictureBox productBox;
        private Label label1;
        private Label label4;
        private PictureBox consumerBox;
        private Label label5;
        private PictureBox CatergoryBox;
        private Label label6;
        private PictureBox usersBox;
        private Label label7;
        private PictureBox ordersBox;
        private Button logoutBT;
    }
}