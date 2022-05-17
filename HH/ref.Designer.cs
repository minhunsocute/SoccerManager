
namespace HH
{
    partial class @ref
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
            this.refID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insert = new Guna.UI2.WinForms.Guna2Button();
            this.delete = new Guna.UI2.WinForms.Guna2Button();
            this.update = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.add = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.search_string = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchID = new Guna.UI2.WinForms.Guna2Button();
            this.ID = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Aqua;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.refID,
            this.name,
            this.nation,
            this.day,
            this.type});
            this.dataGridView1.Location = new System.Drawing.Point(45, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(704, 399);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // refID
            // 
            this.refID.DataPropertyName = "REFID";
            this.refID.HeaderText = "References ID";
            this.refID.Name = "refID";
            // 
            // name
            // 
            this.name.DataPropertyName = "REF_NAME";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.Width = 200;
            // 
            // nation
            // 
            this.nation.DataPropertyName = "NATIONALITY";
            this.nation.HeaderText = "Nationality";
            this.nation.Name = "nation";
            this.nation.Width = 160;
            // 
            // day
            // 
            this.day.DataPropertyName = "DAY_BORN";
            this.day.HeaderText = "day born";
            this.day.Name = "day";
            // 
            // type
            // 
            this.type.HeaderText = "Type Ref";
            this.type.Name = "type";
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
            this.insert.Location = new System.Drawing.Point(775, 114);
            this.insert.Name = "insert";
            this.insert.ShadowDecoration.Parent = this.insert;
            this.insert.Size = new System.Drawing.Size(180, 45);
            this.insert.TabIndex = 5;
            this.insert.Text = "insert ref";
            this.insert.Click += new System.EventHandler(this.guna2Button4_Click);
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
            this.delete.Location = new System.Drawing.Point(775, 214);
            this.delete.Name = "delete";
            this.delete.ShadowDecoration.Parent = this.delete;
            this.delete.Size = new System.Drawing.Size(180, 45);
            this.delete.TabIndex = 6;
            this.delete.Text = "delete ref";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BorderRadius = 13;
            this.update.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.update.BorderThickness = 3;
            this.update.CheckedState.Parent = this.update;
            this.update.CustomImages.Parent = this.update;
            this.update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update.DisabledState.Parent = this.update;
            this.update.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.HoverState.Parent = this.update;
            this.update.Location = new System.Drawing.Point(775, 316);
            this.update.Name = "update";
            this.update.ShadowDecoration.Parent = this.update;
            this.update.Size = new System.Drawing.Size(180, 45);
            this.update.TabIndex = 7;
            this.update.Text = "update ref";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 13;
            this.guna2Button3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button3.BorderThickness = 3;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.DisabledState.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2Button3.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(809, 530);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(180, 45);
            this.guna2Button3.TabIndex = 8;
            this.guna2Button3.Text = "exit";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // add
            // 
            this.add.BorderRadius = 13;
            this.add.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.add.BorderThickness = 3;
            this.add.CheckedState.Parent = this.add;
            this.add.CustomImages.Parent = this.add;
            this.add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add.DisabledState.Parent = this.add;
            this.add.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.HoverState.Parent = this.add;
            this.add.Location = new System.Drawing.Point(775, 425);
            this.add.Name = "add";
            this.add.ShadowDecoration.Parent = this.add;
            this.add.Size = new System.Drawing.Size(180, 45);
            this.add.TabIndex = 9;
            this.add.Text = "add match ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(105, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "referee";
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
            this.search_string.Location = new System.Drawing.Point(455, 33);
            this.search_string.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.search_string.Name = "search_string";
            this.search_string.PasswordChar = '\0';
            this.search_string.PlaceholderText = "";
            this.search_string.SelectedText = "";
            this.search_string.ShadowDecoration.Parent = this.search_string;
            this.search_string.Size = new System.Drawing.Size(145, 34);
            this.search_string.TabIndex = 14;
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
            this.searchID.Location = new System.Drawing.Point(643, 40);
            this.searchID.Name = "searchID";
            this.searchID.ShadowDecoration.Parent = this.searchID;
            this.searchID.Size = new System.Drawing.Size(106, 27);
            this.searchID.TabIndex = 15;
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
            this.ID.Location = new System.Drawing.Point(100, 506);
            this.ID.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.ID.Name = "ID";
            this.ID.PasswordChar = '\0';
            this.ID.PlaceholderText = "";
            this.ID.SelectedText = "";
            this.ID.ShadowDecoration.Parent = this.ID;
            this.ID.Size = new System.Drawing.Size(152, 44);
            this.ID.TabIndex = 16;
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // @ref
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1001, 587);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.searchID);
            this.Controls.Add(this.search_string);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "@ref";
            this.Text = "@ref";
            this.Load += new System.EventHandler(this.ref_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button insert;
        private Guna.UI2.WinForms.Guna2Button delete;
        private Guna.UI2.WinForms.Guna2Button update;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button add;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox search_string;
        private Guna.UI2.WinForms.Guna2Button searchID;
        private Guna.UI2.WinForms.Guna2TextBox ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn refID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn nation;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
    }
}