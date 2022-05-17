
namespace HH
{
    partial class allPlayer
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
            this.clbid = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchButton = new Guna.UI2.WinForms.Guna2Button();
            this.insertPlayer = new Guna.UI2.WinForms.Guna2Button();
            this.delete_player = new Guna.UI2.WinForms.Guna2Button();
            this.Update = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.searchString = new Guna.UI2.WinForms.Guna2TextBox();
            this.plid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day_born = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yellow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.red = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // clbid
            // 
            this.clbid.AutoSize = true;
            this.clbid.Font = new System.Drawing.Font("ROG Fonts", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbid.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clbid.Location = new System.Drawing.Point(27, 40);
            this.clbid.Name = "clbid";
            this.clbid.Size = new System.Drawing.Size(161, 38);
            this.clbid.TabIndex = 0;
            this.clbid.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plid,
            this.name,
            this.nation,
            this.day_born,
            this.vitri,
            this.score,
            this.Yellow,
            this.red});
            this.dataGridView1.Location = new System.Drawing.Point(85, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 395);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // searchButton
            // 
            this.searchButton.BorderRadius = 13;
            this.searchButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.searchButton.CheckedState.Parent = this.searchButton;
            this.searchButton.CustomImages.Parent = this.searchButton;
            this.searchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchButton.DisabledState.Parent = this.searchButton;
            this.searchButton.FillColor = System.Drawing.Color.SeaGreen;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.HoverState.Parent = this.searchButton;
            this.searchButton.Location = new System.Drawing.Point(793, 40);
            this.searchButton.Name = "searchButton";
            this.searchButton.ShadowDecoration.Parent = this.searchButton;
            this.searchButton.Size = new System.Drawing.Size(137, 38);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "SEARCH";
            this.searchButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.searchButton.Click += new System.EventHandler(this.searchClick);
            // 
            // insertPlayer
            // 
            this.insertPlayer.CheckedState.Parent = this.insertPlayer;
            this.insertPlayer.CustomImages.Parent = this.insertPlayer;
            this.insertPlayer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.insertPlayer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.insertPlayer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.insertPlayer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.insertPlayer.DisabledState.Parent = this.insertPlayer;
            this.insertPlayer.Font = new System.Drawing.Font("ROG Fonts", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertPlayer.ForeColor = System.Drawing.Color.White;
            this.insertPlayer.HoverState.Parent = this.insertPlayer;
            this.insertPlayer.Location = new System.Drawing.Point(52, 517);
            this.insertPlayer.Name = "insertPlayer";
            this.insertPlayer.ShadowDecoration.Parent = this.insertPlayer;
            this.insertPlayer.Size = new System.Drawing.Size(180, 45);
            this.insertPlayer.TabIndex = 3;
            this.insertPlayer.Text = "INSERT PL";
            this.insertPlayer.Click += new System.EventHandler(this.insertPlayer_Click);
            // 
            // delete_player
            // 
            this.delete_player.CheckedState.Parent = this.delete_player;
            this.delete_player.CustomImages.Parent = this.delete_player;
            this.delete_player.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete_player.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete_player.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete_player.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete_player.DisabledState.Parent = this.delete_player;
            this.delete_player.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_player.ForeColor = System.Drawing.Color.White;
            this.delete_player.HoverState.Parent = this.delete_player;
            this.delete_player.Location = new System.Drawing.Point(294, 517);
            this.delete_player.Name = "delete_player";
            this.delete_player.ShadowDecoration.Parent = this.delete_player;
            this.delete_player.Size = new System.Drawing.Size(180, 45);
            this.delete_player.TabIndex = 4;
            this.delete_player.Text = "Delete player";
            this.delete_player.Click += new System.EventHandler(this.delete_player_Click);
            // 
            // Update
            // 
            this.Update.CheckedState.Parent = this.Update;
            this.Update.CustomImages.Parent = this.Update;
            this.Update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Update.DisabledState.Parent = this.Update;
            this.Update.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.HoverState.Parent = this.Update;
            this.Update.Location = new System.Drawing.Point(539, 517);
            this.Update.Name = "Update";
            this.Update.ShadowDecoration.Parent = this.Update;
            this.Update.Size = new System.Drawing.Size(180, 45);
            this.Update.TabIndex = 5;
            this.Update.Text = "UPDATE";
            // 
            // guna2Button5
            // 
            this.guna2Button5.BorderRadius = 13;
            this.guna2Button5.CheckedState.Parent = this.guna2Button5;
            this.guna2Button5.CustomImages.Parent = this.guna2Button5;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.DisabledState.Parent = this.guna2Button5;
            this.guna2Button5.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.Parent = this.guna2Button5;
            this.guna2Button5.Location = new System.Drawing.Point(813, 528);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.ShadowDecoration.Parent = this.guna2Button5;
            this.guna2Button5.Size = new System.Drawing.Size(140, 34);
            this.guna2Button5.TabIndex = 6;
            this.guna2Button5.Text = "EXIT";
            this.guna2Button5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // searchString
            // 
            this.searchString.BorderColor = System.Drawing.Color.Lime;
            this.searchString.BorderRadius = 13;
            this.searchString.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.searchString.BorderThickness = 3;
            this.searchString.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchString.DefaultText = "";
            this.searchString.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchString.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchString.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchString.DisabledState.Parent = this.searchString;
            this.searchString.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchString.FillColor = System.Drawing.Color.SteelBlue;
            this.searchString.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchString.FocusedState.Parent = this.searchString;
            this.searchString.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchString.ForeColor = System.Drawing.Color.Black;
            this.searchString.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchString.HoverState.Parent = this.searchString;
            this.searchString.Location = new System.Drawing.Point(539, 35);
            this.searchString.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.searchString.Name = "searchString";
            this.searchString.PasswordChar = '\0';
            this.searchString.PlaceholderForeColor = System.Drawing.Color.Black;
            this.searchString.PlaceholderText = "";
            this.searchString.SelectedText = "";
            this.searchString.ShadowDecoration.Parent = this.searchString;
            this.searchString.Size = new System.Drawing.Size(200, 48);
            this.searchString.TabIndex = 7;
            this.searchString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plid
            // 
            this.plid.DataPropertyName = "PLID";
            this.plid.HeaderText = "Player ID";
            this.plid.Name = "plid";
            // 
            // name
            // 
            this.name.DataPropertyName = "PLNAME";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // nation
            // 
            this.nation.DataPropertyName = "NATIONALITY";
            this.nation.HeaderText = "nationality";
            this.nation.Name = "nation";
            // 
            // day_born
            // 
            this.day_born.DataPropertyName = "DAY_BORN";
            this.day_born.HeaderText = "Day Born";
            this.day_born.Name = "day_born";
            // 
            // vitri
            // 
            this.vitri.HeaderText = "vi tri";
            this.vitri.Name = "vitri";
            // 
            // score
            // 
            this.score.DataPropertyName = "SCORE";
            this.score.HeaderText = "Score";
            this.score.Name = "score";
            // 
            // Yellow
            // 
            this.Yellow.DataPropertyName = "YELLOWCARD";
            this.Yellow.HeaderText = "Yellow Card";
            this.Yellow.Name = "Yellow";
            // 
            // red
            // 
            this.red.DataPropertyName = "REDCARD";
            this.red.HeaderText = "Red Card";
            this.red.Name = "red";
            // 
            // allPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1001, 587);
            this.Controls.Add(this.searchString);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.delete_player);
            this.Controls.Add(this.insertPlayer);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clbid);
            this.Name = "allPlayer";
            this.Text = "allPlayer";
            this.Load += new System.EventHandler(this.allPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clbid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button searchButton;
        private Guna.UI2.WinForms.Guna2Button insertPlayer;
        private Guna.UI2.WinForms.Guna2Button delete_player;
        private Guna.UI2.WinForms.Guna2Button Update;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2TextBox searchString;
        private System.Windows.Forms.DataGridViewTextBoxColumn plid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn nation;
        private System.Windows.Forms.DataGridViewTextBoxColumn day_born;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitri;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yellow;
        private System.Windows.Forms.DataGridViewTextBoxColumn red;
    }
}