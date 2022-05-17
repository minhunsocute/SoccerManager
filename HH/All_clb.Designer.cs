
namespace HH
{
    partial class All_clb
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clbid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameclb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staydium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberplayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclub = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.searchText = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchID = new Guna.UI2.WinForms.Guna2Button();
            this.closeButton = new Guna.UI2.WinForms.Guna2Button();
            this.updateClick = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clbid,
            this.nameclb,
            this.staydium,
            this.addres,
            this.date,
            this.goal,
            this.lose,
            this.point,
            this.numberplayer});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(29, 158);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(944, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // clbid
            // 
            this.clbid.DataPropertyName = "CLBID";
            this.clbid.HeaderText = "CLBID";
            this.clbid.Name = "clbid";
            // 
            // nameclb
            // 
            this.nameclb.DataPropertyName = "CLBNAME";
            this.nameclb.HeaderText = "NAMECLB";
            this.nameclb.Name = "nameclb";
            // 
            // staydium
            // 
            this.staydium.DataPropertyName = "STAYDIUM";
            this.staydium.HeaderText = "STAYDIUM";
            this.staydium.Name = "staydium";
            // 
            // addres
            // 
            this.addres.DataPropertyName = "ADDRES";
            this.addres.HeaderText = "ADDRES";
            this.addres.Name = "addres";
            // 
            // date
            // 
            this.date.DataPropertyName = "DAYBUILT";
            this.date.HeaderText = "DATE BORN";
            this.date.Name = "date";
            // 
            // goal
            // 
            this.goal.DataPropertyName = "SCORE";
            this.goal.HeaderText = "GOAL";
            this.goal.Name = "goal";
            // 
            // lose
            // 
            this.lose.DataPropertyName = "LOSE";
            this.lose.HeaderText = "LOSE";
            this.lose.Name = "lose";
            // 
            // point
            // 
            this.point.DataPropertyName = "POINT";
            this.point.HeaderText = "POINT";
            this.point.Name = "point";
            // 
            // numberplayer
            // 
            this.numberplayer.DataPropertyName = "NUMBERPLAYER";
            this.numberplayer.HeaderText = "NUMBER PLAYER";
            this.numberplayer.Name = "numberplayer";
            // 
            // idclub
            // 
            this.idclub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.idclub.BorderColor = System.Drawing.Color.SeaGreen;
            this.idclub.BorderRadius = 13;
            this.idclub.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.idclub.BorderThickness = 3;
            this.idclub.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idclub.DefaultText = "";
            this.idclub.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idclub.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idclub.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idclub.DisabledState.Parent = this.idclub;
            this.idclub.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idclub.FillColor = System.Drawing.Color.PaleTurquoise;
            this.idclub.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idclub.FocusedState.Parent = this.idclub;
            this.idclub.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idclub.ForeColor = System.Drawing.Color.Black;
            this.idclub.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idclub.HoverState.Parent = this.idclub;
            this.idclub.Location = new System.Drawing.Point(61, 70);
            this.idclub.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.idclub.Name = "idclub";
            this.idclub.PasswordChar = '\0';
            this.idclub.PlaceholderText = "";
            this.idclub.SelectedText = "";
            this.idclub.ShadowDecoration.Parent = this.idclub;
            this.idclub.Size = new System.Drawing.Size(279, 57);
            this.idclub.TabIndex = 1;
            this.idclub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(403, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "ALL CLUB";
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("ROG Fonts", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(29, 517);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(135, 45);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "INSERT CLB";
            this.guna2Button1.Click += new System.EventHandler(this.insert_clbForm);
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.DisabledState.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("ROG Fonts", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(193, 517);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(123, 45);
            this.guna2Button2.TabIndex = 4;
            this.guna2Button2.Text = "DELETE CLB";
            this.guna2Button2.Click += new System.EventHandler(this.deleteCLick);
            // 
            // guna2Button3
            // 
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.DisabledState.Parent = this.guna2Button3;
            this.guna2Button3.Font = new System.Drawing.Font("ROG Fonts", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(358, 517);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(126, 45);
            this.guna2Button3.TabIndex = 5;
            this.guna2Button3.Text = "WATCH PLAYER";
            this.guna2Button3.Click += new System.EventHandler(this.watch_player);
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
            this.searchText.Location = new System.Drawing.Point(626, 89);
            this.searchText.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.searchText.Name = "searchText";
            this.searchText.PasswordChar = '\0';
            this.searchText.PlaceholderText = "";
            this.searchText.SelectedText = "";
            this.searchText.ShadowDecoration.Parent = this.searchText;
            this.searchText.Size = new System.Drawing.Size(163, 38);
            this.searchText.TabIndex = 7;
            this.searchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.searchID.Location = new System.Drawing.Point(812, 100);
            this.searchID.Name = "searchID";
            this.searchID.ShadowDecoration.Parent = this.searchID;
            this.searchID.Size = new System.Drawing.Size(132, 27);
            this.searchID.TabIndex = 8;
            this.searchID.Text = "search";
            this.searchID.Click += new System.EventHandler(this.searchClick);
            // 
            // closeButton
            // 
            this.closeButton.BorderRadius = 15;
            this.closeButton.CheckedState.Parent = this.closeButton;
            this.closeButton.CustomImages.Parent = this.closeButton;
            this.closeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closeButton.DisabledState.Parent = this.closeButton;
            this.closeButton.FillColor = System.Drawing.Color.SeaGreen;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.HoverState.Parent = this.closeButton;
            this.closeButton.Location = new System.Drawing.Point(838, 517);
            this.closeButton.Name = "closeButton";
            this.closeButton.ShadowDecoration.Parent = this.closeButton;
            this.closeButton.Size = new System.Drawing.Size(135, 45);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.closeButton.Click += new System.EventHandler(this.closeClick);
            // 
            // updateClick
            // 
            this.updateClick.CheckedState.Parent = this.updateClick;
            this.updateClick.CustomImages.Parent = this.updateClick;
            this.updateClick.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateClick.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateClick.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateClick.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateClick.DisabledState.Parent = this.updateClick;
            this.updateClick.Font = new System.Drawing.Font("ROG Fonts", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateClick.ForeColor = System.Drawing.Color.White;
            this.updateClick.HoverState.Parent = this.updateClick;
            this.updateClick.Location = new System.Drawing.Point(525, 517);
            this.updateClick.Name = "updateClick";
            this.updateClick.ShadowDecoration.Parent = this.updateClick;
            this.updateClick.Size = new System.Drawing.Size(133, 45);
            this.updateClick.TabIndex = 10;
            this.updateClick.Text = "UPDATE ";
            this.updateClick.Click += new System.EventHandler(this.update_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(938, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // guna2Button4
            // 
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.DisabledState.Parent = this.guna2Button4;
            this.guna2Button4.Font = new System.Drawing.Font("ROG Fonts", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(690, 517);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(133, 45);
            this.guna2Button4.TabIndex = 12;
            this.guna2Button4.Text = "COACH";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // All_clb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1001, 587);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateClick);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.searchID);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idclub);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "All_clb";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.All_clb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox idclub;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clbid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameclb;
        private System.Windows.Forms.DataGridViewTextBoxColumn staydium;
        private System.Windows.Forms.DataGridViewTextBoxColumn addres;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn goal;
        private System.Windows.Forms.DataGridViewTextBoxColumn lose;
        private System.Windows.Forms.DataGridViewTextBoxColumn point;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberplayer;
        private Guna.UI2.WinForms.Guna2TextBox searchText;
        private Guna.UI2.WinForms.Guna2Button searchID;
        private Guna.UI2.WinForms.Guna2Button closeButton;
        private Guna.UI2.WinForms.Guna2Button updateClick;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
    }
}