namespace IMS
{
    partial class ViewOrders
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
            label1 = new Label();
            ViewOrderGV = new DataGridView();
            closeViewOrderBT = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewOrderGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 101);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(263, 44);
            label1.Name = "label1";
            label1.Size = new Size(175, 33);
            label1.TabIndex = 1;
            label1.Text = "View Orders";
            label1.Click += label1_Click;
            // 
            // ViewOrderGV
            // 
            ViewOrderGV.AllowUserToAddRows = false;
            ViewOrderGV.AllowUserToDeleteRows = false;
            ViewOrderGV.AllowUserToResizeColumns = false;
            ViewOrderGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ViewOrderGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ViewOrderGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewOrderGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.BackColor = Color.Crimson;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ViewOrderGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ViewOrderGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewOrderGV.Location = new Point(59, 121);
            ViewOrderGV.Name = "ViewOrderGV";
            ViewOrderGV.RowTemplate.Height = 25;
            ViewOrderGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ViewOrderGV.Size = new Size(585, 508);
            ViewOrderGV.TabIndex = 34;
            // 
            // closeViewOrderBT
            // 
            closeViewOrderBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            closeViewOrderBT.Location = new Point(303, 635);
            closeViewOrderBT.Name = "closeViewOrderBT";
            closeViewOrderBT.Size = new Size(102, 30);
            closeViewOrderBT.TabIndex = 39;
            closeViewOrderBT.Text = "Close";
            closeViewOrderBT.UseVisualStyleBackColor = true;
            closeViewOrderBT.Click += viewOrderBT_Click;
            // 
            // ViewOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 688);
            Controls.Add(closeViewOrderBT);
            Controls.Add(ViewOrderGV);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewOrders";
            Load += ViewOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ViewOrderGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView ViewOrderGV;
        private Button closeViewOrderBT;
    }
}