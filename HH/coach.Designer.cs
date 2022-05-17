
namespace HH
{
    partial class coach
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
            this.coachid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.insert = new Guna.UI2.WinForms.Guna2Button();
            this.delete = new Guna.UI2.WinForms.Guna2Button();
            this.search_string = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchID = new Guna.UI2.WinForms.Guna2Button();
            this.ID = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Turquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coachid,
            this.day,
            this.type,
            this.name,
            this.nation});
            this.dataGridView1.Location = new System.Drawing.Point(73, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // coachid
            // 
            this.coachid.DataPropertyName = "COACHID";
            this.coachid.HeaderText = "Coach ID";
            this.coachid.Name = "coachid";
            // 
            // day
            // 
            this.day.DataPropertyName = "DAY_BORN";
            this.day.HeaderText = "Day Born";
            this.day.Name = "day";
            // 
            // type
            // 
            this.type.HeaderText = "Type Coach";
            this.type.Name = "type";
            // 
            // name
            // 
            this.name.DataPropertyName = "COACHNAME";
            this.name.HeaderText = "Coach Name";
            this.name.Name = "name";
            // 
            // nation
            // 
            this.nation.DataPropertyName = "NATIONALITY";
            this.nation.HeaderText = "Nationality";
            this.nation.Name = "nation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(131, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "COACH OF CLUB";
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderThickness = 3;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.DisabledState.Parent = this.guna2Button4;
            this.guna2Button4.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(694, 369);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(180, 45);
            this.guna2Button4.TabIndex = 5;
            this.guna2Button4.Text = "exit";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // insert
            // 
            this.insert.BorderRadius = 13;
            this.insert.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.insert.BorderThickness = 3;
            this.insert.CheckedState.Parent = this.insert;
            this.insert.CustomImages.Parent = this.insert;
            this.insert.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.insert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.insert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.insert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.insert.DisabledState.Parent = this.insert;
            this.insert.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.ForeColor = System.Drawing.Color.White;
            this.insert.HoverState.Parent = this.insert;
            this.insert.Location = new System.Drawing.Point(694, 140);
            this.insert.Name = "insert";
            this.insert.ShadowDecoration.Parent = this.insert;
            this.insert.Size = new System.Drawing.Size(180, 45);
            this.insert.TabIndex = 6;
            this.insert.Text = "insert coach";
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // delete
            // 
            this.delete.BorderRadius = 13;
            this.delete.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.delete.BorderThickness = 3;
            this.delete.CheckedState.Parent = this.delete;
            this.delete.CustomImages.Parent = this.delete;
            this.delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete.DisabledState.Parent = this.delete;
            this.delete.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.HoverState.Parent = this.delete;
            this.delete.Location = new System.Drawing.Point(694, 241);
            this.delete.Name = "delete";
            this.delete.ShadowDecoration.Parent = this.delete;
            this.delete.Size = new System.Drawing.Size(180, 45);
            this.delete.TabIndex = 7;
            this.delete.Text = "delete coach";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // search_string
            // 
            this.search_string.BorderColor = System.Drawing.Color.Lime;
            this.search_string.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.search_string.BorderThickness = 3;
            this.search_string.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_string.DefaultText = "";
            this.search_string.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_string.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_string.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_string.DisabledState.Parent = this.search_string;
            this.search_string.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_string.FillColor = System.Drawing.Color.LightSeaGreen;
            this.search_string.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_string.FocusedState.Parent = this.search_string;
            this.search_string.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_string.ForeColor = System.Drawing.Color.Black;
            this.search_string.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_string.HoverState.Parent = this.search_string;
            this.search_string.Location = new System.Drawing.Point(437, 45);
            this.search_string.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.search_string.Name = "search_string";
            this.search_string.PasswordChar = '\0';
            this.search_string.PlaceholderText = "";
            this.search_string.SelectedText = "";
            this.search_string.ShadowDecoration.Parent = this.search_string;
            this.search_string.Size = new System.Drawing.Size(145, 34);
            this.search_string.TabIndex = 15;
            this.search_string.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchID
            // 
            this.searchID.BorderRadius = 13;
            this.searchID.CheckedState.Parent = this.searchID;
            this.searchID.CustomImages.Parent = this.searchID;
            this.searchID.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchID.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchID.DisabledState.Parent = this.searchID;
            this.searchID.FillColor = System.Drawing.Color.SeaGreen;
            this.searchID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchID.ForeColor = System.Drawing.Color.White;
            this.searchID.HoverState.Parent = this.searchID;
            this.searchID.Location = new System.Drawing.Point(594, 52);
            this.searchID.Name = "searchID";
            this.searchID.ShadowDecoration.Parent = this.searchID;
            this.searchID.Size = new System.Drawing.Size(106, 27);
            this.searchID.TabIndex = 16;
            this.searchID.Text = "search";
            this.searchID.Click += new System.EventHandler(this.searchID_Click);
            // 
            // ID
            // 
            this.ID.BorderColor = System.Drawing.Color.Lime;
            this.ID.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.ID.BorderThickness = 3;
            this.ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ID.DefaultText = "";
            this.ID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ID.DisabledState.Parent = this.ID;
            this.ID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ID.FillColor = System.Drawing.Color.LightSeaGreen;
            this.ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ID.FocusedState.Parent = this.ID;
            this.ID.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.Black;
            this.ID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ID.HoverState.Parent = this.ID;
            this.ID.Location = new System.Drawing.Point(137, 369);
            this.ID.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.ID.Name = "ID";
            this.ID.PasswordChar = '\0';
            this.ID.PlaceholderText = "";
            this.ID.SelectedText = "";
            this.ID.ShadowDecoration.Parent = this.ID;
            this.ID.Size = new System.Drawing.Size(152, 44);
            this.ID.TabIndex = 17;
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // coach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(886, 426);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.searchID);
            this.Controls.Add(this.search_string);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "coach";
            this.Text = "coach";
            this.Load += new System.EventHandler(this.coach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coachid;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn nation;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button insert;
        private Guna.UI2.WinForms.Guna2Button delete;
        private Guna.UI2.WinForms.Guna2TextBox search_string;
        private Guna.UI2.WinForms.Guna2Button searchID;
        private Guna.UI2.WinForms.Guna2TextBox ID;
    }
}