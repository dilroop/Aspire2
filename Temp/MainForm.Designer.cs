namespace Temp
{
    partial class Ntecc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ntecc));
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.coursebtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.left_panel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.levelbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.roombtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.generatebtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.studentbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.teacherbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.subjectbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.content_panel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.Aboutbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.left_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(0, 0);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(100, 23);
            this.metroProgressBar1.TabIndex = 0;
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(0, 0);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 0;
            this.metroLink1.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Temp.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(10, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 55);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // coursebtn
            // 
            this.coursebtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(63)))), ((int)(((byte)(187)))));
            this.coursebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(63)))), ((int)(((byte)(187)))));
            this.coursebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.coursebtn.BorderRadius = 0;
            this.coursebtn.ButtonText = "Courses";
            this.coursebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coursebtn.DisabledColor = System.Drawing.Color.Gray;
            this.coursebtn.Iconcolor = System.Drawing.Color.Transparent;
            this.coursebtn.Iconimage = global::Temp.Properties.Resources.courses;
            this.coursebtn.Iconimage_right = null;
            this.coursebtn.Iconimage_right_Selected = null;
            this.coursebtn.Iconimage_Selected = null;
            this.coursebtn.IconMarginLeft = 0;
            this.coursebtn.IconMarginRight = 0;
            this.coursebtn.IconRightVisible = true;
            this.coursebtn.IconRightZoom = 0D;
            this.coursebtn.IconVisible = true;
            this.coursebtn.IconZoom = 54D;
            this.coursebtn.IsTab = true;
            this.coursebtn.Location = new System.Drawing.Point(4, 5);
            this.coursebtn.Name = "coursebtn";
            this.coursebtn.Normalcolor = System.Drawing.Color.Transparent;
            this.coursebtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(209)))), ((int)(((byte)(72)))));
            this.coursebtn.OnHoverTextColor = System.Drawing.Color.White;
            this.coursebtn.selected = true;
            this.coursebtn.Size = new System.Drawing.Size(148, 37);
            this.coursebtn.TabIndex = 1;
            this.coursebtn.Text = "Courses";
            this.coursebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coursebtn.Textcolor = System.Drawing.Color.White;
            this.coursebtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursebtn.Click += new System.EventHandler(this.coursesbtn_Click);
            // 
            // left_panel
            // 
            this.left_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("left_panel.BackgroundImage")));
            this.left_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.left_panel.Controls.Add(this.levelbtn);
            this.left_panel.Controls.Add(this.roombtn);
            this.left_panel.Controls.Add(this.generatebtn);
            this.left_panel.Controls.Add(this.studentbtn);
            this.left_panel.Controls.Add(this.teacherbtn);
            this.left_panel.Controls.Add(this.subjectbtn);
            this.left_panel.Controls.Add(this.coursebtn);
            this.left_panel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.left_panel.GradientBottomRight = System.Drawing.Color.DarkGreen;
            this.left_panel.GradientTopLeft = System.Drawing.Color.Blue;
            this.left_panel.GradientTopRight = System.Drawing.Color.Navy;
            this.left_panel.Location = new System.Drawing.Point(1, 80);
            this.left_panel.Name = "left_panel";
            this.left_panel.Quality = 10;
            this.left_panel.Size = new System.Drawing.Size(156, 390);
            this.left_panel.TabIndex = 4;
            // 
            // levelbtn
            // 
            this.levelbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(57)))), ((int)(((byte)(156)))));
            this.levelbtn.BackColor = System.Drawing.Color.Transparent;
            this.levelbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.levelbtn.BorderRadius = 0;
            this.levelbtn.ButtonText = "Levels";
            this.levelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.levelbtn.DisabledColor = System.Drawing.Color.Gray;
            this.levelbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.levelbtn.Iconimage = global::Temp.Properties.Resources.levels;
            this.levelbtn.Iconimage_right = null;
            this.levelbtn.Iconimage_right_Selected = null;
            this.levelbtn.Iconimage_Selected = null;
            this.levelbtn.IconMarginLeft = 0;
            this.levelbtn.IconMarginRight = 0;
            this.levelbtn.IconRightVisible = true;
            this.levelbtn.IconRightZoom = 0D;
            this.levelbtn.IconVisible = true;
            this.levelbtn.IconZoom = 54D;
            this.levelbtn.IsTab = true;
            this.levelbtn.Location = new System.Drawing.Point(3, 306);
            this.levelbtn.Name = "levelbtn";
            this.levelbtn.Normalcolor = System.Drawing.Color.Transparent;
            this.levelbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(209)))), ((int)(((byte)(72)))));
            this.levelbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.levelbtn.selected = false;
            this.levelbtn.Size = new System.Drawing.Size(148, 37);
            this.levelbtn.TabIndex = 7;
            this.levelbtn.Text = "Levels";
            this.levelbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.levelbtn.Textcolor = System.Drawing.Color.White;
            this.levelbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelbtn.Click += new System.EventHandler(this.levelbtn_Click);
            // 
            // roombtn
            // 
            this.roombtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(57)))), ((int)(((byte)(156)))));
            this.roombtn.BackColor = System.Drawing.Color.Transparent;
            this.roombtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roombtn.BorderRadius = 0;
            this.roombtn.ButtonText = "Rooms";
            this.roombtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roombtn.DisabledColor = System.Drawing.Color.Gray;
            this.roombtn.Iconcolor = System.Drawing.Color.Transparent;
            this.roombtn.Iconimage = global::Temp.Properties.Resources.Room;
            this.roombtn.Iconimage_right = null;
            this.roombtn.Iconimage_right_Selected = null;
            this.roombtn.Iconimage_Selected = null;
            this.roombtn.IconMarginLeft = 0;
            this.roombtn.IconMarginRight = 0;
            this.roombtn.IconRightVisible = true;
            this.roombtn.IconRightZoom = 0D;
            this.roombtn.IconVisible = true;
            this.roombtn.IconZoom = 54D;
            this.roombtn.IsTab = true;
            this.roombtn.Location = new System.Drawing.Point(4, 177);
            this.roombtn.Name = "roombtn";
            this.roombtn.Normalcolor = System.Drawing.Color.Transparent;
            this.roombtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(209)))), ((int)(((byte)(72)))));
            this.roombtn.OnHoverTextColor = System.Drawing.Color.White;
            this.roombtn.selected = false;
            this.roombtn.Size = new System.Drawing.Size(148, 37);
            this.roombtn.TabIndex = 6;
            this.roombtn.Text = "Rooms";
            this.roombtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roombtn.Textcolor = System.Drawing.Color.White;
            this.roombtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roombtn.Click += new System.EventHandler(this.roombtn_Click);
            // 
            // generatebtn
            // 
            this.generatebtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(51)))), ((int)(((byte)(132)))));
            this.generatebtn.BackColor = System.Drawing.Color.Transparent;
            this.generatebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.generatebtn.BorderRadius = 0;
            this.generatebtn.ButtonText = "Generate";
            this.generatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generatebtn.DisabledColor = System.Drawing.Color.Gray;
            this.generatebtn.Iconcolor = System.Drawing.Color.Transparent;
            this.generatebtn.Iconimage = global::Temp.Properties.Resources.TimeTable;
            this.generatebtn.Iconimage_right = null;
            this.generatebtn.Iconimage_right_Selected = null;
            this.generatebtn.Iconimage_Selected = null;
            this.generatebtn.IconMarginLeft = 0;
            this.generatebtn.IconMarginRight = 0;
            this.generatebtn.IconRightVisible = true;
            this.generatebtn.IconRightZoom = 0D;
            this.generatebtn.IconVisible = true;
            this.generatebtn.IconZoom = 54D;
            this.generatebtn.IsTab = true;
            this.generatebtn.Location = new System.Drawing.Point(4, 349);
            this.generatebtn.Name = "generatebtn";
            this.generatebtn.Normalcolor = System.Drawing.Color.Transparent;
            this.generatebtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(209)))), ((int)(((byte)(72)))));
            this.generatebtn.OnHoverTextColor = System.Drawing.Color.White;
            this.generatebtn.selected = false;
            this.generatebtn.Size = new System.Drawing.Size(148, 37);
            this.generatebtn.TabIndex = 5;
            this.generatebtn.Text = "Generate";
            this.generatebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generatebtn.Textcolor = System.Drawing.Color.White;
            this.generatebtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatebtn.Click += new System.EventHandler(this.generatebtn_Click);
            // 
            // studentbtn
            // 
            this.studentbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(163)))));
            this.studentbtn.BackColor = System.Drawing.Color.Transparent;
            this.studentbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.studentbtn.BorderRadius = 0;
            this.studentbtn.ButtonText = "Students";
            this.studentbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentbtn.DisabledColor = System.Drawing.Color.Gray;
            this.studentbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.studentbtn.Iconimage = global::Temp.Properties.Resources.student;
            this.studentbtn.Iconimage_right = null;
            this.studentbtn.Iconimage_right_Selected = null;
            this.studentbtn.Iconimage_Selected = null;
            this.studentbtn.IconMarginLeft = 0;
            this.studentbtn.IconMarginRight = 0;
            this.studentbtn.IconRightVisible = true;
            this.studentbtn.IconRightZoom = 0D;
            this.studentbtn.IconVisible = true;
            this.studentbtn.IconZoom = 54D;
            this.studentbtn.IsTab = true;
            this.studentbtn.Location = new System.Drawing.Point(4, 134);
            this.studentbtn.Name = "studentbtn";
            this.studentbtn.Normalcolor = System.Drawing.Color.Transparent;
            this.studentbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(209)))), ((int)(((byte)(72)))));
            this.studentbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.studentbtn.selected = false;
            this.studentbtn.Size = new System.Drawing.Size(148, 37);
            this.studentbtn.TabIndex = 4;
            this.studentbtn.Text = "Students";
            this.studentbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentbtn.Textcolor = System.Drawing.Color.White;
            this.studentbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentbtn.Click += new System.EventHandler(this.studentbtn_Click);
            // 
            // teacherbtn
            // 
            this.teacherbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(60)))), ((int)(((byte)(171)))));
            this.teacherbtn.BackColor = System.Drawing.Color.Transparent;
            this.teacherbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.teacherbtn.BorderRadius = 0;
            this.teacherbtn.ButtonText = "Teachers";
            this.teacherbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teacherbtn.DisabledColor = System.Drawing.Color.Gray;
            this.teacherbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.teacherbtn.Iconimage = global::Temp.Properties.Resources.Teacher;
            this.teacherbtn.Iconimage_right = null;
            this.teacherbtn.Iconimage_right_Selected = null;
            this.teacherbtn.Iconimage_Selected = null;
            this.teacherbtn.IconMarginLeft = 0;
            this.teacherbtn.IconMarginRight = 0;
            this.teacherbtn.IconRightVisible = true;
            this.teacherbtn.IconRightZoom = 0D;
            this.teacherbtn.IconVisible = true;
            this.teacherbtn.IconZoom = 54D;
            this.teacherbtn.IsTab = true;
            this.teacherbtn.Location = new System.Drawing.Point(4, 91);
            this.teacherbtn.Name = "teacherbtn";
            this.teacherbtn.Normalcolor = System.Drawing.Color.Transparent;
            this.teacherbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(209)))), ((int)(((byte)(72)))));
            this.teacherbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.teacherbtn.selected = false;
            this.teacherbtn.Size = new System.Drawing.Size(148, 37);
            this.teacherbtn.TabIndex = 3;
            this.teacherbtn.Text = "Teachers";
            this.teacherbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.teacherbtn.Textcolor = System.Drawing.Color.White;
            this.teacherbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherbtn.Click += new System.EventHandler(this.teacherbtn_Click);
            // 
            // subjectbtn
            // 
            this.subjectbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(61)))), ((int)(((byte)(179)))));
            this.subjectbtn.BackColor = System.Drawing.Color.Transparent;
            this.subjectbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.subjectbtn.BorderRadius = 0;
            this.subjectbtn.ButtonText = "Subjects";
            this.subjectbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subjectbtn.DisabledColor = System.Drawing.Color.Gray;
            this.subjectbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.subjectbtn.Iconimage = global::Temp.Properties.Resources.Subject;
            this.subjectbtn.Iconimage_right = null;
            this.subjectbtn.Iconimage_right_Selected = null;
            this.subjectbtn.Iconimage_Selected = null;
            this.subjectbtn.IconMarginLeft = 0;
            this.subjectbtn.IconMarginRight = 0;
            this.subjectbtn.IconRightVisible = true;
            this.subjectbtn.IconRightZoom = 0D;
            this.subjectbtn.IconVisible = true;
            this.subjectbtn.IconZoom = 54D;
            this.subjectbtn.IsTab = true;
            this.subjectbtn.Location = new System.Drawing.Point(5, 48);
            this.subjectbtn.Name = "subjectbtn";
            this.subjectbtn.Normalcolor = System.Drawing.Color.Transparent;
            this.subjectbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(209)))), ((int)(((byte)(72)))));
            this.subjectbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.subjectbtn.selected = false;
            this.subjectbtn.Size = new System.Drawing.Size(148, 37);
            this.subjectbtn.TabIndex = 2;
            this.subjectbtn.Text = "Subjects";
            this.subjectbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subjectbtn.Textcolor = System.Drawing.Color.White;
            this.subjectbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectbtn.Click += new System.EventHandler(this.subjectbtn_Click);
            // 
            // content_panel
            // 
            this.content_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("content_panel.BackgroundImage")));
            this.content_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.content_panel.GradientBottomLeft = System.Drawing.Color.White;
            this.content_panel.GradientBottomRight = System.Drawing.Color.White;
            this.content_panel.GradientTopLeft = System.Drawing.Color.White;
            this.content_panel.GradientTopRight = System.Drawing.Color.White;
            this.content_panel.Location = new System.Drawing.Point(160, 80);
            this.content_panel.Name = "content_panel";
            this.content_panel.Quality = 10;
            this.content_panel.Size = new System.Drawing.Size(543, 390);
            this.content_panel.TabIndex = 8;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(1, 62);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(702, 35);
            this.bunifuSeparator1.TabIndex = 9;
            this.bunifuSeparator1.Transparency = 100;
            this.bunifuSeparator1.Vertical = false;
            // 
            // Aboutbtn
            // 
            this.Aboutbtn.ActiveBorderThickness = 1;
            this.Aboutbtn.ActiveCornerRadius = 4;
            this.Aboutbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Aboutbtn.ActiveForecolor = System.Drawing.Color.White;
            this.Aboutbtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Aboutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Aboutbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Aboutbtn.BackgroundImage")));
            this.Aboutbtn.ButtonText = "  About ";
            this.Aboutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aboutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Aboutbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Aboutbtn.IdleBorderThickness = 1;
            this.Aboutbtn.IdleCornerRadius = 10;
            this.Aboutbtn.IdleFillColor = System.Drawing.Color.White;
            this.Aboutbtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Aboutbtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Aboutbtn.Location = new System.Drawing.Point(592, 5);
            this.Aboutbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Aboutbtn.Name = "Aboutbtn";
            this.Aboutbtn.Size = new System.Drawing.Size(51, 26);
            this.Aboutbtn.TabIndex = 10;
            this.Aboutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Aboutbtn.Click += new System.EventHandler(this.Aboutbtn_Click);
            // 
            // Ntecc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Temp.Properties.Resources.Transparent;
            this.ClientSize = new System.Drawing.Size(703, 472);
            this.Controls.Add(this.Aboutbtn);
            this.Controls.Add(this.left_panel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.content_panel);
            this.Controls.Add(this.bunifuSeparator1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Ntecc";
            this.Resizable = false;
            this.Text = "                    Aspire 2 International";
            this.TransparencyKey = System.Drawing.Color.LightSlateGray;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.left_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton coursebtn;
        private Bunifu.Framework.UI.BunifuGradientPanel left_panel;
        private Bunifu.Framework.UI.BunifuFlatButton teacherbtn;
        private Bunifu.Framework.UI.BunifuFlatButton subjectbtn;
        private Bunifu.Framework.UI.BunifuFlatButton studentbtn;
        private Bunifu.Framework.UI.BunifuFlatButton generatebtn;
        private Bunifu.Framework.UI.BunifuGradientPanel content_panel;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton roombtn;
        private Bunifu.Framework.UI.BunifuThinButton2 Aboutbtn;
        private Bunifu.Framework.UI.BunifuFlatButton levelbtn;
    }
}

