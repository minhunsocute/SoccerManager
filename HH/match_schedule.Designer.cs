
namespace HH
{
    partial class match_schedule
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
            this.label1 = new System.Windows.Forms.Label();
            this.add_match1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matchid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.club1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.club2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(173, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "match schedule";
            // 
            // add_match1
            // 
            this.add_match1.BorderRadius = 13;
            this.add_match1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.add_match1.BorderThickness = 3;
            this.add_match1.CheckedState.Parent = this.add_match1;
            this.add_match1.CustomImages.Parent = this.add_match1;
            this.add_match1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_match1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_match1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_match1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_match1.DisabledState.Parent = this.add_match1;
            this.add_match1.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_match1.ForeColor = System.Drawing.Color.White;
            this.add_match1.HoverState.Parent = this.add_match1;
            this.add_match1.Location = new System.Drawing.Point(104, 517);
            this.add_match1.Name = "add_match1";
            this.add_match1.ShadowDecoration.Parent = this.add_match1;
            this.add_match1.Size = new System.Drawing.Size(180, 45);
            this.add_match1.TabIndex = 2;
            this.add_match1.Text = "add match";
            this.add_match1.Click += new System.EventHandler(this.add_match1_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 13;
            this.guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button1.BorderThickness = 3;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2Button1.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(717, 517);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "exit";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matchid,
            this.club1,
            this.score1,
            this.score2,
            this.club2,
            this.stay,
            this.date});
            this.dataGridView1.Location = new System.Drawing.Point(104, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(793, 406);
            this.dataGridView1.TabIndex = 4;
            // 
            // matchid
            // 
            this.matchid.DataPropertyName = "MATCHID";
            this.matchid.HeaderText = "Match ID";
            this.matchid.Name = "matchid";
            // 
            // club1
            // 
            this.club1.DataPropertyName = "CLB1";
            this.club1.HeaderText = "CLUB 1";
            this.club1.Name = "club1";
            // 
            // score1
            // 
            this.score1.DataPropertyName = "SCORED1";
            this.score1.HeaderText = "SCORE 1";
            this.score1.Name = "score1";
            // 
            // score2
            // 
            this.score2.DataPropertyName = "SCORED2";
            this.score2.HeaderText = "SCORE 2";
            this.score2.Name = "score2";
            // 
            // club2
            // 
            this.club2.DataPropertyName = "CLB2";
            this.club2.HeaderText = "CLUB 2";
            this.club2.Name = "club2";
            // 
            // stay
            // 
            this.stay.DataPropertyName = "STAYDIUM";
            this.stay.HeaderText = "Staydium";
            this.stay.Name = "stay";
            this.stay.Width = 150;
            // 
            // date
            // 
            this.date.DataPropertyName = "DATE_TIME";
            this.date.HeaderText = "Datetime";
            this.date.Name = "date";
            // 
            // match_schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1001, 587);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.add_match1);
            this.Controls.Add(this.label1);
            this.Name = "match_schedule";
            this.Text = "match_schedule";
            this.Load += new System.EventHandler(this.match_schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button add_match1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchid;
        private System.Windows.Forms.DataGridViewTextBoxColumn club1;
        private System.Windows.Forms.DataGridViewTextBoxColumn score1;
        private System.Windows.Forms.DataGridViewTextBoxColumn score2;
        private System.Windows.Forms.DataGridViewTextBoxColumn club2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stay;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}