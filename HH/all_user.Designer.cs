
namespace HH
{
    partial class all_user
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.SigninBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Turquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user,
            this.pass,
            this.email,
            this.point});
            this.dataGridView1.Location = new System.Drawing.Point(42, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ROG Fonts", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(180, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 42);
            this.label3.TabIndex = 13;
            this.label3.Text = "ALL USER";
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
            this.SigninBtn.Location = new System.Drawing.Point(774, 272);
            this.SigninBtn.Name = "SigninBtn";
            this.SigninBtn.ShadowDecoration.Parent = this.SigninBtn;
            this.SigninBtn.Size = new System.Drawing.Size(149, 45);
            this.SigninBtn.TabIndex = 28;
            this.SigninBtn.Text = "ACCEPT SIGN IN";
            this.SigninBtn.Click += new System.EventHandler(this.SigninBtn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(793, 372);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(103, 45);
            this.guna2Button1.TabIndex = 29;
            this.guna2Button1.Text = "Sign in";
            // 
            // Logo
            // 
            this.Logo.Image = global::HH.Properties.Resources.pl_icon1;
            this.Logo.Location = new System.Drawing.Point(774, 12);
            this.Logo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(176, 166);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo.TabIndex = 14;
            this.Logo.TabStop = false;
            // 
            // user
            // 
            this.user.DataPropertyName = "USERNAME";
            this.user.HeaderText = "User Name";
            this.user.Name = "user";
            this.user.Width = 150;
            // 
            // pass
            // 
            this.pass.DataPropertyName = "PASS";
            this.pass.HeaderText = "PassWord";
            this.pass.Name = "pass";
            this.pass.Width = 150;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.Width = 150;
            // 
            // point
            // 
            this.point.HeaderText = "Point";
            this.point.Name = "point";
            this.point.Width = 150;
            // 
            // all_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(965, 445);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.SigninBtn);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "all_user";
            this.Text = "all_user";
            this.Load += new System.EventHandler(this.all_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Logo;
        private Guna.UI2.WinForms.Guna2Button SigninBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn point;
    }
}