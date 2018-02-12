namespace Temp
{
    partial class AddTeacher
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeacher));
            this.Addcoursebtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.teacher_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mon_f = new Bunifu.Framework.UI.BunifuCheckbox();
            this.tues_f = new Bunifu.Framework.UI.BunifuCheckbox();
            this.wed_f = new Bunifu.Framework.UI.BunifuCheckbox();
            this.thur_f = new Bunifu.Framework.UI.BunifuCheckbox();
            this.fri_f = new Bunifu.Framework.UI.BunifuCheckbox();
            this.sat_f = new Bunifu.Framework.UI.BunifuCheckbox();
            this.sun_f = new Bunifu.Framework.UI.BunifuCheckbox();
            this.sun_s = new Bunifu.Framework.UI.BunifuCheckbox();
            this.sat_s = new Bunifu.Framework.UI.BunifuCheckbox();
            this.fri_s = new Bunifu.Framework.UI.BunifuCheckbox();
            this.thur_s = new Bunifu.Framework.UI.BunifuCheckbox();
            this.wed_s = new Bunifu.Framework.UI.BunifuCheckbox();
            this.tues_s = new Bunifu.Framework.UI.BunifuCheckbox();
            this.mon_s = new Bunifu.Framework.UI.BunifuCheckbox();
            this.teacher_email = new MetroFramework.Controls.MetroTextBox();
            this.teacher_contact = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Addcoursebtn
            // 
            this.Addcoursebtn.Location = new System.Drawing.Point(123, 328);
            this.Addcoursebtn.Name = "Addcoursebtn";
            this.Addcoursebtn.Size = new System.Drawing.Size(75, 23);
            this.Addcoursebtn.TabIndex = 14;
            this.Addcoursebtn.Text = "Add";
            this.Addcoursebtn.UseSelectable = true;
            this.Addcoursebtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 110);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Email";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Name";
            // 
            // teacher_name
            // 
            this.teacher_name.Lines = new string[0];
            this.teacher_name.Location = new System.Drawing.Point(99, 71);
            this.teacher_name.MaxLength = 32767;
            this.teacher_name.Name = "teacher_name";
            this.teacher_name.PasswordChar = '\0';
            this.teacher_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.teacher_name.SelectedText = "";
            this.teacher_name.Size = new System.Drawing.Size(157, 23);
            this.teacher_name.TabIndex = 10;
            this.teacher_name.UseSelectable = true;
            this.teacher_name.Validating += new System.ComponentModel.CancelEventHandler(this.teacher_name_Validating);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 200);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Availability";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 227);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(259, 19);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Mon   Tues    Wed    Thur    Fri    Sat    Sun";
            // 
            // mon_f
            // 
            this.mon_f.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.mon_f.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.mon_f.Checked = true;
            this.mon_f.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.mon_f.ForeColor = System.Drawing.Color.White;
            this.mon_f.Location = new System.Drawing.Point(31, 252);
            this.mon_f.Name = "mon_f";
            this.mon_f.Size = new System.Drawing.Size(20, 20);
            this.mon_f.TabIndex = 17;
            // 
            // tues_f
            // 
            this.tues_f.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.tues_f.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.tues_f.Checked = true;
            this.tues_f.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.tues_f.ForeColor = System.Drawing.Color.White;
            this.tues_f.Location = new System.Drawing.Point(68, 252);
            this.tues_f.Name = "tues_f";
            this.tues_f.Size = new System.Drawing.Size(20, 20);
            this.tues_f.TabIndex = 18;
            // 
            // wed_f
            // 
            this.wed_f.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.wed_f.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.wed_f.Checked = true;
            this.wed_f.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.wed_f.ForeColor = System.Drawing.Color.White;
            this.wed_f.Location = new System.Drawing.Point(109, 252);
            this.wed_f.Name = "wed_f";
            this.wed_f.Size = new System.Drawing.Size(20, 20);
            this.wed_f.TabIndex = 19;
            // 
            // thur_f
            // 
            this.thur_f.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.thur_f.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.thur_f.Checked = true;
            this.thur_f.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.thur_f.ForeColor = System.Drawing.Color.White;
            this.thur_f.Location = new System.Drawing.Point(149, 252);
            this.thur_f.Name = "thur_f";
            this.thur_f.Size = new System.Drawing.Size(20, 20);
            this.thur_f.TabIndex = 20;
            // 
            // fri_f
            // 
            this.fri_f.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.fri_f.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.fri_f.Checked = true;
            this.fri_f.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.fri_f.ForeColor = System.Drawing.Color.White;
            this.fri_f.Location = new System.Drawing.Point(189, 252);
            this.fri_f.Name = "fri_f";
            this.fri_f.Size = new System.Drawing.Size(20, 20);
            this.fri_f.TabIndex = 21;
            // 
            // sat_f
            // 
            this.sat_f.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.sat_f.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.sat_f.Checked = true;
            this.sat_f.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.sat_f.ForeColor = System.Drawing.Color.White;
            this.sat_f.Location = new System.Drawing.Point(222, 252);
            this.sat_f.Name = "sat_f";
            this.sat_f.Size = new System.Drawing.Size(20, 20);
            this.sat_f.TabIndex = 22;
            // 
            // sun_f
            // 
            this.sun_f.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.sun_f.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.sun_f.Checked = true;
            this.sun_f.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.sun_f.ForeColor = System.Drawing.Color.White;
            this.sun_f.Location = new System.Drawing.Point(259, 252);
            this.sun_f.Name = "sun_f";
            this.sun_f.Size = new System.Drawing.Size(20, 20);
            this.sun_f.TabIndex = 23;
            // 
            // sun_s
            // 
            this.sun_s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.sun_s.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.sun_s.Checked = true;
            this.sun_s.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.sun_s.ForeColor = System.Drawing.Color.White;
            this.sun_s.Location = new System.Drawing.Point(259, 280);
            this.sun_s.Name = "sun_s";
            this.sun_s.Size = new System.Drawing.Size(20, 20);
            this.sun_s.TabIndex = 30;
            // 
            // sat_s
            // 
            this.sat_s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.sat_s.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.sat_s.Checked = true;
            this.sat_s.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.sat_s.ForeColor = System.Drawing.Color.White;
            this.sat_s.Location = new System.Drawing.Point(222, 280);
            this.sat_s.Name = "sat_s";
            this.sat_s.Size = new System.Drawing.Size(20, 20);
            this.sat_s.TabIndex = 29;
            // 
            // fri_s
            // 
            this.fri_s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.fri_s.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.fri_s.Checked = true;
            this.fri_s.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.fri_s.ForeColor = System.Drawing.Color.White;
            this.fri_s.Location = new System.Drawing.Point(189, 280);
            this.fri_s.Name = "fri_s";
            this.fri_s.Size = new System.Drawing.Size(20, 20);
            this.fri_s.TabIndex = 28;
            // 
            // thur_s
            // 
            this.thur_s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.thur_s.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.thur_s.Checked = true;
            this.thur_s.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.thur_s.ForeColor = System.Drawing.Color.White;
            this.thur_s.Location = new System.Drawing.Point(149, 280);
            this.thur_s.Name = "thur_s";
            this.thur_s.Size = new System.Drawing.Size(20, 20);
            this.thur_s.TabIndex = 27;
            // 
            // wed_s
            // 
            this.wed_s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.wed_s.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.wed_s.Checked = true;
            this.wed_s.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.wed_s.ForeColor = System.Drawing.Color.White;
            this.wed_s.Location = new System.Drawing.Point(109, 280);
            this.wed_s.Name = "wed_s";
            this.wed_s.Size = new System.Drawing.Size(20, 20);
            this.wed_s.TabIndex = 26;
            // 
            // tues_s
            // 
            this.tues_s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.tues_s.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.tues_s.Checked = true;
            this.tues_s.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.tues_s.ForeColor = System.Drawing.Color.White;
            this.tues_s.Location = new System.Drawing.Point(68, 280);
            this.tues_s.Name = "tues_s";
            this.tues_s.Size = new System.Drawing.Size(20, 20);
            this.tues_s.TabIndex = 25;
            // 
            // mon_s
            // 
            this.mon_s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.mon_s.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.mon_s.Checked = true;
            this.mon_s.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.mon_s.ForeColor = System.Drawing.Color.White;
            this.mon_s.Location = new System.Drawing.Point(31, 280);
            this.mon_s.Name = "mon_s";
            this.mon_s.Size = new System.Drawing.Size(20, 20);
            this.mon_s.TabIndex = 24;
            // 
            // teacher_email
            // 
            this.teacher_email.Lines = new string[0];
            this.teacher_email.Location = new System.Drawing.Point(99, 110);
            this.teacher_email.MaxLength = 32767;
            this.teacher_email.Name = "teacher_email";
            this.teacher_email.PasswordChar = '\0';
            this.teacher_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.teacher_email.SelectedText = "";
            this.teacher_email.Size = new System.Drawing.Size(157, 23);
            this.teacher_email.TabIndex = 31;
            this.teacher_email.UseSelectable = true;
            this.teacher_email.Validating += new System.ComponentModel.CancelEventHandler(this.teacher_email_Validating);
            // 
            // teacher_contact
            // 
            this.teacher_contact.Lines = new string[0];
            this.teacher_contact.Location = new System.Drawing.Point(99, 151);
            this.teacher_contact.MaxLength = 32767;
            this.teacher_contact.Name = "teacher_contact";
            this.teacher_contact.PasswordChar = '\0';
            this.teacher_contact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.teacher_contact.SelectedText = "";
            this.teacher_contact.Size = new System.Drawing.Size(157, 23);
            this.teacher_contact.TabIndex = 33;
            this.teacher_contact.UseSelectable = true;
            this.teacher_contact.Validating += new System.ComponentModel.CancelEventHandler(this.teacher_contact_Validating);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 151);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(54, 19);
            this.metroLabel5.TabIndex = 32;
            this.metroLabel5.Text = "Contact";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(320, 374);
            this.Controls.Add(this.teacher_contact);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.teacher_email);
            this.Controls.Add(this.sun_s);
            this.Controls.Add(this.sat_s);
            this.Controls.Add(this.fri_s);
            this.Controls.Add(this.thur_s);
            this.Controls.Add(this.wed_s);
            this.Controls.Add(this.tues_s);
            this.Controls.Add(this.mon_s);
            this.Controls.Add(this.sun_f);
            this.Controls.Add(this.sat_f);
            this.Controls.Add(this.fri_f);
            this.Controls.Add(this.thur_f);
            this.Controls.Add(this.wed_f);
            this.Controls.Add(this.tues_f);
            this.Controls.Add(this.mon_f);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.Addcoursebtn);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.teacher_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddTeacher";
            this.Resizable = false;
            this.Text = "Add Teacher";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Addcoursebtn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox teacher_name;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private Bunifu.Framework.UI.BunifuCheckbox mon_f;
        private Bunifu.Framework.UI.BunifuCheckbox tues_f;
        private Bunifu.Framework.UI.BunifuCheckbox wed_f;
        private Bunifu.Framework.UI.BunifuCheckbox thur_f;
        private Bunifu.Framework.UI.BunifuCheckbox fri_f;
        private Bunifu.Framework.UI.BunifuCheckbox sat_f;
        private Bunifu.Framework.UI.BunifuCheckbox sun_f;
        private Bunifu.Framework.UI.BunifuCheckbox sun_s;
        private Bunifu.Framework.UI.BunifuCheckbox sat_s;
        private Bunifu.Framework.UI.BunifuCheckbox fri_s;
        private Bunifu.Framework.UI.BunifuCheckbox thur_s;
        private Bunifu.Framework.UI.BunifuCheckbox wed_s;
        private Bunifu.Framework.UI.BunifuCheckbox tues_s;
        private Bunifu.Framework.UI.BunifuCheckbox mon_s;
        private MetroFramework.Controls.MetroTextBox teacher_email;
        private MetroFramework.Controls.MetroTextBox teacher_contact;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}