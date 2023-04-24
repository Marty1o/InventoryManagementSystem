namespace IMS
{
    partial class ManageCustomers
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CemailTB = new TextBox();
            CfullNameTB = new TextBox();
            CphoneTB = new TextBox();
            customerIdTB = new TextBox();
            CustomersGV = new DataGridView();
            panel2 = new Panel();
            CusHomeBT = new Button();
            deleteCustomerBT = new Button();
            editCustomerBT = new Button();
            addCustomerBT = new Button();
            panel3 = new Panel();
            OrderLabel = new Label();
            label4 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            AmountLabel = new Label();
            panel5 = new Panel();
            DateLabel = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
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
            panel1.TabIndex = 1;
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
            label1.Location = new Point(246, 58);
            label1.Name = "label1";
            label1.Size = new Size(273, 33);
            label1.TabIndex = 0;
            label1.Text = "Manage Customers";
            label1.Click += label1_Click;
            // 
            // CemailTB
            // 
            CemailTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CemailTB.ForeColor = SystemColors.ActiveCaptionText;
            CemailTB.Location = new Point(12, 168);
            CemailTB.Name = "CemailTB";
            CemailTB.Size = new Size(204, 29);
            CemailTB.TabIndex = 9;
            CemailTB.Text = "email";
            // 
            // CfullNameTB
            // 
            CfullNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CfullNameTB.ForeColor = SystemColors.ActiveCaptionText;
            CfullNameTB.Location = new Point(12, 203);
            CfullNameTB.Name = "CfullNameTB";
            CfullNameTB.Size = new Size(204, 29);
            CfullNameTB.TabIndex = 8;
            CfullNameTB.Text = "full name";
            // 
            // CphoneTB
            // 
            CphoneTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CphoneTB.ForeColor = SystemColors.ActiveCaptionText;
            CphoneTB.Location = new Point(12, 238);
            CphoneTB.Name = "CphoneTB";
            CphoneTB.Size = new Size(204, 29);
            CphoneTB.TabIndex = 7;
            CphoneTB.Text = "phone";
            // 
            // customerIdTB
            // 
            customerIdTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerIdTB.ForeColor = SystemColors.ActiveCaptionText;
            customerIdTB.Location = new Point(12, 133);
            customerIdTB.Name = "customerIdTB";
            customerIdTB.Size = new Size(204, 29);
            customerIdTB.TabIndex = 6;
            customerIdTB.Text = "CustomerID";
            // 
            // CustomersGV
            // 
            CustomersGV.AllowUserToAddRows = false;
            CustomersGV.AllowUserToDeleteRows = false;
            CustomersGV.AllowUserToResizeColumns = false;
            CustomersGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CustomersGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            CustomersGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomersGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            CustomersGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Crimson;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CustomersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CustomersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersGV.Location = new Point(221, 130);
            CustomersGV.Name = "CustomersGV";
            CustomersGV.RowTemplate.Height = 25;
            CustomersGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomersGV.Size = new Size(547, 454);
            CustomersGV.TabIndex = 11;
            CustomersGV.CellContentClick += CustomersGV_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.OliveDrab;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 590);
            panel2.Name = "panel2";
            panel2.Size = new Size(780, 25);
            panel2.TabIndex = 12;
            // 
            // CusHomeBT
            // 
            CusHomeBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CusHomeBT.Location = new Point(12, 309);
            CusHomeBT.Name = "CusHomeBT";
            CusHomeBT.Size = new Size(204, 30);
            CusHomeBT.TabIndex = 16;
            CusHomeBT.Text = "HOME";
            CusHomeBT.UseVisualStyleBackColor = true;
            CusHomeBT.Click += CusHomeBT_Click;
            // 
            // deleteCustomerBT
            // 
            deleteCustomerBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteCustomerBT.Location = new Point(140, 273);
            deleteCustomerBT.Name = "deleteCustomerBT";
            deleteCustomerBT.Size = new Size(76, 30);
            deleteCustomerBT.TabIndex = 15;
            deleteCustomerBT.Text = "DELETE";
            deleteCustomerBT.UseVisualStyleBackColor = true;
            deleteCustomerBT.Click += deleteCustomerBT_Click;
            // 
            // editCustomerBT
            // 
            editCustomerBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            editCustomerBT.Location = new Point(70, 273);
            editCustomerBT.Name = "editCustomerBT";
            editCustomerBT.Size = new Size(64, 30);
            editCustomerBT.TabIndex = 14;
            editCustomerBT.Text = "EDIT";
            editCustomerBT.UseVisualStyleBackColor = true;
            editCustomerBT.Click += editCustomerBT_Click;
            // 
            // addCustomerBT
            // 
            addCustomerBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            addCustomerBT.Location = new Point(12, 273);
            addCustomerBT.Name = "addCustomerBT";
            addCustomerBT.Size = new Size(52, 30);
            addCustomerBT.TabIndex = 13;
            addCustomerBT.Text = "ADD";
            addCustomerBT.UseVisualStyleBackColor = true;
            addCustomerBT.Click += addCustomerBT_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(OrderLabel);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(12, 345);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 70);
            panel3.TabIndex = 17;
            // 
            // OrderLabel
            // 
            OrderLabel.AutoSize = true;
            OrderLabel.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            OrderLabel.ForeColor = Color.White;
            OrderLabel.Location = new Point(37, 28);
            OrderLabel.Name = "OrderLabel";
            OrderLabel.Size = new Size(118, 32);
            OrderLabel.TabIndex = 3;
            OrderLabel.Text = "Counter";
            OrderLabel.Click += label6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(58, 10);
            label4.Name = "label4";
            label4.Size = new Size(88, 18);
            label4.TabIndex = 3;
            label4.Text = "# of Orders";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(47, 10);
            label5.Name = "label5";
            label5.Size = new Size(112, 18);
            label5.TabIndex = 3;
            label5.Text = "Order Amount";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(AmountLabel);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(12, 421);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 71);
            panel4.TabIndex = 18;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            AmountLabel.ForeColor = Color.White;
            AmountLabel.Location = new Point(37, 28);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(118, 32);
            AmountLabel.TabIndex = 4;
            AmountLabel.Text = "Counter";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(DateLabel);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(12, 498);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 71);
            panel5.TabIndex = 19;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            DateLabel.ForeColor = Color.White;
            DateLabel.Location = new Point(58, 28);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(76, 32);
            DateLabel.TabIndex = 4;
            DateLabel.Text = "Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(47, 10);
            label7.Name = "label7";
            label7.Size = new Size(96, 18);
            label7.TabIndex = 3;
            label7.Text = "Latest Order";
            // 
            // ManageCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 615);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(CusHomeBT);
            Controls.Add(deleteCustomerBT);
            Controls.Add(editCustomerBT);
            Controls.Add(addCustomerBT);
            Controls.Add(panel2);
            Controls.Add(CustomersGV);
            Controls.Add(CemailTB);
            Controls.Add(CfullNameTB);
            Controls.Add(CphoneTB);
            Controls.Add(customerIdTB);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCustomers";
            Load += ManageCustomers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox CemailTB;
        private TextBox CfullNameTB;
        private TextBox CphoneTB;
        private TextBox customerIdTB;
        private Panel panel2;
        private Button CusHomeBT;
        private Button deleteCustomerBT;
        private Button editCustomerBT;
        private Button addCustomerBT;
        private DataGridView CustomersGV;
        private Panel panel3;
        private Label label4;
        private Label OrderLabel;
        private Label label5;
        private Panel panel4;
        private Label AmountLabel;
        private Panel panel5;
        private Label DateLabel;
        private Label label7;
    }
}