namespace IMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            InnerLoginPanel = new Panel();
            LogoPB = new PictureBox();
            showPasswordCheckbox = new CheckBox();
            clearLabel = new Label();
            loginBT = new Button();
            passwordTB = new TextBox();
            usernameTB = new TextBox();
            LoginTitleLabel = new Label();
            AppNameLabel = new Label();
            ExitAppLabel = new Label();
            InnerLoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPB).BeginInit();
            SuspendLayout();
            // 
            // InnerLoginPanel
            // 
            InnerLoginPanel.BackColor = Color.OliveDrab;
            InnerLoginPanel.Controls.Add(LogoPB);
            InnerLoginPanel.Controls.Add(showPasswordCheckbox);
            InnerLoginPanel.Controls.Add(clearLabel);
            InnerLoginPanel.Controls.Add(loginBT);
            InnerLoginPanel.Controls.Add(passwordTB);
            InnerLoginPanel.Controls.Add(usernameTB);
            InnerLoginPanel.Controls.Add(LoginTitleLabel);
            InnerLoginPanel.Location = new Point(135, 94);
            InnerLoginPanel.Name = "InnerLoginPanel";
            InnerLoginPanel.Size = new Size(242, 332);
            InnerLoginPanel.TabIndex = 0;
            // 
            // LogoPB
            // 
            LogoPB.BackColor = Color.Transparent;
            LogoPB.Image = (Image)resources.GetObject("LogoPB.Image");
            LogoPB.Location = new Point(87, 48);
            LogoPB.Name = "LogoPB";
            LogoPB.Size = new Size(73, 72);
            LogoPB.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoPB.TabIndex = 6;
            LogoPB.TabStop = false;
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
            passwordTB.PlaceholderText = "Password";
            passwordTB.Size = new Size(200, 29);
            passwordTB.TabIndex = 2;
            passwordTB.UseSystemPasswordChar = true;
            // 
            // usernameTB
            // 
            usernameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTB.Location = new Point(19, 140);
            usernameTB.Name = "usernameTB";
            usernameTB.PlaceholderText = "Username";
            usernameTB.Size = new Size(200, 29);
            usernameTB.TabIndex = 1;
            // 
            // LoginTitleLabel
            // 
            LoginTitleLabel.AutoSize = true;
            LoginTitleLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LoginTitleLabel.ForeColor = Color.White;
            LoginTitleLabel.Location = new Point(90, 15);
            LoginTitleLabel.Name = "LoginTitleLabel";
            LoginTitleLabel.Size = new Size(69, 30);
            LoginTitleLabel.TabIndex = 0;
            LoginTitleLabel.Text = "Login";
            // 
            // AppNameLabel
            // 
            AppNameLabel.AutoSize = true;
            AppNameLabel.BackColor = Color.Transparent;
            AppNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            AppNameLabel.ForeColor = Color.White;
            AppNameLabel.Location = new Point(143, 34);
            AppNameLabel.Name = "AppNameLabel";
            AppNameLabel.Size = new Size(234, 30);
            AppNameLabel.TabIndex = 1;
            AppNameLabel.Text = "Inventory Managment";
            // 
            // ExitAppLabel
            // 
            ExitAppLabel.AutoSize = true;
            ExitAppLabel.BackColor = Color.Transparent;
            ExitAppLabel.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ExitAppLabel.ForeColor = Color.White;
            ExitAppLabel.Location = new Point(484, -1);
            ExitAppLabel.Name = "ExitAppLabel";
            ExitAppLabel.Size = new Size(31, 33);
            ExitAppLabel.TabIndex = 4;
            ExitAppLabel.Text = "X";
            ExitAppLabel.Click += ExitAppLabel_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(514, 471);
            Controls.Add(ExitAppLabel);
            Controls.Add(AppNameLabel);
            Controls.Add(InnerLoginPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            InnerLoginPanel.ResumeLayout(false);
            InnerLoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel InnerLoginPanel;
        private Button loginBT;
        private TextBox passwordTB;
        private TextBox usernameTB;
        private Label LoginTitleLabel;
        private Label AppNameLabel;
        private CheckBox showPasswordCheckbox;
        private Label clearLabel;
        private PictureBox LogoPB;
        private Label ExitAppLabel;
    }
}