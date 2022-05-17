
namespace HH
{
    partial class user_login
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PasswordText = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserNameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.signin = new Guna.UI2.WinForms.Guna2Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ROG Fonts", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(668, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 42);
            this.label3.TabIndex = 10;
            this.label3.Text = "USER LOG IN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Logo);
            this.panel2.Controls.Add(this.LoginLabel);
            this.panel2.Location = new System.Drawing.Point(675, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 341);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Premier League";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.LoginLabel.Location = new System.Drawing.Point(92, 291);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(86, 33);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "Login";
            // 
            // LoginBtn
            // 
            this.LoginBtn.CheckedState.Parent = this.LoginBtn;
            this.LoginBtn.CustomImages.Parent = this.LoginBtn;
            this.LoginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginBtn.DisabledState.Parent = this.LoginBtn;
            this.LoginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(152)))), ((int)(((byte)(227)))));
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.HoverState.Parent = this.LoginBtn;
            this.LoginBtn.Location = new System.Drawing.Point(815, 576);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.ShadowDecoration.Parent = this.LoginBtn;
            this.LoginBtn.Size = new System.Drawing.Size(103, 45);
            this.LoginBtn.TabIndex = 14;
            this.LoginBtn.Text = "LOG IN";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswordText
            // 
            this.PasswordText.BorderRadius = 6;
            this.PasswordText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordText.DefaultText = "";
            this.PasswordText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordText.DisabledState.Parent = this.PasswordText;
            this.PasswordText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordText.FocusedState.Parent = this.PasswordText;
            this.PasswordText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PasswordText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordText.HoverState.Parent = this.PasswordText;
            this.PasswordText.Location = new System.Drawing.Point(706, 518);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '\0';
            this.PasswordText.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PasswordText.PlaceholderText = "";
            this.PasswordText.SelectedText = "";
            this.PasswordText.ShadowDecoration.Parent = this.PasswordText;
            this.PasswordText.Size = new System.Drawing.Size(212, 36);
            this.PasswordText.TabIndex = 13;
            this.PasswordText.UseSystemPasswordChar = true;
            // 
            // UserNameText
            // 
            this.UserNameText.BorderRadius = 6;
            this.UserNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNameText.DefaultText = "";
            this.UserNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserNameText.DisabledState.Parent = this.UserNameText;
            this.UserNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserNameText.FocusedState.Parent = this.UserNameText;
            this.UserNameText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.UserNameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserNameText.HoverState.Parent = this.UserNameText;
            this.UserNameText.Location = new System.Drawing.Point(707, 436);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.PasswordChar = '\0';
            this.UserNameText.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.UserNameText.PlaceholderText = "";
            this.UserNameText.SelectedText = "";
            this.UserNameText.ShadowDecoration.Parent = this.UserNameText;
            this.UserNameText.Size = new System.Drawing.Size(211, 36);
            this.UserNameText.TabIndex = 12;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(701, 490);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(106, 25);
            this.PasswordLabel.TabIndex = 16;
            this.PasswordLabel.Text = "Password";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(701, 408);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(110, 25);
            this.UserNameLabel.TabIndex = 15;
            this.UserNameLabel.Text = "Username";
            // 
            // signin
            // 
            this.signin.CheckedState.Parent = this.signin;
            this.signin.CustomImages.Parent = this.signin;
            this.signin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signin.DisabledState.Parent = this.signin;
            this.signin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(152)))), ((int)(((byte)(227)))));
            this.signin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.signin.ForeColor = System.Drawing.Color.White;
            this.signin.HoverState.Parent = this.signin;
            this.signin.Location = new System.Drawing.Point(704, 576);
            this.signin.Name = "signin";
            this.signin.ShadowDecoration.Parent = this.signin;
            this.signin.Size = new System.Drawing.Size(103, 45);
            this.signin.TabIndex = 17;
            this.signin.Text = "SIGN IN";
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::HH.Properties.Resources.pl_icon1;
            this.Logo.Location = new System.Drawing.Point(31, 65);
            this.Logo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(199, 215);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HH.Properties.Resources._379ab160435981_5a4d0f2432b3e;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 651);
            this.panel1.TabIndex = 0;
            // 
            // user_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1054, 675);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UserNameText);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "user_login";
            this.Text = "user_login";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label LoginLabel;
        private Guna.UI2.WinForms.Guna2Button LoginBtn;
        private Guna.UI2.WinForms.Guna2TextBox PasswordText;
        private Guna.UI2.WinForms.Guna2TextBox UserNameText;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private Guna.UI2.WinForms.Guna2Button signin;
    }
}