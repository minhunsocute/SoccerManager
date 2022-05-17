
namespace HH
{
    partial class insert_result
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
            this.datagridview11 = new System.Windows.Forms.DataGridView();
            this.matchid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.club1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.club2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clb1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.sc1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.sc2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.clb2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.datetine = new Guna.UI2.WinForms.Guna2TextBox();
            this.staydum = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchhString = new Guna.UI2.WinForms.Guna2TextBox();
            this.Searchh = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.exit_button = new Guna.UI2.WinForms.Guna2Button();
            this.add_score = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.matID = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(159, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "choose match to change result";
            // 
            // datagridview11
            // 
            this.datagridview11.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.datagridview11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview11.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matchid,
            this.club1,
            this.score1,
            this.score2,
            this.club2,
            this.stay,
            this.date});
            this.datagridview11.Location = new System.Drawing.Point(96, 70);
            this.datagridview11.Name = "datagridview11";
            this.datagridview11.Size = new System.Drawing.Size(793, 183);
            this.datagridview11.TabIndex = 2;
            this.datagridview11.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.datagridview11.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview11_RowEnter);
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
            // clb1
            // 
            this.clb1.BorderColor = System.Drawing.Color.Teal;
            this.clb1.BorderRadius = 13;
            this.clb1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.clb1.BorderThickness = 3;
            this.clb1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clb1.DefaultText = "";
            this.clb1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.clb1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.clb1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clb1.DisabledState.Parent = this.clb1;
            this.clb1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clb1.FillColor = System.Drawing.Color.Aquamarine;
            this.clb1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clb1.FocusedState.Parent = this.clb1;
            this.clb1.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb1.ForeColor = System.Drawing.Color.Black;
            this.clb1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clb1.HoverState.Parent = this.clb1;
            this.clb1.Location = new System.Drawing.Point(165, 362);
            this.clb1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.clb1.Name = "clb1";
            this.clb1.PasswordChar = '\0';
            this.clb1.PlaceholderText = "";
            this.clb1.SelectedText = "";
            this.clb1.ShadowDecoration.Parent = this.clb1;
            this.clb1.Size = new System.Drawing.Size(200, 36);
            this.clb1.TabIndex = 3;
            this.clb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sc1
            // 
            this.sc1.BorderColor = System.Drawing.Color.Teal;
            this.sc1.BorderRadius = 13;
            this.sc1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.sc1.BorderThickness = 3;
            this.sc1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sc1.DefaultText = "";
            this.sc1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sc1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sc1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sc1.DisabledState.Parent = this.sc1;
            this.sc1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sc1.FillColor = System.Drawing.Color.Aquamarine;
            this.sc1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sc1.FocusedState.Parent = this.sc1;
            this.sc1.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sc1.ForeColor = System.Drawing.Color.Black;
            this.sc1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sc1.HoverState.Parent = this.sc1;
            this.sc1.Location = new System.Drawing.Point(387, 362);
            this.sc1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.sc1.Name = "sc1";
            this.sc1.PasswordChar = '\0';
            this.sc1.PlaceholderText = "";
            this.sc1.SelectedText = "";
            this.sc1.ShadowDecoration.Parent = this.sc1;
            this.sc1.Size = new System.Drawing.Size(56, 36);
            this.sc1.TabIndex = 4;
            this.sc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sc2
            // 
            this.sc2.BorderColor = System.Drawing.Color.Teal;
            this.sc2.BorderRadius = 13;
            this.sc2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.sc2.BorderThickness = 3;
            this.sc2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sc2.DefaultText = "";
            this.sc2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sc2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sc2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sc2.DisabledState.Parent = this.sc2;
            this.sc2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sc2.FillColor = System.Drawing.Color.Aquamarine;
            this.sc2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sc2.FocusedState.Parent = this.sc2;
            this.sc2.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sc2.ForeColor = System.Drawing.Color.Black;
            this.sc2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sc2.HoverState.Parent = this.sc2;
            this.sc2.Location = new System.Drawing.Point(489, 362);
            this.sc2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.sc2.Name = "sc2";
            this.sc2.PasswordChar = '\0';
            this.sc2.PlaceholderText = "";
            this.sc2.SelectedText = "";
            this.sc2.ShadowDecoration.Parent = this.sc2;
            this.sc2.Size = new System.Drawing.Size(56, 36);
            this.sc2.TabIndex = 5;
            this.sc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clb2
            // 
            this.clb2.BorderColor = System.Drawing.Color.Teal;
            this.clb2.BorderRadius = 13;
            this.clb2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.clb2.BorderThickness = 3;
            this.clb2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clb2.DefaultText = "";
            this.clb2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.clb2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.clb2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clb2.DisabledState.Parent = this.clb2;
            this.clb2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clb2.FillColor = System.Drawing.Color.Aquamarine;
            this.clb2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clb2.FocusedState.Parent = this.clb2;
            this.clb2.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb2.ForeColor = System.Drawing.Color.Black;
            this.clb2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clb2.HoverState.Parent = this.clb2;
            this.clb2.Location = new System.Drawing.Point(579, 362);
            this.clb2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.clb2.Name = "clb2";
            this.clb2.PasswordChar = '\0';
            this.clb2.PlaceholderText = "";
            this.clb2.SelectedText = "";
            this.clb2.ShadowDecoration.Parent = this.clb2;
            this.clb2.Size = new System.Drawing.Size(200, 36);
            this.clb2.TabIndex = 6;
            this.clb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // datetine
            // 
            this.datetine.BorderColor = System.Drawing.Color.Teal;
            this.datetine.BorderRadius = 13;
            this.datetine.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.datetine.BorderThickness = 3;
            this.datetine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.datetine.DefaultText = "";
            this.datetine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.datetine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.datetine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.datetine.DisabledState.Parent = this.datetine;
            this.datetine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.datetine.FillColor = System.Drawing.Color.Aquamarine;
            this.datetine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.datetine.FocusedState.Parent = this.datetine;
            this.datetine.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetine.ForeColor = System.Drawing.Color.Black;
            this.datetine.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.datetine.HoverState.Parent = this.datetine;
            this.datetine.Location = new System.Drawing.Point(212, 444);
            this.datetine.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.datetine.Name = "datetine";
            this.datetine.PasswordChar = '\0';
            this.datetine.PlaceholderText = "";
            this.datetine.SelectedText = "";
            this.datetine.ShadowDecoration.Parent = this.datetine;
            this.datetine.Size = new System.Drawing.Size(231, 36);
            this.datetine.TabIndex = 7;
            this.datetine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // staydum
            // 
            this.staydum.BorderColor = System.Drawing.Color.Teal;
            this.staydum.BorderRadius = 13;
            this.staydum.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.staydum.BorderThickness = 3;
            this.staydum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.staydum.DefaultText = "";
            this.staydum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.staydum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.staydum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staydum.DisabledState.Parent = this.staydum;
            this.staydum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staydum.FillColor = System.Drawing.Color.Aquamarine;
            this.staydum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staydum.FocusedState.Parent = this.staydum;
            this.staydum.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staydum.ForeColor = System.Drawing.Color.Black;
            this.staydum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staydum.HoverState.Parent = this.staydum;
            this.staydum.Location = new System.Drawing.Point(489, 444);
            this.staydum.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.staydum.Name = "staydum";
            this.staydum.PasswordChar = '\0';
            this.staydum.PlaceholderText = "";
            this.staydum.SelectedText = "";
            this.staydum.ShadowDecoration.Parent = this.staydum;
            this.staydum.Size = new System.Drawing.Size(187, 36);
            this.staydum.TabIndex = 8;
            this.staydum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchhString
            // 
            this.searchhString.BorderColor = System.Drawing.Color.Teal;
            this.searchhString.BorderRadius = 13;
            this.searchhString.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.searchhString.BorderThickness = 3;
            this.searchhString.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchhString.DefaultText = "";
            this.searchhString.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchhString.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchhString.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchhString.DisabledState.Parent = this.searchhString;
            this.searchhString.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchhString.FillColor = System.Drawing.Color.Aquamarine;
            this.searchhString.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchhString.FocusedState.Parent = this.searchhString;
            this.searchhString.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchhString.ForeColor = System.Drawing.Color.Black;
            this.searchhString.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchhString.HoverState.Parent = this.searchhString;
            this.searchhString.Location = new System.Drawing.Point(294, 270);
            this.searchhString.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.searchhString.Name = "searchhString";
            this.searchhString.PasswordChar = '\0';
            this.searchhString.PlaceholderText = "";
            this.searchhString.SelectedText = "";
            this.searchhString.ShadowDecoration.Parent = this.searchhString;
            this.searchhString.Size = new System.Drawing.Size(168, 36);
            this.searchhString.TabIndex = 9;
            this.searchhString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Searchh
            // 
            this.Searchh.BorderRadius = 13;
            this.Searchh.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.Searchh.CheckedState.Parent = this.Searchh;
            this.Searchh.CustomImages.Parent = this.Searchh;
            this.Searchh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Searchh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Searchh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Searchh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Searchh.DisabledState.Parent = this.Searchh;
            this.Searchh.FillColor = System.Drawing.Color.SeaGreen;
            this.Searchh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Searchh.ForeColor = System.Drawing.Color.White;
            this.Searchh.HoverState.Parent = this.Searchh;
            this.Searchh.Location = new System.Drawing.Point(489, 285);
            this.Searchh.Name = "Searchh";
            this.Searchh.ShadowDecoration.Parent = this.Searchh;
            this.Searchh.Size = new System.Drawing.Size(93, 21);
            this.Searchh.TabIndex = 10;
            this.Searchh.Text = "Search";
            this.Searchh.Click += new System.EventHandler(this.Searchh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(161, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "CLUB 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(383, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "SC 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(485, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "SC 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(575, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "CLUB 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(221, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "DATE TIME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(494, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "STAYDIUM";
            // 
            // exit_button
            // 
            this.exit_button.BorderRadius = 13;
            this.exit_button.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.exit_button.BorderThickness = 3;
            this.exit_button.CheckedState.Parent = this.exit_button;
            this.exit_button.CustomImages.Parent = this.exit_button;
            this.exit_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exit_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exit_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exit_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exit_button.DisabledState.Parent = this.exit_button;
            this.exit_button.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.HoverState.Parent = this.exit_button;
            this.exit_button.Location = new System.Drawing.Point(760, 516);
            this.exit_button.Name = "exit_button";
            this.exit_button.ShadowDecoration.Parent = this.exit_button;
            this.exit_button.Size = new System.Drawing.Size(180, 45);
            this.exit_button.TabIndex = 17;
            this.exit_button.Text = "exit ";
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // add_score
            // 
            this.add_score.BorderRadius = 13;
            this.add_score.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.add_score.BorderThickness = 3;
            this.add_score.CheckedState.Parent = this.add_score;
            this.add_score.CustomImages.Parent = this.add_score;
            this.add_score.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_score.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_score.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_score.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_score.DisabledState.Parent = this.add_score;
            this.add_score.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_score.ForeColor = System.Drawing.Color.White;
            this.add_score.HoverState.Parent = this.add_score;
            this.add_score.Location = new System.Drawing.Point(377, 516);
            this.add_score.Name = "add_score";
            this.add_score.ShadowDecoration.Parent = this.add_score;
            this.add_score.Size = new System.Drawing.Size(180, 45);
            this.add_score.TabIndex = 18;
            this.add_score.Text = "add score";
            this.add_score.Click += new System.EventHandler(this.add_score_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("ROG Fonts", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(459, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = ":";
            // 
            // matID
            // 
            this.matID.BorderColor = System.Drawing.Color.Teal;
            this.matID.BorderRadius = 13;
            this.matID.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.matID.BorderThickness = 3;
            this.matID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.matID.DefaultText = "";
            this.matID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.matID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.matID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.matID.DisabledState.Parent = this.matID;
            this.matID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.matID.FillColor = System.Drawing.Color.Aquamarine;
            this.matID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.matID.FocusedState.Parent = this.matID;
            this.matID.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matID.ForeColor = System.Drawing.Color.Black;
            this.matID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.matID.HoverState.Parent = this.matID;
            this.matID.Location = new System.Drawing.Point(48, 362);
            this.matID.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.matID.Name = "matID";
            this.matID.PasswordChar = '\0';
            this.matID.PlaceholderText = "";
            this.matID.SelectedText = "";
            this.matID.ShadowDecoration.Parent = this.matID;
            this.matID.Size = new System.Drawing.Size(93, 36);
            this.matID.TabIndex = 20;
            this.matID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // insert_result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1001, 587);
            this.Controls.Add(this.matID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.add_score);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Searchh);
            this.Controls.Add(this.searchhString);
            this.Controls.Add(this.staydum);
            this.Controls.Add(this.datetine);
            this.Controls.Add(this.clb2);
            this.Controls.Add(this.sc2);
            this.Controls.Add(this.sc1);
            this.Controls.Add(this.clb1);
            this.Controls.Add(this.datagridview11);
            this.Controls.Add(this.label1);
            this.Name = "insert_result";
            this.Text = "a";
            this.LocationChanged += new System.EventHandler(this.insert_result_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridview11;
        private Guna.UI2.WinForms.Guna2TextBox clb1;
        private Guna.UI2.WinForms.Guna2TextBox sc1;
        private Guna.UI2.WinForms.Guna2TextBox sc2;
        private Guna.UI2.WinForms.Guna2TextBox clb2;
        private Guna.UI2.WinForms.Guna2TextBox datetine;
        private Guna.UI2.WinForms.Guna2TextBox staydum;
        private Guna.UI2.WinForms.Guna2TextBox searchhString;
        private Guna.UI2.WinForms.Guna2Button Searchh;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchid;
        private System.Windows.Forms.DataGridViewTextBoxColumn club1;
        private System.Windows.Forms.DataGridViewTextBoxColumn score1;
        private System.Windows.Forms.DataGridViewTextBoxColumn score2;
        private System.Windows.Forms.DataGridViewTextBoxColumn club2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stay;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button exit_button;
        private Guna.UI2.WinForms.Guna2Button add_score;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox matID;
    }
}