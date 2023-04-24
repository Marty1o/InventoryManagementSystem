namespace IMS
{
    partial class ManageProducts
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
            panel2 = new Panel();
            ProductGV = new DataGridView();
            CusHomeBT = new Button();
            deleteCustomerBT = new Button();
            editCustomerBT = new Button();
            addCustomerBT = new Button();
            prodNameTB = new TextBox();
            prodQuantityTB = new TextBox();
            prodPriceTB = new TextBox();
            productIdTB = new TextBox();
            prodDesTB = new TextBox();
            prodCategoryCB = new ComboBox();
            FilterCatCB = new ComboBox();
            prodFilterBT = new Button();
            searchRefreshBT = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductGV).BeginInit();
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
            panel1.Size = new Size(780, 84);
            panel1.TabIndex = 3;
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
            label1.Location = new Point(276, 47);
            label1.Name = "label1";
            label1.Size = new Size(249, 33);
            label1.TabIndex = 0;
            label1.Text = "Manage Products";
            // 
            // panel2
            // 
            panel2.BackColor = Color.OliveDrab;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 590);
            panel2.Name = "panel2";
            panel2.Size = new Size(780, 25);
            panel2.TabIndex = 14;
            // 
            // ProductGV
            // 
            ProductGV.AllowUserToAddRows = false;
            ProductGV.AllowUserToDeleteRows = false;
            ProductGV.AllowUserToResizeColumns = false;
            ProductGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ProductGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ProductGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.BackColor = Color.Crimson;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ProductGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ProductGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductGV.Location = new Point(221, 130);
            ProductGV.Name = "ProductGV";
            ProductGV.RowTemplate.Height = 25;
            ProductGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductGV.Size = new Size(547, 454);
            ProductGV.TabIndex = 15;
            ProductGV.CellContentClick += ProductGV_CellContentClick;
            // 
            // CusHomeBT
            // 
            CusHomeBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CusHomeBT.Location = new Point(12, 383);
            CusHomeBT.Name = "CusHomeBT";
            CusHomeBT.Size = new Size(204, 30);
            CusHomeBT.TabIndex = 24;
            CusHomeBT.Text = "HOME";
            CusHomeBT.UseVisualStyleBackColor = true;
            CusHomeBT.Click += CusHomeBT_Click;
            // 
            // deleteCustomerBT
            // 
            deleteCustomerBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteCustomerBT.Location = new Point(140, 347);
            deleteCustomerBT.Name = "deleteCustomerBT";
            deleteCustomerBT.Size = new Size(76, 30);
            deleteCustomerBT.TabIndex = 23;
            deleteCustomerBT.Text = "DELETE";
            deleteCustomerBT.UseVisualStyleBackColor = true;
            deleteCustomerBT.Click += deleteCustomerBT_Click;
            // 
            // editCustomerBT
            // 
            editCustomerBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            editCustomerBT.Location = new Point(70, 347);
            editCustomerBT.Name = "editCustomerBT";
            editCustomerBT.Size = new Size(64, 30);
            editCustomerBT.TabIndex = 22;
            editCustomerBT.Text = "EDIT";
            editCustomerBT.UseVisualStyleBackColor = true;
            editCustomerBT.Click += editCustomerBT_Click;
            // 
            // addCustomerBT
            // 
            addCustomerBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            addCustomerBT.Location = new Point(12, 347);
            addCustomerBT.Name = "addCustomerBT";
            addCustomerBT.Size = new Size(52, 30);
            addCustomerBT.TabIndex = 21;
            addCustomerBT.Text = "ADD";
            addCustomerBT.UseVisualStyleBackColor = true;
            addCustomerBT.Click += addCustomerBT_Click;
            // 
            // prodNameTB
            // 
            prodNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prodNameTB.ForeColor = SystemColors.ActiveCaptionText;
            prodNameTB.Location = new Point(11, 165);
            prodNameTB.Name = "prodNameTB";
            prodNameTB.Size = new Size(204, 29);
            prodNameTB.TabIndex = 20;
            prodNameTB.Text = "name";
            // 
            // prodQuantityTB
            // 
            prodQuantityTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prodQuantityTB.ForeColor = SystemColors.ActiveCaptionText;
            prodQuantityTB.Location = new Point(11, 200);
            prodQuantityTB.Name = "prodQuantityTB";
            prodQuantityTB.Size = new Size(204, 29);
            prodQuantityTB.TabIndex = 19;
            prodQuantityTB.Text = "quantity";
            // 
            // prodPriceTB
            // 
            prodPriceTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prodPriceTB.ForeColor = SystemColors.ActiveCaptionText;
            prodPriceTB.Location = new Point(11, 235);
            prodPriceTB.Name = "prodPriceTB";
            prodPriceTB.Size = new Size(204, 29);
            prodPriceTB.TabIndex = 18;
            prodPriceTB.Text = "price";
            // 
            // productIdTB
            // 
            productIdTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productIdTB.ForeColor = SystemColors.ActiveCaptionText;
            productIdTB.Location = new Point(11, 130);
            productIdTB.Name = "productIdTB";
            productIdTB.Size = new Size(204, 29);
            productIdTB.TabIndex = 17;
            productIdTB.Text = "product id";
            // 
            // prodDesTB
            // 
            prodDesTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prodDesTB.ForeColor = SystemColors.ActiveCaptionText;
            prodDesTB.Location = new Point(12, 270);
            prodDesTB.Name = "prodDesTB";
            prodDesTB.Size = new Size(204, 29);
            prodDesTB.TabIndex = 25;
            prodDesTB.Text = "description";
            // 
            // prodCategoryCB
            // 
            prodCategoryCB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prodCategoryCB.ForeColor = SystemColors.ActiveCaptionText;
            prodCategoryCB.FormattingEnabled = true;
            prodCategoryCB.Location = new Point(11, 305);
            prodCategoryCB.Name = "prodCategoryCB";
            prodCategoryCB.Size = new Size(204, 29);
            prodCategoryCB.TabIndex = 26;
            prodCategoryCB.Text = "Category";
            // 
            // FilterCatCB
            // 
            FilterCatCB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FilterCatCB.ForeColor = SystemColors.ActiveCaptionText;
            FilterCatCB.FormattingEnabled = true;
            FilterCatCB.Location = new Point(361, 94);
            FilterCatCB.Name = "FilterCatCB";
            FilterCatCB.Size = new Size(217, 29);
            FilterCatCB.TabIndex = 27;
            FilterCatCB.Text = "Select Category";
            // 
            // prodFilterBT
            // 
            prodFilterBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            prodFilterBT.Location = new Point(584, 94);
            prodFilterBT.Name = "prodFilterBT";
            prodFilterBT.Size = new Size(89, 30);
            prodFilterBT.TabIndex = 28;
            prodFilterBT.Text = "FILTER";
            prodFilterBT.UseVisualStyleBackColor = true;
            prodFilterBT.Click += prodFilterBT_Click;
            // 
            // searchRefreshBT
            // 
            searchRefreshBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchRefreshBT.Location = new Point(679, 94);
            searchRefreshBT.Name = "searchRefreshBT";
            searchRefreshBT.Size = new Size(89, 30);
            searchRefreshBT.TabIndex = 30;
            searchRefreshBT.Text = "REFRESH";
            searchRefreshBT.UseVisualStyleBackColor = true;
            searchRefreshBT.Click += searchRefreshBT_Click;
            // 
            // ManageProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 615);
            Controls.Add(searchRefreshBT);
            Controls.Add(prodFilterBT);
            Controls.Add(FilterCatCB);
            Controls.Add(prodCategoryCB);
            Controls.Add(prodDesTB);
            Controls.Add(CusHomeBT);
            Controls.Add(deleteCustomerBT);
            Controls.Add(editCustomerBT);
            Controls.Add(addCustomerBT);
            Controls.Add(prodNameTB);
            Controls.Add(prodQuantityTB);
            Controls.Add(prodPriceTB);
            Controls.Add(productIdTB);
            Controls.Add(ProductGV);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageProducts";
            Load += ManageProducts_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private DataGridView ProductGV;
        private Button CusHomeBT;
        private Button deleteCustomerBT;
        private Button editCustomerBT;
        private Button addCustomerBT;
        private TextBox prodNameTB;
        private TextBox prodQuantityTB;
        private TextBox prodPriceTB;
        private TextBox productIdTB;
        private TextBox prodDesTB;
        private ComboBox prodCategoryCB;
        private ComboBox FilterCatCB;
        private Button prodFilterBT;
        private Button searchRefreshBT;
    }
}