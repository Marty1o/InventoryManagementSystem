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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            TitleHeaderPanel = new Panel();
            ExitAppLabel = new Label();
            AppTitleLabel = new Label();
            FormTitleLabel = new Label();
            CemailTB = new TextBox();
            CfullNameTB = new TextBox();
            CphoneTB = new TextBox();
            customerIdTB = new TextBox();
            CustomersGV = new DataGridView();
            FooterPanel = new Panel();
            CusHomeBT = new Button();
            deleteCustomerBT = new Button();
            editCustomerBT = new Button();
            addCustomerBT = new Button();
            OrderNumPanel = new Panel();
            OrderLabel = new Label();
            OrderTitleLabel = new Label();
            OrderAmountTitleLabel = new Label();
            OrderAmountPanel = new Panel();
            AmountLabel = new Label();
            LatestDatePanel = new Panel();
            DateLabel = new Label();
            LatestDateTitleLabel = new Label();
            TitleHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).BeginInit();
            OrderNumPanel.SuspendLayout();
            OrderAmountPanel.SuspendLayout();
            LatestDatePanel.SuspendLayout();
            SuspendLayout();
            // 
            // TitleHeaderPanel
            // 
            TitleHeaderPanel.BackColor = Color.OliveDrab;
            TitleHeaderPanel.Controls.Add(ExitAppLabel);
            TitleHeaderPanel.Controls.Add(AppTitleLabel);
            TitleHeaderPanel.Controls.Add(FormTitleLabel);
            TitleHeaderPanel.Dock = DockStyle.Top;
            TitleHeaderPanel.Location = new Point(0, 0);
            TitleHeaderPanel.Name = "TitleHeaderPanel";
            TitleHeaderPanel.Size = new Size(780, 107);
            TitleHeaderPanel.TabIndex = 1;
            // 
            // ExitAppLabel
            // 
            ExitAppLabel.AutoSize = true;
            ExitAppLabel.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ExitAppLabel.ForeColor = Color.White;
            ExitAppLabel.Location = new Point(749, 0);
            ExitAppLabel.Name = "ExitAppLabel";
            ExitAppLabel.Size = new Size(31, 33);
            ExitAppLabel.TabIndex = 2;
            ExitAppLabel.Text = "X";
            ExitAppLabel.Click += ExitAppLabel_Click;
            // 
            // AppTitleLabel
            // 
            AppTitleLabel.AutoSize = true;
            AppTitleLabel.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            AppTitleLabel.ForeColor = Color.White;
            AppTitleLabel.Location = new Point(174, 9);
            AppTitleLabel.Name = "AppTitleLabel";
            AppTitleLabel.Size = new Size(499, 38);
            AppTitleLabel.TabIndex = 1;
            AppTitleLabel.Text = "Inventory Management System";
            // 
            // FormTitleLabel
            // 
            FormTitleLabel.AutoSize = true;
            FormTitleLabel.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormTitleLabel.ForeColor = Color.White;
            FormTitleLabel.Location = new Point(246, 58);
            FormTitleLabel.Name = "FormTitleLabel";
            FormTitleLabel.Size = new Size(273, 33);
            FormTitleLabel.TabIndex = 0;
            FormTitleLabel.Text = "Manage Customers";
            // 
            // CemailTB
            // 
            CemailTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CemailTB.ForeColor = SystemColors.ActiveCaptionText;
            CemailTB.Location = new Point(12, 168);
            CemailTB.Name = "CemailTB";
            CemailTB.Size = new Size(204, 29);
            CemailTB.TabIndex = 9;
            CemailTB.PlaceholderText = "Email";
            // 
            // CfullNameTB
            // 
            CfullNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CfullNameTB.ForeColor = SystemColors.ActiveCaptionText;
            CfullNameTB.Location = new Point(12, 203);
            CfullNameTB.Name = "CfullNameTB";
            CfullNameTB.Size = new Size(204, 29);
            CfullNameTB.TabIndex = 8;
            CfullNameTB.PlaceholderText = "Full Name";
            // 
            // CphoneTB
            // 
            CphoneTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CphoneTB.ForeColor = SystemColors.ActiveCaptionText;
            CphoneTB.Location = new Point(12, 238);
            CphoneTB.Name = "CphoneTB";
            CphoneTB.Size = new Size(204, 29);
            CphoneTB.TabIndex = 7;
            CphoneTB.PlaceholderText = "Phone Number";
            // 
            // customerIdTB
            // 
            customerIdTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerIdTB.ForeColor = SystemColors.ActiveCaptionText;
            customerIdTB.Location = new Point(12, 133);
            customerIdTB.Name = "customerIdTB";
            customerIdTB.Size = new Size(204, 29);
            customerIdTB.TabIndex = 6;
            customerIdTB.PlaceholderText = "Customer ID";
            // 
            // CustomersGV
            // 
            CustomersGV.AllowUserToAddRows = false;
            CustomersGV.AllowUserToDeleteRows = false;
            CustomersGV.AllowUserToResizeColumns = false;
            CustomersGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            CustomersGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            CustomersGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomersGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            CustomersGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Crimson;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            CustomersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            CustomersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersGV.Location = new Point(221, 130);
            CustomersGV.Name = "CustomersGV";
            CustomersGV.RowTemplate.Height = 25;
            CustomersGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomersGV.Size = new Size(547, 454);
            CustomersGV.TabIndex = 11;
            CustomersGV.CellContentClick += CustomersGV_CellContentClick;
            // 
            // FooterPanel
            // 
            FooterPanel.BackColor = Color.OliveDrab;
            FooterPanel.Dock = DockStyle.Bottom;
            FooterPanel.Location = new Point(0, 590);
            FooterPanel.Name = "FooterPanel";
            FooterPanel.Size = new Size(780, 25);
            FooterPanel.TabIndex = 12;
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
            // OrderNumPanel
            // 
            OrderNumPanel.BackColor = SystemColors.ActiveCaption;
            OrderNumPanel.Controls.Add(OrderLabel);
            OrderNumPanel.Controls.Add(OrderTitleLabel);
            OrderNumPanel.Location = new Point(12, 345);
            OrderNumPanel.Name = "OrderNumPanel";
            OrderNumPanel.Size = new Size(200, 70);
            OrderNumPanel.TabIndex = 17;
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
            // 
            // OrderTitleLabel
            // 
            OrderTitleLabel.AutoSize = true;
            OrderTitleLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            OrderTitleLabel.ForeColor = Color.Black;
            OrderTitleLabel.Location = new Point(58, 10);
            OrderTitleLabel.Name = "OrderTitleLabel";
            OrderTitleLabel.Size = new Size(88, 18);
            OrderTitleLabel.TabIndex = 3;
            OrderTitleLabel.Text = "# of Orders";
            // 
            // OrderAmountTitleLabel
            // 
            OrderAmountTitleLabel.AutoSize = true;
            OrderAmountTitleLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            OrderAmountTitleLabel.ForeColor = Color.Black;
            OrderAmountTitleLabel.Location = new Point(47, 10);
            OrderAmountTitleLabel.Name = "OrderAmountTitleLabel";
            OrderAmountTitleLabel.Size = new Size(112, 18);
            OrderAmountTitleLabel.TabIndex = 3;
            OrderAmountTitleLabel.Text = "Order Amount";
            // 
            // OrderAmountPanel
            // 
            OrderAmountPanel.BackColor = SystemColors.ActiveCaption;
            OrderAmountPanel.Controls.Add(AmountLabel);
            OrderAmountPanel.Controls.Add(OrderAmountTitleLabel);
            OrderAmountPanel.Location = new Point(12, 421);
            OrderAmountPanel.Name = "OrderAmountPanel";
            OrderAmountPanel.Size = new Size(200, 71);
            OrderAmountPanel.TabIndex = 18;
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
            // LatestDatePanel
            // 
            LatestDatePanel.BackColor = SystemColors.ActiveCaption;
            LatestDatePanel.Controls.Add(DateLabel);
            LatestDatePanel.Controls.Add(LatestDateTitleLabel);
            LatestDatePanel.Location = new Point(12, 498);
            LatestDatePanel.Name = "LatestDatePanel";
            LatestDatePanel.Size = new Size(200, 71);
            LatestDatePanel.TabIndex = 19;
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
            // LatestDateTitleLabel
            // 
            LatestDateTitleLabel.AutoSize = true;
            LatestDateTitleLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LatestDateTitleLabel.ForeColor = Color.Black;
            LatestDateTitleLabel.Location = new Point(47, 10);
            LatestDateTitleLabel.Name = "LatestDateTitleLabel";
            LatestDateTitleLabel.Size = new Size(96, 18);
            LatestDateTitleLabel.TabIndex = 3;
            LatestDateTitleLabel.Text = "Latest Order";
            // 
            // ManageCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 615);
            Controls.Add(LatestDatePanel);
            Controls.Add(OrderAmountPanel);
            Controls.Add(OrderNumPanel);
            Controls.Add(CusHomeBT);
            Controls.Add(deleteCustomerBT);
            Controls.Add(editCustomerBT);
            Controls.Add(addCustomerBT);
            Controls.Add(FooterPanel);
            Controls.Add(CustomersGV);
            Controls.Add(CemailTB);
            Controls.Add(CfullNameTB);
            Controls.Add(CphoneTB);
            Controls.Add(customerIdTB);
            Controls.Add(TitleHeaderPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCustomers";
            Load += ManageCustomers_Load;
            TitleHeaderPanel.ResumeLayout(false);
            TitleHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).EndInit();
            OrderNumPanel.ResumeLayout(false);
            OrderNumPanel.PerformLayout();
            OrderAmountPanel.ResumeLayout(false);
            OrderAmountPanel.PerformLayout();
            LatestDatePanel.ResumeLayout(false);
            LatestDatePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TitleHeaderPanel;
        private Label ExitAppLabel;
        private Label AppTitleLabel;
        private Label FormTitleLabel;
        private TextBox CemailTB;
        private TextBox CfullNameTB;
        private TextBox CphoneTB;
        private TextBox customerIdTB;
        private Panel FooterPanel;
        private Button CusHomeBT;
        private Button deleteCustomerBT;
        private Button editCustomerBT;
        private Button addCustomerBT;
        private DataGridView CustomersGV;
        private Panel OrderNumPanel;
        private Label OrderTitleLabel;
        private Label OrderLabel;
        private Label OrderAmountTitleLabel;
        private Panel OrderAmountPanel;
        private Label AmountLabel;
        private Panel LatestDatePanel;
        private Label DateLabel;
        private Label LatestDateTitleLabel;
    }
}