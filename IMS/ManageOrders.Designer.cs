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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            panel1 = new Panel();
            ExitAppLabel = new Label();
            AppNameLabel = new Label();
            FormNameLabel = new Label();
            FooterPanel = new Panel();
            CustomerListLabel = new Label();
            CustomersGV = new DataGridView();
            orderIdTB = new TextBox();
            customerIdTB = new TextBox();
            orderDate = new DateTimePicker();
            OrderDateLabel = new Label();
            searchCB = new ComboBox();
            ProductGV = new DataGridView();
            ItemQuantityLabel = new Label();
            quantityTB = new TextBox();
            addItemQuanBT = new Button();
            OrderGV = new DataGridView();
            customernameTB = new TextBox();
            OrderTotalAmountLabel = new Label();
            totalAmountLB = new Label();
            insertOrderBT = new Button();
            viewOrderBT = new Button();
            OrderIDLabel = new Label();
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
            panel1.Controls.Add(ExitAppLabel);
            panel1.Controls.Add(AppNameLabel);
            panel1.Controls.Add(FormNameLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 107);
            panel1.TabIndex = 2;
            // 
            // ExitAppLabel
            // 
            ExitAppLabel.AutoSize = true;
            ExitAppLabel.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ExitAppLabel.ForeColor = Color.White;
            ExitAppLabel.Location = new Point(999, 0);
            ExitAppLabel.Name = "ExitAppLabel";
            ExitAppLabel.Size = new Size(31, 33);
            ExitAppLabel.TabIndex = 2;
            ExitAppLabel.Text = "X";
            ExitAppLabel.Click += ExitAppLabel_Click;
            // 
            // AppNameLabel
            // 
            AppNameLabel.AutoSize = true;
            AppNameLabel.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            AppNameLabel.ForeColor = Color.White;
            AppNameLabel.Location = new Point(262, 9);
            AppNameLabel.Name = "AppNameLabel";
            AppNameLabel.Size = new Size(499, 38);
            AppNameLabel.TabIndex = 1;
            AppNameLabel.Text = "Inventory Management System";
            // 
            // FormNameLabel
            // 
            FormNameLabel.AutoSize = true;
            FormNameLabel.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormNameLabel.ForeColor = Color.White;
            FormNameLabel.Location = new Point(376, 59);
            FormNameLabel.Name = "FormNameLabel";
            FormNameLabel.Size = new Size(221, 33);
            FormNameLabel.TabIndex = 0;
            FormNameLabel.Text = "Manage Orders";
            // 
            // FooterPanel
            // 
            FooterPanel.BackColor = Color.OliveDrab;
            FooterPanel.Dock = DockStyle.Bottom;
            FooterPanel.Location = new Point(0, 645);
            FooterPanel.Name = "FooterPanel";
            FooterPanel.Size = new Size(1030, 25);
            FooterPanel.TabIndex = 13;
            // 
            // CustomerListLabel
            // 
            CustomerListLabel.AutoSize = true;
            CustomerListLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerListLabel.ForeColor = SystemColors.Highlight;
            CustomerListLabel.Location = new Point(12, 119);
            CustomerListLabel.Name = "CustomerListLabel";
            CustomerListLabel.Size = new Size(152, 24);
            CustomerListLabel.TabIndex = 3;
            CustomerListLabel.Text = "Customers List";
            // 
            // CustomersGV
            // 
            CustomersGV.AllowUserToAddRows = false;
            CustomersGV.AllowUserToDeleteRows = false;
            CustomersGV.AllowUserToResizeColumns = false;
            CustomersGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            CustomersGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            CustomersGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomersGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            CustomersGV.BackgroundColor = Color.Silver;
            CustomersGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.Crimson;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            CustomersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
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
            orderIdTB.PlaceholderText = "Order Id";
            orderIdTB.Size = new Size(217, 29);
            orderIdTB.TabIndex = 18;
            // 
            // customerIdTB
            // 
            customerIdTB.Enabled = false;
            customerIdTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerIdTB.ForeColor = Color.Crimson;
            customerIdTB.Location = new Point(12, 455);
            customerIdTB.Name = "customerIdTB";
            customerIdTB.PlaceholderText = "Customer Id";
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
            // OrderDateLabel
            // 
            OrderDateLabel.AutoSize = true;
            OrderDateLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            OrderDateLabel.ForeColor = SystemColors.Highlight;
            OrderDateLabel.Location = new Point(12, 522);
            OrderDateLabel.Name = "OrderDateLabel";
            OrderDateLabel.Size = new Size(92, 20);
            OrderDateLabel.TabIndex = 21;
            OrderDateLabel.Text = "Order Date";
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
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            ProductGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            ProductGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle10.BackColor = Color.Crimson;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            ProductGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            ProductGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductGV.Location = new Point(448, 146);
            ProductGV.Name = "ProductGV";
            ProductGV.RowTemplate.Height = 25;
            ProductGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductGV.Size = new Size(570, 233);
            ProductGV.TabIndex = 28;
            ProductGV.CellContentClick += ProductGV_CellContentClick;
            // 
            // ItemQuantityLabel
            // 
            ItemQuantityLabel.AutoSize = true;
            ItemQuantityLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ItemQuantityLabel.ForeColor = SystemColors.Highlight;
            ItemQuantityLabel.Location = new Point(262, 391);
            ItemQuantityLabel.Name = "ItemQuantityLabel";
            ItemQuantityLabel.Size = new Size(80, 21);
            ItemQuantityLabel.TabIndex = 30;
            ItemQuantityLabel.Text = "Quantity";
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
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            OrderGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            OrderGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrderGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle12.BackColor = Color.Crimson;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            OrderGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
            customernameTB.PlaceholderText = "Customer Name";
            customernameTB.Size = new Size(217, 29);
            customernameTB.TabIndex = 34;
            // 
            // OrderTotalAmountLabel
            // 
            OrderTotalAmountLabel.AutoSize = true;
            OrderTotalAmountLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OrderTotalAmountLabel.ForeColor = SystemColors.Highlight;
            OrderTotalAmountLabel.Location = new Point(770, 392);
            OrderTotalAmountLabel.Name = "OrderTotalAmountLabel";
            OrderTotalAmountLabel.Size = new Size(122, 21);
            OrderTotalAmountLabel.TabIndex = 35;
            OrderTotalAmountLabel.Text = "Total Amount:";
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
            // OrderIDLabel
            // 
            OrderIDLabel.AutoSize = true;
            OrderIDLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            OrderIDLabel.ForeColor = SystemColors.Highlight;
            OrderIDLabel.Location = new Point(12, 398);
            OrderIDLabel.Name = "OrderIDLabel";
            OrderIDLabel.Size = new Size(72, 20);
            OrderIDLabel.TabIndex = 39;
            OrderIDLabel.Text = "Order ID";
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
            Controls.Add(OrderIDLabel);
            Controls.Add(viewOrderBT);
            Controls.Add(insertOrderBT);
            Controls.Add(totalAmountLB);
            Controls.Add(OrderTotalAmountLabel);
            Controls.Add(customernameTB);
            Controls.Add(OrderGV);
            Controls.Add(addItemQuanBT);
            Controls.Add(quantityTB);
            Controls.Add(ItemQuantityLabel);
            Controls.Add(searchCB);
            Controls.Add(ProductGV);
            Controls.Add(OrderDateLabel);
            Controls.Add(orderDate);
            Controls.Add(customerIdTB);
            Controls.Add(orderIdTB);
            Controls.Add(CustomersGV);
            Controls.Add(CustomerListLabel);
            Controls.Add(FooterPanel);
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
        private Label ExitAppLabel;
        private Label AppNameLabel;
        private Label FormNameLabel;
        private Panel FooterPanel;
        private Label CustomerListLabel;
        private DataGridView CustomersGV;
        private TextBox orderIdTB;
        private TextBox customerIdTB;
        private DateTimePicker orderDate;
        private Label OrderDateLabel;
        private ComboBox searchCB;
        private DataGridView ProductGV;
        private Label ItemQuantityLabel;
        private TextBox quantityTB;
        private Button addItemQuanBT;
        private DataGridView OrderGV;
        private TextBox customernameTB;
        private Label OrderTotalAmountLabel;
        private Label totalAmountLB;
        private Button insertOrderBT;
        private Button viewOrderBT;
        private Label OrderIDLabel;
        private Button button1;
    }
}