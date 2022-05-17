
namespace HH
{
    partial class sign_inUser
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailText = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.SigninBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RePasswordText = new Guna.UI2.WinForms.Guna2TextBox();
            this.RePasswordLabel = new System.Windows.Forms.Label();
            this.PasswordText = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserNameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Logo);
            this.panel2.Controls.Add(this.LoginLabel);
            this.panel2.Location = new System.Drawing.Point(692, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 341);
            this.panel2.TabIndex = 13;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ROG Fonts", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(685, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 38);
            this.label3.TabIndex = 12;
            this.label3.Text = "USER SIGN IN";
            // 
            // EmailText
            // 
            this.EmailText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailText.DefaultText = "";
            this.EmailText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailText.DisabledState.Parent = this.EmailText;
            this.EmailText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailText.FocusedState.Parent = this.EmailText;
            this.EmailText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmailText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.EmailText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailText.HoverState.Parent = this.EmailText;
            this.EmailText.Location = new System.Drawing.Point(735, 659);
            this.EmailText.Name = "EmailText";
            this.EmailText.PasswordChar = '\0';
            this.EmailText.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.EmailText.PlaceholderText = "";
            this.EmailText.SelectedText = "";
            this.EmailText.ShadowDecoration.Parent = this.EmailText;
            this.EmailText.Size = new System.Drawing.Size(212, 36);
            this.EmailText.TabIndex = 25;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(730, 631);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(65, 25);
            this.EmailLabel.TabIndex = 31;
            this.EmailLabel.Text = "Email";
            // 
            // SigninBtn
            // 
            this.SigninBtn.CheckedState.Parent = this.SigninBtn;
            this.SigninBtn.CustomImages.Parent = this.SigninBtn;
            this.SigninBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SigninBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SigninBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SigninBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SigninBtn.DisabledState.Parent = this.SigninBtn;
            this.SigninBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(152)))), ((int)(((byte)(227)))));
            this.SigninBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SigninBtn.ForeColor = System.Drawing.Color.White;
            this.SigninBtn.HoverState.Parent = this.SigninBtn;
            this.SigninBtn.Location = new System.Drawing.Point(790, 712);
            this.SigninBtn.Name = "SigninBtn";
            this.SigninBtn.ShadowDecoration.Parent = this.SigninBtn;
            this.SigninBtn.Size = new System.Drawing.Size(103, 45);
            this.SigninBtn.TabIndex = 27;
            this.SigninBtn.Text = "Sign in";
            this.SigninBtn.Click += new System.EventHandler(this.SigninBtn_Click);
            // 
            // RePasswordText
            // 
            this.RePasswordText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RePasswordText.DefaultText = "";
            this.RePasswordText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RePasswordText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RePasswordText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RePasswordText.DisabledState.Parent = this.RePasswordText;
            this.RePasswordText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RePasswordText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RePasswordText.FocusedState.Parent = this.RePasswordText;
            this.RePasswordText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RePasswordText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.RePasswordText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RePasswordText.HoverState.Parent = this.RePasswordText;
            this.RePasswordText.Location = new System.Drawing.Point(735, 592);
            this.RePasswordText.Name = "RePasswordText";
            this.RePasswordText.PasswordChar = '\0';
            this.RePasswordText.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.RePasswordText.PlaceholderText = "";
            this.RePasswordText.SelectedText = "";
            this.RePasswordText.ShadowDecoration.Parent = this.RePasswordText;
            this.RePasswordText.Size = new System.Drawing.Size(212, 36);
            this.RePasswordText.TabIndex = 24;
            this.RePasswordText.UseSystemPasswordChar = true;
            // 
            // RePasswordLabel
            // 
            this.RePasswordLabel.AutoSize = true;
            this.RePasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RePasswordLabel.Location = new System.Drawing.Point(730, 564);
            this.RePasswordLabel.Name = "RePasswordLabel";
            this.RePasswordLabel.Size = new System.Drawing.Size(140, 25);
            this.RePasswordLabel.TabIndex = 30;
            this.RePasswordLabel.Text = "Re-Password";
            // 
            // PasswordText
            // 
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
            this.PasswordText.Location = new System.Drawing.Point(735, 516);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '\0';
            this.PasswordText.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PasswordText.PlaceholderText = "";
            this.PasswordText.SelectedText = "";
            this.PasswordText.ShadowDecoration.Parent = this.PasswordText;
            this.PasswordText.Size = new System.Drawing.Size(212, 36);
            this.PasswordText.TabIndex = 23;
            this.PasswordText.UseSystemPasswordChar = true;
            // 
            // UserNameText
            // 
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
            this.UserNameText.Location = new System.Drawing.Point(735, 438);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.PasswordChar = '\0';
            this.UserNameText.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.UserNameText.PlaceholderText = "";
            this.UserNameText.SelectedText = "";
            this.UserNameText.ShadowDecoration.Parent = this.UserNameText;
            this.UserNameText.Size = new System.Drawing.Size(211, 36);
            this.UserNameText.TabIndex = 22;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(731, 488);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(106, 25);
            this.PasswordLabel.TabIndex = 29;
            this.PasswordLabel.Text = "Password";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(730, 410);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(110, 25);
            this.UserNameLabel.TabIndex = 28;
            this.UserNameLabel.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HH.Properties.Resources.c022693e8cf3d3921af34c193793c75a;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 757);
            this.panel1.TabIndex = 0;
            // 
            // sign_inUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1054, 789);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.SigninBtn);
            this.Controls.Add(this.RePasswordText);
            this.Controls.Add(this.RePasswordLabel);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UserNameText);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "sign_inUser";
            this.Text = "sign_inUser";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox EmailText;
        private System.Windows.Forms.Label EmailLabel;
        private Guna.UI2.WinForms.Guna2Button SigninBtn;
        private Guna.UI2.WinForms.Guna2TextBox RePasswordText;
        private System.Windows.Forms.Label RePasswordLabel;
        private Guna.UI2.WinForms.Guna2TextBox PasswordText;
        private Guna.UI2.WinForms.Guna2TextBox UserNameText;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserNameLabel;
    }
}