
namespace HH
{
    partial class accept_user
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
            this.searchText = new Guna.UI2.WinForms.Guna2TextBox();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Turquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user,
            this.pass,
            this.email});
            this.dataGridView1.Location = new System.Drawing.Point(29, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 258);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ROG Fonts", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(80, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 42);
            this.label3.TabIndex = 14;
            this.label3.Text = "ACCEPT  USER";
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
            this.SigninBtn.Location = new System.Drawing.Point(626, 264);
            this.SigninBtn.Name = "SigninBtn";
            this.SigninBtn.ShadowDecoration.Parent = this.SigninBtn;
            this.SigninBtn.Size = new System.Drawing.Size(149, 45);
            this.SigninBtn.TabIndex = 29;
            this.SigninBtn.Text = "ACCEPT SIGN IN";
            this.SigninBtn.Click += new System.EventHandler(this.SigninBtn_Click);
            // 
            // searchText
            // 
            this.searchText.BorderColor = System.Drawing.Color.SeaGreen;
            this.searchText.BorderRadius = 13;
            this.searchText.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.searchText.BorderThickness = 3;
            this.searchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchText.DefaultText = "";
            this.searchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchText.DisabledState.Parent = this.searchText;
            this.searchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchText.FillColor = System.Drawing.Color.PaleTurquoise;
            this.searchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchText.FocusedState.Parent = this.searchText;
            this.searchText.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.ForeColor = System.Drawing.Color.Black;
            this.searchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchText.HoverState.Parent = this.searchText;
            this.searchText.Location = new System.Drawing.Point(624, 205);
            this.searchText.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.searchText.Name = "searchText";
            this.searchText.PasswordChar = '\0';
            this.searchText.PlaceholderText = "";
            this.searchText.SelectedText = "";
            this.searchText.ShadowDecoration.Parent = this.searchText;
            this.searchText.Size = new System.Drawing.Size(149, 38);
            this.searchText.TabIndex = 30;
            this.searchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.pass.Width = 190;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.Width = 200;
            // 
            // accept_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(787, 407);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.SigninBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "accept_user";
            this.Text = "accept_user";
            this.Load += new System.EventHandler(this.accept_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button SigninBtn;
        private Guna.UI2.WinForms.Guna2TextBox searchText;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}