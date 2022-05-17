
namespace HH
{
    partial class all_player
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchText = new Guna.UI2.WinForms.Guna2TextBox();
            this.search = new Guna.UI2.WinForms.Guna2Button();
            this.plid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day_born = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yellowCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.redCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(44, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plid,
            this.plname,
            this.nation,
            this.day_born,
            this.location,
            this.score,
            this.yellowCard,
            this.redCard});
            this.dataGridView1.Location = new System.Drawing.Point(92, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 353);
            this.dataGridView1.TabIndex = 1;
            // 
            // searchText
            // 
            this.searchText.BorderColor = System.Drawing.Color.DarkGreen;
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
            this.searchText.FillColor = System.Drawing.SystemColors.ScrollBar;
            this.searchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchText.FocusedState.Parent = this.searchText;
            this.searchText.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.ForeColor = System.Drawing.Color.Black;
            this.searchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchText.HoverState.Parent = this.searchText;
            this.searchText.Location = new System.Drawing.Point(657, 50);
            this.searchText.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.searchText.Name = "searchText";
            this.searchText.PasswordChar = '\0';
            this.searchText.PlaceholderForeColor = System.Drawing.Color.Black;
            this.searchText.PlaceholderText = "";
            this.searchText.SelectedText = "";
            this.searchText.ShadowDecoration.Parent = this.searchText;
            this.searchText.Size = new System.Drawing.Size(154, 38);
            this.searchText.TabIndex = 2;
            this.searchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // search
            // 
            this.search.BorderRadius = 13;
            this.search.CheckedState.Parent = this.search;
            this.search.CustomImages.Parent = this.search;
            this.search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.search.DisabledState.Parent = this.search;
            this.search.FillColor = System.Drawing.Color.SeaGreen;
            this.search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.HoverState.Parent = this.search;
            this.search.Location = new System.Drawing.Point(843, 65);
            this.search.Name = "search";
            this.search.ShadowDecoration.Parent = this.search;
            this.search.Size = new System.Drawing.Size(93, 23);
            this.search.TabIndex = 3;
            this.search.Text = "SEARCH";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // plid
            // 
            this.plid.DataPropertyName = "PLID";
            this.plid.HeaderText = "PLAYER ID";
            this.plid.Name = "plid";
            // 
            // plname
            // 
            this.plname.DataPropertyName = "PLNAME";
            this.plname.HeaderText = "name";
            this.plname.Name = "plname";
            // 
            // nation
            // 
            this.nation.DataPropertyName = "NATIONALITY";
            this.nation.HeaderText = "Nationality";
            this.nation.Name = "nation";
            // 
            // day_born
            // 
            this.day_born.DataPropertyName = "DAY_BORN";
            this.day_born.HeaderText = "Day born";
            this.day_born.Name = "day_born";
            // 
            // location
            // 
            this.location.DataPropertyName = "VITRI";
            this.location.HeaderText = "Location";
            this.location.Name = "location";
            // 
            // score
            // 
            this.score.DataPropertyName = "SCORE";
            this.score.HeaderText = "Score";
            this.score.Name = "score";
            // 
            // yellowCard
            // 
            this.yellowCard.DataPropertyName = "YELLOWCARD";
            this.yellowCard.HeaderText = "Yellow Card";
            this.yellowCard.Name = "yellowCard";
            // 
            // redCard
            // 
            this.redCard.DataPropertyName = "REDCARD";
            this.redCard.HeaderText = "Red Card";
            this.redCard.Name = "redCard";
            // 
            // all_player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1018, 556);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "all_player";
            this.Text = "all_player";
            this.Load += new System.EventHandler(this.all_player_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox searchText;
        private Guna.UI2.WinForms.Guna2Button search;
        private System.Windows.Forms.DataGridViewTextBoxColumn plid;
        private System.Windows.Forms.DataGridViewTextBoxColumn plname;
        private System.Windows.Forms.DataGridViewTextBoxColumn nation;
        private System.Windows.Forms.DataGridViewTextBoxColumn day_born;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.DataGridViewTextBoxColumn yellowCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn redCard;
    }
}