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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            HeaderTitlePanel = new Panel();
            ExitAppLabel = new Label();
            AppNameLabel = new Label();
            FormNameLabel = new Label();
            FooterPanel = new Panel();
            ProductGV = new DataGridView();
            ProdHomeBT = new Button();
            deleteProductBT = new Button();
            editProductBT = new Button();
            addProductBT = new Button();
            prodNameTB = new TextBox();
            prodQuantityTB = new TextBox();
            prodPriceTB = new TextBox();
            productIdTB = new TextBox();
            prodDesTB = new TextBox();
            prodCategoryCB = new ComboBox();
            FilterCatCB = new ComboBox();
            prodFilterBT = new Button();
            searchRefreshBT = new Button();
            HeaderTitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductGV).BeginInit();
            SuspendLayout();
            // 
            // HeaderTitlePanel
            // 
            HeaderTitlePanel.BackColor = Color.OliveDrab;
            HeaderTitlePanel.Controls.Add(ExitAppLabel);
            HeaderTitlePanel.Controls.Add(AppNameLabel);
            HeaderTitlePanel.Controls.Add(FormNameLabel);
            HeaderTitlePanel.Dock = DockStyle.Top;
            HeaderTitlePanel.Location = new Point(0, 0);
            HeaderTitlePanel.Name = "HeaderTitlePanel";
            HeaderTitlePanel.Size = new Size(780, 84);
            HeaderTitlePanel.TabIndex = 3;
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
            // AppNameLabel
            // 
            AppNameLabel.AutoSize = true;
            AppNameLabel.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            AppNameLabel.ForeColor = Color.White;
            AppNameLabel.Location = new Point(174, 9);
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
            FormNameLabel.Location = new Point(276, 47);
            FormNameLabel.Name = "FormNameLabel";
            FormNameLabel.Size = new Size(249, 33);
            FormNameLabel.TabIndex = 0;
            FormNameLabel.Text = "Manage Products";
            // 
            // FooterPanel
            // 
            FooterPanel.BackColor = Color.OliveDrab;
            FooterPanel.Dock = DockStyle.Bottom;
            FooterPanel.Location = new Point(0, 590);
            FooterPanel.Name = "FooterPanel";
            FooterPanel.Size = new Size(780, 25);
            FooterPanel.TabIndex = 14;
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
            ProductGV.Location = new Point(221, 130);
            ProductGV.Name = "ProductGV";
            ProductGV.RowTemplate.Height = 25;
            ProductGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductGV.Size = new Size(547, 454);
            ProductGV.TabIndex = 15;
            ProductGV.CellContentClick += ProductGV_CellContentClick;
            // 
            // ProdHomeBT
            // 
            ProdHomeBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProdHomeBT.Location = new Point(12, 383);
            ProdHomeBT.Name = "ProdHomeBT";
            ProdHomeBT.Size = new Size(204, 30);
            ProdHomeBT.TabIndex = 24;
            ProdHomeBT.Text = "HOME";
            ProdHomeBT.UseVisualStyleBackColor = true;
            ProdHomeBT.Click += ProdHomeBT_Click;
            // 
            // deleteProductBT
            // 
            deleteProductBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteProductBT.Location = new Point(140, 347);
            deleteProductBT.Name = "deleteProductBT";
            deleteProductBT.Size = new Size(76, 30);
            deleteProductBT.TabIndex = 23;
            deleteProductBT.Text = "DELETE";
            deleteProductBT.UseVisualStyleBackColor = true;
            deleteProductBT.Click += deleteProductBT_Click;
            // 
            // editProductBT
            // 
            editProductBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            editProductBT.Location = new Point(70, 347);
            editProductBT.Name = "editProductBT";
            editProductBT.Size = new Size(64, 30);
            editProductBT.TabIndex = 22;
            editProductBT.Text = "EDIT";
            editProductBT.UseVisualStyleBackColor = true;
            editProductBT.Click += editProductBT_Click;
            // 
            // addProductBT
            // 
            addProductBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            addProductBT.Location = new Point(12, 347);
            addProductBT.Name = "addProductBT";
            addProductBT.Size = new Size(52, 30);
            addProductBT.TabIndex = 21;
            addProductBT.Text = "ADD";
            addProductBT.UseVisualStyleBackColor = true;
            addProductBT.Click += addProductBT_Click;
            // 
            // prodNameTB
            // 
            prodNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prodNameTB.ForeColor = SystemColors.ActiveCaptionText;
            prodNameTB.Location = new Point(11, 165);
            prodNameTB.Name = "prodNameTB";
            prodNameTB.PlaceholderText = "Name";
            prodNameTB.Size = new Size(204, 29);
            prodNameTB.TabIndex = 20;
            // 
            // prodQuantityTB
            // 
            prodQuantityTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prodQuantityTB.ForeColor = SystemColors.ActiveCaptionText;
            prodQuantityTB.Location = new Point(11, 200);
            prodQuantityTB.Name = "prodQuantityTB";
            prodQuantityTB.PlaceholderText = "Quantity";
            prodQuantityTB.Size = new Size(204, 29);
            prodQuantityTB.TabIndex = 19;
            // 
            // prodPriceTB
            // 
            prodPriceTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prodPriceTB.ForeColor = SystemColors.ActiveCaptionText;
            prodPriceTB.Location = new Point(11, 235);
            prodPriceTB.Name = "prodPriceTB";
            prodPriceTB.PlaceholderText = "Price";
            prodPriceTB.Size = new Size(204, 29);
            prodPriceTB.TabIndex = 18;
            // 
            // productIdTB
            // 
            productIdTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productIdTB.ForeColor = SystemColors.ActiveCaptionText;
            productIdTB.Location = new Point(11, 130);
            productIdTB.Name = "productIdTB";
            productIdTB.PlaceholderText = "Product ID";
            productIdTB.Size = new Size(204, 29);
            productIdTB.TabIndex = 17;
            // 
            // prodDesTB
            // 
            prodDesTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prodDesTB.ForeColor = SystemColors.ActiveCaptionText;
            prodDesTB.Location = new Point(12, 270);
            prodDesTB.Name = "prodDesTB";
            prodDesTB.PlaceholderText = "Description";
            prodDesTB.Size = new Size(204, 29);
            prodDesTB.TabIndex = 25;
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
            Controls.Add(ProdHomeBT);
            Controls.Add(deleteProductBT);
            Controls.Add(editProductBT);
            Controls.Add(addProductBT);
            Controls.Add(prodNameTB);
            Controls.Add(prodQuantityTB);
            Controls.Add(prodPriceTB);
            Controls.Add(productIdTB);
            Controls.Add(ProductGV);
            Controls.Add(FooterPanel);
            Controls.Add(HeaderTitlePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageProducts";
            Load += ManageProducts_Load;
            HeaderTitlePanel.ResumeLayout(false);
            HeaderTitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel HeaderTitlePanel;
        private Label ExitAppLabel;
        private Label AppNameLabel;
        private Label FormNameLabel;
        private Panel FooterPanel;
        private DataGridView ProductGV;
        private Button ProdHomeBT;
        private Button deleteProductBT;
        private Button editProductBT;
        private Button addProductBT;
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