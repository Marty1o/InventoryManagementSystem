namespace IMS
{
    partial class ManageCategories
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
            label3 = new Label();
            AppNameLabel = new Label();
            FormTitleLabel = new Label();
            FooterPanel = new Panel();
            CategoryGV = new DataGridView();
            CatHomeBT = new Button();
            deleteCategoryBT = new Button();
            editCategoryBT = new Button();
            addCategoryBT = new Button();
            prodCategoryIdTB = new TextBox();
            categoryNameTB = new TextBox();
            TitleHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryGV).BeginInit();
            SuspendLayout();
            // 
            // TitleHeaderPanel
            // 
            TitleHeaderPanel.BackColor = Color.OliveDrab;
            TitleHeaderPanel.Controls.Add(label3);
            TitleHeaderPanel.Controls.Add(AppNameLabel);
            TitleHeaderPanel.Controls.Add(FormTitleLabel);
            TitleHeaderPanel.Dock = DockStyle.Top;
            TitleHeaderPanel.Location = new Point(0, 0);
            TitleHeaderPanel.Name = "TitleHeaderPanel";
            TitleHeaderPanel.Size = new Size(780, 107);
            TitleHeaderPanel.TabIndex = 2;
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
            // FormTitleLabel
            // 
            FormTitleLabel.AutoSize = true;
            FormTitleLabel.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormTitleLabel.ForeColor = Color.White;
            FormTitleLabel.Location = new Point(246, 58);
            FormTitleLabel.Name = "FormTitleLabel";
            FormTitleLabel.Size = new Size(281, 33);
            FormTitleLabel.TabIndex = 0;
            FormTitleLabel.Text = "Manage Categories";
            // 
            // FooterPanel
            // 
            FooterPanel.BackColor = Color.OliveDrab;
            FooterPanel.Dock = DockStyle.Bottom;
            FooterPanel.Location = new Point(0, 590);
            FooterPanel.Name = "FooterPanel";
            FooterPanel.Size = new Size(780, 25);
            FooterPanel.TabIndex = 13;
            // 
            // CategoryGV
            // 
            CategoryGV.AllowUserToAddRows = false;
            CategoryGV.AllowUserToDeleteRows = false;
            CategoryGV.AllowUserToResizeColumns = false;
            CategoryGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            CategoryGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            CategoryGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CategoryGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            CategoryGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Crimson;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            CategoryGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            CategoryGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryGV.Location = new Point(221, 130);
            CategoryGV.Name = "CategoryGV";
            CategoryGV.RowTemplate.Height = 25;
            CategoryGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CategoryGV.Size = new Size(547, 454);
            CategoryGV.TabIndex = 14;
            CategoryGV.CellContentClick += CategoryGV_CellContentClick;
            // 
            // CatHomeBT
            // 
            CatHomeBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CatHomeBT.Location = new Point(11, 236);
            CatHomeBT.Name = "CatHomeBT";
            CatHomeBT.Size = new Size(204, 30);
            CatHomeBT.TabIndex = 22;
            CatHomeBT.Text = "HOME";
            CatHomeBT.UseVisualStyleBackColor = true;
            CatHomeBT.Click += CatHomeBT_Click;
            // 
            // deleteCategoryBT
            // 
            deleteCategoryBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteCategoryBT.Location = new Point(139, 200);
            deleteCategoryBT.Name = "deleteCategoryBT";
            deleteCategoryBT.Size = new Size(76, 30);
            deleteCategoryBT.TabIndex = 21;
            deleteCategoryBT.Text = "DELETE";
            deleteCategoryBT.UseVisualStyleBackColor = true;
            deleteCategoryBT.Click += deleteCategoryBT_Click;
            // 
            // editCategoryBT
            // 
            editCategoryBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            editCategoryBT.Location = new Point(69, 200);
            editCategoryBT.Name = "editCategoryBT";
            editCategoryBT.Size = new Size(64, 30);
            editCategoryBT.TabIndex = 20;
            editCategoryBT.Text = "EDIT";
            editCategoryBT.UseVisualStyleBackColor = true;
            editCategoryBT.Click += editCategoryBT_Click;
            // 
            // addCategoryBT
            // 
            addCategoryBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            addCategoryBT.Location = new Point(11, 200);
            addCategoryBT.Name = "addCategoryBT";
            addCategoryBT.Size = new Size(52, 30);
            addCategoryBT.TabIndex = 19;
            addCategoryBT.Text = "ADD";
            addCategoryBT.UseVisualStyleBackColor = true;
            addCategoryBT.Click += addCategoryBT_Click;
            // 
            // prodCategoryIdTB
            // 
            prodCategoryIdTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prodCategoryIdTB.ForeColor = SystemColors.ActiveCaptionText;
            prodCategoryIdTB.Location = new Point(11, 130);
            prodCategoryIdTB.Name = "prodCategoryIdTB";
            prodCategoryIdTB.PlaceholderText = "Category ID";
            prodCategoryIdTB.Size = new Size(204, 29);
            prodCategoryIdTB.TabIndex = 18;
            // 
            // categoryNameTB
            // 
            categoryNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            categoryNameTB.ForeColor = SystemColors.ActiveCaptionText;
            categoryNameTB.Location = new Point(11, 165);
            categoryNameTB.Name = "categoryNameTB";
            categoryNameTB.PlaceholderText = "Category Name";
            categoryNameTB.Size = new Size(204, 29);
            categoryNameTB.TabIndex = 17;
            // 
            // ManageCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 615);
            Controls.Add(CatHomeBT);
            Controls.Add(deleteCategoryBT);
            Controls.Add(editCategoryBT);
            Controls.Add(addCategoryBT);
            Controls.Add(prodCategoryIdTB);
            Controls.Add(categoryNameTB);
            Controls.Add(CategoryGV);
            Controls.Add(FooterPanel);
            Controls.Add(TitleHeaderPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCategories";
            Load += ManageCategories_Load;
            TitleHeaderPanel.ResumeLayout(false);
            TitleHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TitleHeaderPanel;
        private Label label3;
        private Label AppNameLabel;
        private Label FormTitleLabel;
        private Panel FooterPanel;
        private DataGridView CategoryGV;
        private Button CatHomeBT;
        private Button deleteCategoryBT;
        private Button editCategoryBT;
        private Button addCategoryBT;
        private TextBox prodCategoryIdTB;
        private TextBox categoryNameTB;
    }
}