
namespace HH
{
    partial class play
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.matchid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.club1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.club2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clb1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.clb2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.point = new Guna.UI2.WinForms.Guna2TextBox();
            this.score = new Guna.UI2.WinForms.Guna2TextBox();
            this.clbchoose = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pointText = new Guna.UI2.WinForms.Guna2TextBox();
            this.userText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matchid,
            this.club1,
            this.club2,
            this.stay,
            this.date});
            this.dataGridView1.Location = new System.Drawing.Point(53, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 406);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
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
            this.guna2Button1.Location = new System.Drawing.Point(809, 530);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "exit";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(166, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "match schedule";
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
            this.clb1.BorderColor = System.Drawing.Color.Black;
            this.clb1.BorderRadius = 6;
            this.clb1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.clb1.BorderThickness = 3;
            this.clb1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clb1.DefaultText = "";
            this.clb1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.clb1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.clb1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clb1.DisabledState.Parent = this.clb1;
            this.clb1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clb1.FillColor = System.Drawing.Color.LightSeaGreen;
            this.clb1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clb1.FocusedState.Parent = this.clb1;
            this.clb1.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb1.ForeColor = System.Drawing.Color.Black;
            this.clb1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clb1.HoverState.Parent = this.clb1;
            this.clb1.Location = new System.Drawing.Point(665, 173);
            this.clb1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.clb1.Name = "clb1";
            this.clb1.PasswordChar = '\0';
            this.clb1.PlaceholderText = "";
            this.clb1.SelectedText = "";
            this.clb1.ShadowDecoration.Parent = this.clb1;
            this.clb1.Size = new System.Drawing.Size(124, 38);
            this.clb1.TabIndex = 16;
            this.clb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clb2
            // 
            this.clb2.BorderColor = System.Drawing.Color.Black;
            this.clb2.BorderRadius = 6;
            this.clb2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.clb2.BorderThickness = 3;
            this.clb2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clb2.DefaultText = "";
            this.clb2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.clb2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.clb2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clb2.DisabledState.Parent = this.clb2;
            this.clb2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clb2.FillColor = System.Drawing.Color.LightSeaGreen;
            this.clb2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clb2.FocusedState.Parent = this.clb2;
            this.clb2.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb2.ForeColor = System.Drawing.Color.Black;
            this.clb2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clb2.HoverState.Parent = this.clb2;
            this.clb2.Location = new System.Drawing.Point(865, 173);
            this.clb2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.clb2.Name = "clb2";
            this.clb2.PasswordChar = '\0';
            this.clb2.PlaceholderText = "";
            this.clb2.SelectedText = "";
            this.clb2.ShadowDecoration.Parent = this.clb2;
            this.clb2.Size = new System.Drawing.Size(124, 38);
            this.clb2.TabIndex = 17;
            this.clb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // point
            // 
            this.point.BorderColor = System.Drawing.Color.Black;
            this.point.BorderRadius = 6;
            this.point.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.point.BorderThickness = 3;
            this.point.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.point.DefaultText = "";
            this.point.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.point.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.point.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.point.DisabledState.Parent = this.point;
            this.point.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.point.FillColor = System.Drawing.Color.LightSeaGreen;
            this.point.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.point.FocusedState.Parent = this.point;
            this.point.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.ForeColor = System.Drawing.Color.Black;
            this.point.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.point.HoverState.Parent = this.point;
            this.point.Location = new System.Drawing.Point(809, 342);
            this.point.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.point.Name = "point";
            this.point.PasswordChar = '\0';
            this.point.PlaceholderText = "";
            this.point.SelectedText = "";
            this.point.ShadowDecoration.Parent = this.point;
            this.point.Size = new System.Drawing.Size(124, 38);
            this.point.TabIndex = 18;
            this.point.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // score
            // 
            this.score.BorderColor = System.Drawing.Color.Black;
            this.score.BorderRadius = 6;
            this.score.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.score.BorderThickness = 3;
            this.score.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.score.DefaultText = "";
            this.score.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.score.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.score.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.score.DisabledState.Parent = this.score;
            this.score.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.score.FillColor = System.Drawing.Color.LightSeaGreen;
            this.score.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.score.FocusedState.Parent = this.score;
            this.score.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.Black;
            this.score.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.score.HoverState.Parent = this.score;
            this.score.Location = new System.Drawing.Point(809, 412);
            this.score.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.score.Name = "score";
            this.score.PasswordChar = '\0';
            this.score.PlaceholderText = "";
            this.score.SelectedText = "";
            this.score.ShadowDecoration.Parent = this.score;
            this.score.Size = new System.Drawing.Size(124, 38);
            this.score.TabIndex = 19;
            this.score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clbchoose
            // 
            this.clbchoose.BorderColor = System.Drawing.Color.Black;
            this.clbchoose.BorderRadius = 6;
            this.clbchoose.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.clbchoose.BorderThickness = 3;
            this.clbchoose.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clbchoose.DefaultText = "";
            this.clbchoose.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.clbchoose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.clbchoose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clbchoose.DisabledState.Parent = this.clbchoose;
            this.clbchoose.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clbchoose.FillColor = System.Drawing.Color.LightSeaGreen;
            this.clbchoose.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clbchoose.FocusedState.Parent = this.clbchoose;
            this.clbchoose.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbchoose.ForeColor = System.Drawing.Color.Black;
            this.clbchoose.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clbchoose.HoverState.Parent = this.clbchoose;
            this.clbchoose.Location = new System.Drawing.Point(809, 270);
            this.clbchoose.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.clbchoose.Name = "clbchoose";
            this.clbchoose.PasswordChar = '\0';
            this.clbchoose.PlaceholderText = "";
            this.clbchoose.SelectedText = "";
            this.clbchoose.ShadowDecoration.Parent = this.clbchoose;
            this.clbchoose.Size = new System.Drawing.Size(124, 38);
            this.clbchoose.TabIndex = 20;
            this.clbchoose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(661, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Clb CHoose";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(671, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "point pay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(709, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "score";
            // 
            // pointText
            // 
            this.pointText.BorderColor = System.Drawing.Color.SeaGreen;
            this.pointText.BorderRadius = 13;
            this.pointText.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.pointText.BorderThickness = 3;
            this.pointText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pointText.DefaultText = "";
            this.pointText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pointText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pointText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pointText.DisabledState.Parent = this.pointText;
            this.pointText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pointText.FillColor = System.Drawing.Color.PaleTurquoise;
            this.pointText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pointText.FocusedState.Parent = this.pointText;
            this.pointText.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointText.ForeColor = System.Drawing.Color.Black;
            this.pointText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pointText.HoverState.Parent = this.pointText;
            this.pointText.Location = new System.Drawing.Point(784, 81);
            this.pointText.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pointText.Name = "pointText";
            this.pointText.PasswordChar = '\0';
            this.pointText.PlaceholderText = "";
            this.pointText.SelectedText = "";
            this.pointText.ShadowDecoration.Parent = this.pointText;
            this.pointText.Size = new System.Drawing.Size(149, 38);
            this.pointText.TabIndex = 34;
            this.pointText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userText
            // 
            this.userText.BorderColor = System.Drawing.Color.SeaGreen;
            this.userText.BorderRadius = 13;
            this.userText.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.userText.BorderThickness = 3;
            this.userText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userText.DefaultText = "";
            this.userText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userText.DisabledState.Parent = this.userText;
            this.userText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userText.FillColor = System.Drawing.Color.PaleTurquoise;
            this.userText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userText.FocusedState.Parent = this.userText;
            this.userText.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userText.ForeColor = System.Drawing.Color.Black;
            this.userText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userText.HoverState.Parent = this.userText;
            this.userText.Location = new System.Drawing.Point(784, 37);
            this.userText.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.userText.Name = "userText";
            this.userText.PasswordChar = '\0';
            this.userText.PlaceholderText = "";
            this.userText.SelectedText = "";
            this.userText.ShadowDecoration.Parent = this.userText;
            this.userText.Size = new System.Drawing.Size(149, 38);
            this.userText.TabIndex = 33;
            this.userText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(697, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(697, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 36;
            this.label6.Text = "Point";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 13;
            this.guna2Button2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button2.BorderThickness = 3;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.DisabledState.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2Button2.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(675, 217);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(106, 35);
            this.guna2Button2.TabIndex = 37;
            this.guna2Button2.Text = "clb 1";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
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
            this.guna2Button3.Location = new System.Drawing.Point(874, 217);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(106, 35);
            this.guna2Button3.TabIndex = 38;
            this.guna2Button3.Text = "clb 2";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(805, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 39;
            this.label7.Text = "vs";
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
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button4.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(809, 477);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(106, 35);
            this.guna2Button4.TabIndex = 40;
            this.guna2Button4.Text = "OK";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(1001, 587);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pointText);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clbchoose);
            this.Controls.Add(this.score);
            this.Controls.Add(this.point);
            this.Controls.Add(this.clb2);
            this.Controls.Add(this.clb1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label1);
            this.Name = "play";
            this.Text = "play";
            this.Load += new System.EventHandler(this.play_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchid;
        private System.Windows.Forms.DataGridViewTextBoxColumn club1;
        private System.Windows.Forms.DataGridViewTextBoxColumn club2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stay;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private Guna.UI2.WinForms.Guna2TextBox clb1;
        private Guna.UI2.WinForms.Guna2TextBox clb2;
        private Guna.UI2.WinForms.Guna2TextBox point;
        private Guna.UI2.WinForms.Guna2TextBox score;
        private Guna.UI2.WinForms.Guna2TextBox clbchoose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox pointText;
        private Guna.UI2.WinForms.Guna2TextBox userText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
    }
}