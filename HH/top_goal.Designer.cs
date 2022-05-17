
namespace HH
{
    partial class top_goal
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.topPl = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.plid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clbid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plid,
            this.clbid,
            this.plname,
            this.nation,
            this.day,
            this.vitri,
            this.score});
            this.dataGridView1.Location = new System.Drawing.Point(127, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 377);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(272, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "TOP GOAL IN LEAGUE";
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderRadius = 13;
            this.guna2Button4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
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
            this.guna2Button4.Location = new System.Drawing.Point(782, 507);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(180, 45);
            this.guna2Button4.TabIndex = 4;
            this.guna2Button4.Text = "exit";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // topPl
            // 
            this.topPl.BorderColor = System.Drawing.Color.Lime;
            this.topPl.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.topPl.BorderThickness = 3;
            this.topPl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.topPl.DefaultText = "";
            this.topPl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.topPl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.topPl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.topPl.DisabledState.Parent = this.topPl;
            this.topPl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.topPl.FillColor = System.Drawing.Color.LightSeaGreen;
            this.topPl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.topPl.FocusedState.Parent = this.topPl;
            this.topPl.Font = new System.Drawing.Font("ROG Fonts", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPl.ForeColor = System.Drawing.Color.Black;
            this.topPl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.topPl.HoverState.Parent = this.topPl;
            this.topPl.Location = new System.Drawing.Point(279, 494);
            this.topPl.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.topPl.Name = "topPl";
            this.topPl.PasswordChar = '\0';
            this.topPl.PlaceholderText = "";
            this.topPl.SelectedText = "";
            this.topPl.ShadowDecoration.Parent = this.topPl;
            this.topPl.Size = new System.Drawing.Size(212, 58);
            this.topPl.TabIndex = 13;
            this.topPl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ROG Fonts", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(80, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "top goal";
            // 
            // plid
            // 
            this.plid.DataPropertyName = "PLID";
            this.plid.HeaderText = "Player ID";
            this.plid.Name = "plid";
            // 
            // clbid
            // 
            this.clbid.DataPropertyName = "CLBID";
            this.clbid.HeaderText = "Club ID";
            this.clbid.Name = "clbid";
            // 
            // plname
            // 
            this.plname.DataPropertyName = "PLNAME";
            this.plname.HeaderText = "Player Name";
            this.plname.Name = "plname";
            // 
            // nation
            // 
            this.nation.DataPropertyName = "NATIONALITY";
            this.nation.HeaderText = "Nationality";
            this.nation.Name = "nation";
            // 
            // day
            // 
            this.day.DataPropertyName = "DAY_BORN";
            this.day.HeaderText = "Day Born";
            this.day.Name = "day";
            // 
            // vitri
            // 
            this.vitri.HeaderText = "Vitri";
            this.vitri.Name = "vitri";
            // 
            // score
            // 
            this.score.DataPropertyName = "SCORE";
            this.score.HeaderText = "Score";
            this.score.Name = "score";
            // 
            // top_goal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1001, 587);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.topPl);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "top_goal";
            this.Text = "top_goal";
            this.Load += new System.EventHandler(this.top_goal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2TextBox topPl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn plid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clbid;
        private System.Windows.Forms.DataGridViewTextBoxColumn plname;
        private System.Windows.Forms.DataGridViewTextBoxColumn nation;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitri;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
    }
}