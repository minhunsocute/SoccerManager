
namespace HH
{
    partial class insertScore
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
            this.plid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clbid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerID = new Guna.UI2.WinForms.Guna2TextBox();
            this.timeGoal = new Guna.UI2.WinForms.Guna2TextBox();
            this.GoalID = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameGoal = new Guna.UI2.WinForms.Guna2TextBox();
            this.clb = new System.Windows.Forms.Label();
            this.Inse = new System.Windows.Forms.Label();
            this.insert_button = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clb1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.plid1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.time1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.goalid1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.name1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sc = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.insert_button2 = new Guna.UI2.WinForms.Guna2Button();
            this.plid_sc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clbid_sc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_sc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_sc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plid,
            this.plname,
            this.clbid});
            this.dataGridView1.Location = new System.Drawing.Point(26, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(300, 391);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // plid
            // 
            this.plid.DataPropertyName = "PLID";
            this.plid.HeaderText = "Player ID";
            this.plid.Name = "plid";
            // 
            // plname
            // 
            this.plname.DataPropertyName = "PLNAME";
            this.plname.HeaderText = "Name";
            this.plname.Name = "plname";
            // 
            // clbid
            // 
            this.clbid.DataPropertyName = "CLBID";
            this.clbid.HeaderText = "CLUB ID";
            this.clbid.Name = "clbid";
            // 
            // playerID
            // 
            this.playerID.BorderColor = System.Drawing.Color.Lime;
            this.playerID.BorderRadius = 13;
            this.playerID.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.playerID.BorderThickness = 3;
            this.playerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.playerID.DefaultText = "";
            this.playerID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.playerID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.playerID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.playerID.DisabledState.Parent = this.playerID;
            this.playerID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.playerID.FillColor = System.Drawing.Color.DarkTurquoise;
            this.playerID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.playerID.FocusedState.Parent = this.playerID;
            this.playerID.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerID.ForeColor = System.Drawing.Color.Black;
            this.playerID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.playerID.HoverState.Parent = this.playerID;
            this.playerID.Location = new System.Drawing.Point(334, 166);
            this.playerID.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.playerID.Name = "playerID";
            this.playerID.PasswordChar = '\0';
            this.playerID.PlaceholderForeColor = System.Drawing.Color.Black;
            this.playerID.PlaceholderText = "";
            this.playerID.SelectedText = "";
            this.playerID.ShadowDecoration.Parent = this.playerID;
            this.playerID.Size = new System.Drawing.Size(144, 48);
            this.playerID.TabIndex = 4;
            this.playerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeGoal
            // 
            this.timeGoal.BorderColor = System.Drawing.Color.Lime;
            this.timeGoal.BorderRadius = 13;
            this.timeGoal.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.timeGoal.BorderThickness = 3;
            this.timeGoal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.timeGoal.DefaultText = "";
            this.timeGoal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.timeGoal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.timeGoal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timeGoal.DisabledState.Parent = this.timeGoal;
            this.timeGoal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timeGoal.FillColor = System.Drawing.Color.DarkTurquoise;
            this.timeGoal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeGoal.FocusedState.Parent = this.timeGoal;
            this.timeGoal.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeGoal.ForeColor = System.Drawing.Color.Black;
            this.timeGoal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeGoal.HoverState.Parent = this.timeGoal;
            this.timeGoal.Location = new System.Drawing.Point(334, 263);
            this.timeGoal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.timeGoal.Name = "timeGoal";
            this.timeGoal.PasswordChar = '\0';
            this.timeGoal.PlaceholderForeColor = System.Drawing.Color.Black;
            this.timeGoal.PlaceholderText = "";
            this.timeGoal.SelectedText = "";
            this.timeGoal.ShadowDecoration.Parent = this.timeGoal;
            this.timeGoal.Size = new System.Drawing.Size(144, 48);
            this.timeGoal.TabIndex = 5;
            this.timeGoal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GoalID
            // 
            this.GoalID.BorderColor = System.Drawing.Color.Lime;
            this.GoalID.BorderRadius = 13;
            this.GoalID.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.GoalID.BorderThickness = 3;
            this.GoalID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GoalID.DefaultText = "";
            this.GoalID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.GoalID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.GoalID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GoalID.DisabledState.Parent = this.GoalID;
            this.GoalID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GoalID.FillColor = System.Drawing.Color.DarkTurquoise;
            this.GoalID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GoalID.FocusedState.Parent = this.GoalID;
            this.GoalID.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoalID.ForeColor = System.Drawing.Color.Black;
            this.GoalID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GoalID.HoverState.Parent = this.GoalID;
            this.GoalID.Location = new System.Drawing.Point(334, 364);
            this.GoalID.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.GoalID.Name = "GoalID";
            this.GoalID.PasswordChar = '\0';
            this.GoalID.PlaceholderForeColor = System.Drawing.Color.Black;
            this.GoalID.PlaceholderText = "";
            this.GoalID.SelectedText = "";
            this.GoalID.ShadowDecoration.Parent = this.GoalID;
            this.GoalID.Size = new System.Drawing.Size(144, 48);
            this.GoalID.TabIndex = 6;
            this.GoalID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameGoal
            // 
            this.nameGoal.BorderColor = System.Drawing.Color.Lime;
            this.nameGoal.BorderRadius = 13;
            this.nameGoal.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.nameGoal.BorderThickness = 3;
            this.nameGoal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameGoal.DefaultText = "";
            this.nameGoal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameGoal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameGoal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameGoal.DisabledState.Parent = this.nameGoal;
            this.nameGoal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameGoal.FillColor = System.Drawing.Color.DarkTurquoise;
            this.nameGoal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameGoal.FocusedState.Parent = this.nameGoal;
            this.nameGoal.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameGoal.ForeColor = System.Drawing.Color.Black;
            this.nameGoal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameGoal.HoverState.Parent = this.nameGoal;
            this.nameGoal.Location = new System.Drawing.Point(334, 462);
            this.nameGoal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.nameGoal.Name = "nameGoal";
            this.nameGoal.PasswordChar = '\0';
            this.nameGoal.PlaceholderForeColor = System.Drawing.Color.Black;
            this.nameGoal.PlaceholderText = "";
            this.nameGoal.SelectedText = "";
            this.nameGoal.ShadowDecoration.Parent = this.nameGoal;
            this.nameGoal.Size = new System.Drawing.Size(144, 48);
            this.nameGoal.TabIndex = 7;
            this.nameGoal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clb
            // 
            this.clb.AutoSize = true;
            this.clb.Font = new System.Drawing.Font("ROG Fonts", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clb.Location = new System.Drawing.Point(73, 77);
            this.clb.Name = "clb";
            this.clb.Size = new System.Drawing.Size(109, 38);
            this.clb.TabIndex = 8;
            this.clb.Text = "CLB1";
            // 
            // Inse
            // 
            this.Inse.AutoSize = true;
            this.Inse.Font = new System.Drawing.Font("ROG Fonts", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inse.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Inse.Location = new System.Drawing.Point(410, 20);
            this.Inse.Name = "Inse";
            this.Inse.Size = new System.Drawing.Size(318, 38);
            this.Inse.TabIndex = 9;
            this.Inse.Text = "insert score";
            // 
            // insert_button
            // 
            this.insert_button.BorderRadius = 13;
            this.insert_button.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.insert_button.BorderThickness = 3;
            this.insert_button.CheckedState.Parent = this.insert_button;
            this.insert_button.CustomImages.Parent = this.insert_button;
            this.insert_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.insert_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.insert_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.insert_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.insert_button.DisabledState.Parent = this.insert_button;
            this.insert_button.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_button.ForeColor = System.Drawing.Color.White;
            this.insert_button.HoverState.Parent = this.insert_button;
            this.insert_button.Location = new System.Drawing.Point(80, 558);
            this.insert_button.Name = "insert_button";
            this.insert_button.ShadowDecoration.Parent = this.insert_button;
            this.insert_button.Size = new System.Drawing.Size(180, 45);
            this.insert_button.TabIndex = 10;
            this.insert_button.Text = "insert score";
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(342, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "player ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(342, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "time goal";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(342, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "goal id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(342, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "name goal";
            // 
            // clb1
            // 
            this.clb1.AutoSize = true;
            this.clb1.Font = new System.Drawing.Font("ROG Fonts", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clb1.Location = new System.Drawing.Point(934, 77);
            this.clb1.Name = "clb1";
            this.clb1.Size = new System.Drawing.Size(121, 38);
            this.clb1.TabIndex = 15;
            this.clb1.Text = "CLB2";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(842, 131);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(300, 391);
            this.dataGridView2.TabIndex = 16;
            this.dataGridView2.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_RowEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PLID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Player ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PLNAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CLBID";
            this.dataGridViewTextBoxColumn3.HeaderText = "CLUB ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(694, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "player ID";
            // 
            // plid1
            // 
            this.plid1.BorderColor = System.Drawing.Color.Lime;
            this.plid1.BorderRadius = 13;
            this.plid1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.plid1.BorderThickness = 3;
            this.plid1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.plid1.DefaultText = "";
            this.plid1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.plid1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.plid1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.plid1.DisabledState.Parent = this.plid1;
            this.plid1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.plid1.FillColor = System.Drawing.Color.DarkTurquoise;
            this.plid1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.plid1.FocusedState.Parent = this.plid1;
            this.plid1.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plid1.ForeColor = System.Drawing.Color.Black;
            this.plid1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.plid1.HoverState.Parent = this.plid1;
            this.plid1.Location = new System.Drawing.Point(678, 166);
            this.plid1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.plid1.Name = "plid1";
            this.plid1.PasswordChar = '\0';
            this.plid1.PlaceholderForeColor = System.Drawing.Color.Black;
            this.plid1.PlaceholderText = "";
            this.plid1.SelectedText = "";
            this.plid1.ShadowDecoration.Parent = this.plid1;
            this.plid1.Size = new System.Drawing.Size(144, 48);
            this.plid1.TabIndex = 18;
            this.plid1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // time1
            // 
            this.time1.BorderColor = System.Drawing.Color.Lime;
            this.time1.BorderRadius = 13;
            this.time1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.time1.BorderThickness = 3;
            this.time1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.time1.DefaultText = "";
            this.time1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.time1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.time1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.time1.DisabledState.Parent = this.time1;
            this.time1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.time1.FillColor = System.Drawing.Color.DarkTurquoise;
            this.time1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.time1.FocusedState.Parent = this.time1;
            this.time1.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time1.ForeColor = System.Drawing.Color.Black;
            this.time1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.time1.HoverState.Parent = this.time1;
            this.time1.Location = new System.Drawing.Point(678, 263);
            this.time1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.time1.Name = "time1";
            this.time1.PasswordChar = '\0';
            this.time1.PlaceholderForeColor = System.Drawing.Color.Black;
            this.time1.PlaceholderText = "";
            this.time1.SelectedText = "";
            this.time1.ShadowDecoration.Parent = this.time1;
            this.time1.Size = new System.Drawing.Size(144, 48);
            this.time1.TabIndex = 19;
            this.time1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // goalid1
            // 
            this.goalid1.BorderColor = System.Drawing.Color.Lime;
            this.goalid1.BorderRadius = 13;
            this.goalid1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.goalid1.BorderThickness = 3;
            this.goalid1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.goalid1.DefaultText = "";
            this.goalid1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.goalid1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.goalid1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.goalid1.DisabledState.Parent = this.goalid1;
            this.goalid1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.goalid1.FillColor = System.Drawing.Color.DarkTurquoise;
            this.goalid1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.goalid1.FocusedState.Parent = this.goalid1;
            this.goalid1.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalid1.ForeColor = System.Drawing.Color.Black;
            this.goalid1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.goalid1.HoverState.Parent = this.goalid1;
            this.goalid1.Location = new System.Drawing.Point(678, 364);
            this.goalid1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.goalid1.Name = "goalid1";
            this.goalid1.PasswordChar = '\0';
            this.goalid1.PlaceholderForeColor = System.Drawing.Color.Black;
            this.goalid1.PlaceholderText = "";
            this.goalid1.SelectedText = "";
            this.goalid1.ShadowDecoration.Parent = this.goalid1;
            this.goalid1.Size = new System.Drawing.Size(144, 48);
            this.goalid1.TabIndex = 20;
            this.goalid1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name1
            // 
            this.name1.BorderColor = System.Drawing.Color.Lime;
            this.name1.BorderRadius = 13;
            this.name1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.name1.BorderThickness = 3;
            this.name1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name1.DefaultText = "";
            this.name1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.name1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.name1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name1.DisabledState.Parent = this.name1;
            this.name1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name1.FillColor = System.Drawing.Color.DarkTurquoise;
            this.name1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name1.FocusedState.Parent = this.name1;
            this.name1.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name1.ForeColor = System.Drawing.Color.Black;
            this.name1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name1.HoverState.Parent = this.name1;
            this.name1.Location = new System.Drawing.Point(678, 462);
            this.name1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.name1.Name = "name1";
            this.name1.PasswordChar = '\0';
            this.name1.PlaceholderForeColor = System.Drawing.Color.Black;
            this.name1.PlaceholderText = "";
            this.name1.SelectedText = "";
            this.name1.ShadowDecoration.Parent = this.name1;
            this.name1.Size = new System.Drawing.Size(144, 48);
            this.name1.TabIndex = 21;
            this.name1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(692, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "time goal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(722, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "goal id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(684, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "name goal";
            // 
            // sc
            // 
            this.sc.AutoSize = true;
            this.sc.Font = new System.Drawing.Font("ROG Fonts", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sc.Location = new System.Drawing.Point(296, 77);
            this.sc.Name = "sc";
            this.sc.Size = new System.Drawing.Size(86, 38);
            this.sc.TabIndex = 25;
            this.sc.Text = "sc1";
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Font = new System.Drawing.Font("ROG Fonts", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.score1.Location = new System.Drawing.Point(707, 77);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(98, 38);
            this.score1.TabIndex = 26;
            this.score1.Text = "sc2";
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plid_sc,
            this.clbid_sc,
            this.time_sc,
            this.name_sc});
            this.dataGridView3.Location = new System.Drawing.Point(365, 558);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(444, 124);
            this.dataGridView3.TabIndex = 27;
            this.dataGridView3.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_RowEnter);
            // 
            // insert_button2
            // 
            this.insert_button2.BorderRadius = 13;
            this.insert_button2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.insert_button2.BorderThickness = 3;
            this.insert_button2.CheckedState.Parent = this.insert_button2;
            this.insert_button2.CustomImages.Parent = this.insert_button2;
            this.insert_button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.insert_button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.insert_button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.insert_button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.insert_button2.DisabledState.Parent = this.insert_button2;
            this.insert_button2.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_button2.ForeColor = System.Drawing.Color.White;
            this.insert_button2.HoverState.Parent = this.insert_button2;
            this.insert_button2.Location = new System.Drawing.Point(912, 558);
            this.insert_button2.Name = "insert_button2";
            this.insert_button2.ShadowDecoration.Parent = this.insert_button2;
            this.insert_button2.Size = new System.Drawing.Size(180, 45);
            this.insert_button2.TabIndex = 28;
            this.insert_button2.Text = "insert score";
            this.insert_button2.Click += new System.EventHandler(this.insert_button2_Click);
            // 
            // plid_sc
            // 
            this.plid_sc.DataPropertyName = "PLID";
            this.plid_sc.HeaderText = "Player ID";
            this.plid_sc.Name = "plid_sc";
            // 
            // clbid_sc
            // 
            this.clbid_sc.DataPropertyName = "CLBID";
            this.clbid_sc.HeaderText = "Club ID";
            this.clbid_sc.Name = "clbid_sc";
            // 
            // time_sc
            // 
            this.time_sc.DataPropertyName = "TIME_GOAL";
            this.time_sc.HeaderText = "Time Goal";
            this.time_sc.Name = "time_sc";
            // 
            // name_sc
            // 
            this.name_sc.DataPropertyName = "NAMEGOAL";
            this.name_sc.HeaderText = "Name Goal";
            this.name_sc.Name = "name_sc";
            // 
            // insertScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1163, 775);
            this.Controls.Add(this.insert_button2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.sc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.goalid1);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.plid1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.clb1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.Inse);
            this.Controls.Add(this.clb);
            this.Controls.Add(this.nameGoal);
            this.Controls.Add(this.GoalID);
            this.Controls.Add(this.timeGoal);
            this.Controls.Add(this.playerID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "insertScore";
            this.Text = "insertScore";
            this.Load += new System.EventHandler(this.insertScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn plid;
        private System.Windows.Forms.DataGridViewTextBoxColumn plname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clbid;
        private Guna.UI2.WinForms.Guna2TextBox playerID;
        private Guna.UI2.WinForms.Guna2TextBox timeGoal;
        private Guna.UI2.WinForms.Guna2TextBox GoalID;
        private Guna.UI2.WinForms.Guna2TextBox nameGoal;
        private System.Windows.Forms.Label clb;
        private System.Windows.Forms.Label Inse;
        private Guna.UI2.WinForms.Guna2Button insert_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label clb1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox plid1;
        private Guna.UI2.WinForms.Guna2TextBox time1;
        private Guna.UI2.WinForms.Guna2TextBox goalid1;
        private Guna.UI2.WinForms.Guna2TextBox name1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label sc;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private Guna.UI2.WinForms.Guna2Button insert_button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn plid_sc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clbid_sc;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_sc;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_sc;
    }
}