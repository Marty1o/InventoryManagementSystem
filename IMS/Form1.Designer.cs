namespace IMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            showPasswordCheckbox = new CheckBox();
            clearLabel = new Label();
            loginBT = new Button();
            passwordTB = new TextBox();
            usernameTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OliveDrab;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(showPasswordCheckbox);
            panel1.Controls.Add(clearLabel);
            panel1.Controls.Add(loginBT);
            panel1.Controls.Add(passwordTB);
            panel1.Controls.Add(usernameTB);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(135, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 332);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(87, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // showPasswordCheckbox
            // 
            showPasswordCheckbox.AutoSize = true;
            showPasswordCheckbox.Font = new Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            showPasswordCheckbox.Location = new Point(87, 281);
            showPasswordCheckbox.Name = "showPasswordCheckbox";
            showPasswordCheckbox.Size = new Size(132, 20);
            showPasswordCheckbox.TabIndex = 5;
            showPasswordCheckbox.Text = "Show Password";
            showPasswordCheckbox.UseVisualStyleBackColor = true;
            showPasswordCheckbox.CheckedChanged += showPasswordCheckbox_CheckedChanged;
            // 
            // clearLabel
            // 
            clearLabel.AutoSize = true;
            clearLabel.Font = new Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            clearLabel.ForeColor = Color.Red;
            clearLabel.Location = new Point(19, 282);
            clearLabel.Name = "clearLabel";
            clearLabel.Size = new Size(44, 16);
            clearLabel.TabIndex = 4;
            clearLabel.Text = "Clear";
            clearLabel.Click += clearLabel_Click;
            // 
            // loginBT
            // 
            loginBT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginBT.Location = new Point(35, 230);
            loginBT.Name = "loginBT";
            loginBT.Size = new Size(156, 38);
            loginBT.TabIndex = 3;
            loginBT.Text = "LOGIN";
            loginBT.UseVisualStyleBackColor = true;
            loginBT.Click += loginBT_Click;
            // 
            // passwordTB
            // 
            passwordTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTB.Location = new Point(19, 185);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(200, 29);
            passwordTB.TabIndex = 2;
            passwordTB.Text = "Password";
            passwordTB.UseSystemPasswordChar = true;
            // 
            // usernameTB
            // 
            usernameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTB.Location = new Point(19, 126);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(200, 29);
            usernameTB.TabIndex = 1;
            usernameTB.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(90, 15);
            label1.Name = "label1";
            label1.Size = new Size(69, 30);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(143, 34);
            label2.Name = "label2";
            label2.Size = new Size(234, 30);
            label2.TabIndex = 1;
            label2.Text = "Inventory Managment";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(514, 471);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button loginBT;
        private TextBox passwordTB;
        private TextBox usernameTB;
        private Label label1;
        private Label label2;
        private CheckBox showPasswordCheckbox;
        private Label clearLabel;
        private PictureBox pictureBox1;
    }
}