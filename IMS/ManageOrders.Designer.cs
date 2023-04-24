namespace IMS
{
    partial class ManageOrders
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            CustomersGV = new DataGridView();
            orderIdTB = new TextBox();
            customerIdTB = new TextBox();
            orderDate = new DateTimePicker();
            label5 = new Label();
            searchCB = new ComboBox();
            ProductGV = new DataGridView();
            label6 = new Label();
            quantityTB = new TextBox();
            addItemQuanBT = new Button();
            OrderGV = new DataGridView();
            customernameTB = new TextBox();
            label7 = new Label();
            totalAmountLB = new Label();
            insertOrderBT = new Button();
            viewOrderBT = new Button();
            label8 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderGV).BeginInit();
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
            panel1.Size = new Size(1030, 107);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(999, 0);
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
            label1.Location = new Point(288, 59);
            label1.Name = "label1";
            label1.Size = new Size(221, 33);
            label1.TabIndex = 0;
            label1.Text = "Manage Orders";
            // 
            // panel2
            // 
            panel2.BackColor = Color.OliveDrab;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 645);
            panel2.Name = "panel2";
            panel2.Size = new Size(1030, 25);
            panel2.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(12, 119);
            label4.Name = "label4";
            label4.Size = new Size(152, 24);
            label4.TabIndex = 3;
            label4.Text = "Customers List";
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
            CustomersGV.BackgroundColor = Color.Silver;
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
            CustomersGV.Location = new Point(12, 146);
            CustomersGV.Name = "CustomersGV";
            CustomersGV.RowTemplate.Height = 25;
            CustomersGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomersGV.Size = new Size(430, 233);
            CustomersGV.TabIndex = 14;
            CustomersGV.CellContentClick += CustomersGV_CellContentClick;
            // 
            // orderIdTB
            // 
            orderIdTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            orderIdTB.ForeColor = Color.Crimson;
            orderIdTB.Location = new Point(12, 420);
            orderIdTB.Name = "orderIdTB";
            orderIdTB.Size = new Size(217, 29);
            orderIdTB.TabIndex = 18;
            orderIdTB.TextChanged += orderIdTB_TextChanged;
            // 
            // customerIdTB
            // 
            customerIdTB.Enabled = false;
            customerIdTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerIdTB.ForeColor = Color.Crimson;
            customerIdTB.Location = new Point(12, 455);
            customerIdTB.Name = "customerIdTB";
            customerIdTB.Size = new Size(217, 29);
            customerIdTB.TabIndex = 19;
            // 
            // orderDate
            // 
            orderDate.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            orderDate.Location = new Point(12, 545);
            orderDate.Name = "orderDate";
            orderDate.Size = new Size(217, 23);
            orderDate.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(12, 522);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 21;
            label5.Text = "Order Date";
            label5.Click += label5_Click;
            // 
            // searchCB
            // 
            searchCB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchCB.ForeColor = SystemColors.ActiveCaptionText;
            searchCB.FormattingEnabled = true;
            searchCB.Location = new Point(448, 111);
            searchCB.Name = "searchCB";
            searchCB.Size = new Size(217, 29);
            searchCB.TabIndex = 29;
            searchCB.Text = "Select Category";
            searchCB.SelectionChangeCommitted += searchCB_SelectionChangeCommitted;
            // 
            // ProductGV
            // 
            ProductGV.AllowUserToAddRows = false;
            ProductGV.AllowUserToDeleteRows = false;
            ProductGV.AllowUserToResizeColumns = false;
            ProductGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ProductGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            ProductGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.BackColor = Color.Crimson;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            ProductGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            ProductGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductGV.Location = new Point(448, 146);
            ProductGV.Name = "ProductGV";
            ProductGV.RowTemplate.Height = 25;
            ProductGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductGV.Size = new Size(570, 233);
            ProductGV.TabIndex = 28;
            ProductGV.CellContentClick += ProductGV_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(262, 391);
            label6.Name = "label6";
            label6.Size = new Size(80, 21);
            label6.TabIndex = 30;
            label6.Text = "Quantity";
            // 
            // quantityTB
            // 
            quantityTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            quantityTB.ForeColor = Color.Crimson;
            quantityTB.Location = new Point(348, 388);
            quantityTB.Name = "quantityTB";
            quantityTB.Size = new Size(217, 29);
            quantityTB.TabIndex = 31;
            // 
            // addItemQuanBT
            // 
            addItemQuanBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            addItemQuanBT.Location = new Point(571, 388);
            addItemQuanBT.Name = "addItemQuanBT";
            addItemQuanBT.Size = new Size(109, 30);
            addItemQuanBT.TabIndex = 32;
            addItemQuanBT.Text = "Add to Order";
            addItemQuanBT.UseVisualStyleBackColor = true;
            addItemQuanBT.Click += addCustomerBT_Click;
            // 
            // OrderGV
            // 
            OrderGV.AllowUserToAddRows = false;
            OrderGV.AllowUserToDeleteRows = false;
            OrderGV.AllowUserToResizeColumns = false;
            OrderGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            OrderGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            OrderGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrderGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle6.BackColor = Color.Crimson;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            OrderGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            OrderGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGV.Location = new Point(261, 420);
            OrderGV.Name = "OrderGV";
            OrderGV.RowTemplate.Height = 25;
            OrderGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrderGV.Size = new Size(757, 219);
            OrderGV.TabIndex = 33;
            // 
            // customernameTB
            // 
            customernameTB.Enabled = false;
            customernameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customernameTB.ForeColor = Color.Crimson;
            customernameTB.Location = new Point(12, 490);
            customernameTB.Name = "customernameTB";
            customernameTB.Size = new Size(217, 29);
            customernameTB.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(770, 392);
            label7.Name = "label7";
            label7.Size = new Size(122, 21);
            label7.TabIndex = 35;
            label7.Text = "Total Amount:";
            // 
            // totalAmountLB
            // 
            totalAmountLB.AutoSize = true;
            totalAmountLB.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalAmountLB.ForeColor = Color.Crimson;
            totalAmountLB.Location = new Point(898, 392);
            totalAmountLB.Name = "totalAmountLB";
            totalAmountLB.Size = new Size(36, 19);
            totalAmountLB.TabIndex = 36;
            totalAmountLB.Text = "$$$";
            // 
            // insertOrderBT
            // 
            insertOrderBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            insertOrderBT.Location = new Point(12, 574);
            insertOrderBT.Name = "insertOrderBT";
            insertOrderBT.Size = new Size(109, 30);
            insertOrderBT.TabIndex = 37;
            insertOrderBT.Text = "Insert Order";
            insertOrderBT.UseVisualStyleBackColor = true;
            insertOrderBT.Click += insertOrderBT_Click;
            // 
            // viewOrderBT
            // 
            viewOrderBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            viewOrderBT.Location = new Point(127, 574);
            viewOrderBT.Name = "viewOrderBT";
            viewOrderBT.Size = new Size(102, 30);
            viewOrderBT.TabIndex = 38;
            viewOrderBT.Text = "View Orders";
            viewOrderBT.UseVisualStyleBackColor = true;
            viewOrderBT.Click += viewOrderBT_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(12, 398);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 39;
            label8.Text = "Order ID";
            label8.Click += label8_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(68, 610);
            button1.Name = "button1";
            button1.Size = new Size(109, 30);
            button1.TabIndex = 40;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ManageOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 670);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(viewOrderBT);
            Controls.Add(insertOrderBT);
            Controls.Add(totalAmountLB);
            Controls.Add(label7);
            Controls.Add(customernameTB);
            Controls.Add(OrderGV);
            Controls.Add(addItemQuanBT);
            Controls.Add(quantityTB);
            Controls.Add(label6);
            Controls.Add(searchCB);
            Controls.Add(ProductGV);
            Controls.Add(label5);
            Controls.Add(orderDate);
            Controls.Add(customerIdTB);
            Controls.Add(orderIdTB);
            Controls.Add(CustomersGV);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageOrders";
            Load += ManageOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private DataGridView CustomersGV;
        private TextBox orderIdTB;
        private TextBox customerIdTB;
        private DateTimePicker orderDate;
        private Label label5;
        private ComboBox searchCB;
        private DataGridView ProductGV;
        private Label label6;
        private TextBox quantityTB;
        private Button addItemQuanBT;
        private DataGridView OrderGV;
        private TextBox customernameTB;
        private Label label7;
        private Label totalAmountLB;
        private Button insertOrderBT;
        private Button viewOrderBT;
        private Label label8;
        private Button button1;
    }
}