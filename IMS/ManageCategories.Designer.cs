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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            CategoryGV = new DataGridView();
            CusHomeBT = new Button();
            deleteCustomerBT = new Button();
            editCustomerBT = new Button();
            addCustomerBT = new Button();
            prodCategoryIdTB = new TextBox();
            categoryNameTB = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryGV).BeginInit();
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
            panel1.TabIndex = 2;
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
            label1.Size = new Size(281, 33);
            label1.TabIndex = 0;
            label1.Text = "Manage Categories";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.OliveDrab;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 590);
            panel2.Name = "panel2";
            panel2.Size = new Size(780, 25);
            panel2.TabIndex = 13;
            // 
            // CategoryGV
            // 
            CategoryGV.AllowUserToAddRows = false;
            CategoryGV.AllowUserToDeleteRows = false;
            CategoryGV.AllowUserToResizeColumns = false;
            CategoryGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CategoryGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            CategoryGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CategoryGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            CategoryGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Crimson;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CategoryGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CategoryGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryGV.Location = new Point(221, 130);
            CategoryGV.Name = "CategoryGV";
            CategoryGV.RowTemplate.Height = 25;
            CategoryGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CategoryGV.Size = new Size(547, 454);
            CategoryGV.TabIndex = 14;
            CategoryGV.CellContentClick += CategoryGV_CellContentClick;
            // 
            // CusHomeBT
            // 
            CusHomeBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CusHomeBT.Location = new Point(11, 236);
            CusHomeBT.Name = "CusHomeBT";
            CusHomeBT.Size = new Size(204, 30);
            CusHomeBT.TabIndex = 22;
            CusHomeBT.Text = "HOME";
            CusHomeBT.UseVisualStyleBackColor = true;
            CusHomeBT.Click += CusHomeBT_Click;
            // 
            // deleteCustomerBT
            // 
            deleteCustomerBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteCustomerBT.Location = new Point(139, 200);
            deleteCustomerBT.Name = "deleteCustomerBT";
            deleteCustomerBT.Size = new Size(76, 30);
            deleteCustomerBT.TabIndex = 21;
            deleteCustomerBT.Text = "DELETE";
            deleteCustomerBT.UseVisualStyleBackColor = true;
            deleteCustomerBT.Click += deleteCustomerBT_Click;
            // 
            // editCustomerBT
            // 
            editCustomerBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            editCustomerBT.Location = new Point(69, 200);
            editCustomerBT.Name = "editCustomerBT";
            editCustomerBT.Size = new Size(64, 30);
            editCustomerBT.TabIndex = 20;
            editCustomerBT.Text = "EDIT";
            editCustomerBT.UseVisualStyleBackColor = true;
            editCustomerBT.Click += editCustomerBT_Click;
            // 
            // addCustomerBT
            // 
            addCustomerBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            addCustomerBT.Location = new Point(11, 200);
            addCustomerBT.Name = "addCustomerBT";
            addCustomerBT.Size = new Size(52, 30);
            addCustomerBT.TabIndex = 19;
            addCustomerBT.Text = "ADD";
            addCustomerBT.UseVisualStyleBackColor = true;
            addCustomerBT.Click += addCustomerBT_Click;
            // 
            // prodCategoryIdTB
            // 
            prodCategoryIdTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prodCategoryIdTB.ForeColor = Color.Crimson;
            prodCategoryIdTB.Location = new Point(11, 130);
            prodCategoryIdTB.Name = "prodCategoryIdTB";
            prodCategoryIdTB.Size = new Size(204, 29);
            prodCategoryIdTB.TabIndex = 18;
            prodCategoryIdTB.Text = "category id";
            // 
            // categoryNameTB
            // 
            categoryNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            categoryNameTB.ForeColor = Color.Crimson;
            categoryNameTB.Location = new Point(11, 165);
            categoryNameTB.Name = "categoryNameTB";
            categoryNameTB.Size = new Size(204, 29);
            categoryNameTB.TabIndex = 17;
            categoryNameTB.Text = "Category Name";
            // 
            // ManageCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 615);
            Controls.Add(CusHomeBT);
            Controls.Add(deleteCustomerBT);
            Controls.Add(editCustomerBT);
            Controls.Add(addCustomerBT);
            Controls.Add(prodCategoryIdTB);
            Controls.Add(categoryNameTB);
            Controls.Add(CategoryGV);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCategories";
            Load += ManageCategories_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private DataGridView CategoryGV;
        private Button CusHomeBT;
        private Button deleteCustomerBT;
        private Button editCustomerBT;
        private Button addCustomerBT;
        private TextBox prodCategoryIdTB;
        private TextBox categoryNameTB;
    }
}