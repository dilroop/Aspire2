namespace Temp
{
    partial class EditStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudent));
            this.savebtn = new MetroFramework.Controls.MetroButton();
            this.course_combo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.student_email = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.student_studentID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.student_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // savebtn
            // 
            this.savebtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.savebtn.Location = new System.Drawing.Point(117, 234);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 30;
            this.savebtn.Text = "Save";
            this.savebtn.UseSelectable = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // course_combo
            // 
            this.course_combo.FormattingEnabled = true;
            this.course_combo.ItemHeight = 23;
            this.course_combo.Location = new System.Drawing.Point(117, 183);
            this.course_combo.Name = "course_combo";
            this.course_combo.Size = new System.Drawing.Size(155, 29);
            this.course_combo.TabIndex = 29;
            this.course_combo.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(22, 183);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(50, 19);
            this.metroLabel5.TabIndex = 28;
            this.metroLabel5.Text = "Course";
            // 
            // student_email
            // 
            this.student_email.Lines = new string[0];
            this.student_email.Location = new System.Drawing.Point(117, 138);
            this.student_email.MaxLength = 32767;
            this.student_email.Name = "student_email";
            this.student_email.PasswordChar = '\0';
            this.student_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.student_email.SelectedText = "";
            this.student_email.Size = new System.Drawing.Size(155, 23);
            this.student_email.TabIndex = 27;
            this.student_email.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(22, 142);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 19);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Email";
            // 
            // student_studentID
            // 
            this.student_studentID.Lines = new string[0];
            this.student_studentID.Location = new System.Drawing.Point(117, 102);
            this.student_studentID.MaxLength = 32767;
            this.student_studentID.Name = "student_studentID";
            this.student_studentID.PasswordChar = '\0';
            this.student_studentID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.student_studentID.SelectedText = "";
            this.student_studentID.Size = new System.Drawing.Size(155, 23);
            this.student_studentID.TabIndex = 25;
            this.student_studentID.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(22, 106);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "StudentID";
            // 
            // student_name
            // 
            this.student_name.Lines = new string[0];
            this.student_name.Location = new System.Drawing.Point(117, 63);
            this.student_name.MaxLength = 32767;
            this.student_name.Name = "student_name";
            this.student_name.PasswordChar = '\0';
            this.student_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.student_name.SelectedText = "";
            this.student_name.Size = new System.Drawing.Size(155, 23);
            this.student_name.TabIndex = 23;
            this.student_name.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 68);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 22;
            this.metroLabel1.Text = "Name";
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 281);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.course_combo);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.student_email);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.student_studentID);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.student_name);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditStudent";
            this.Resizable = false;
            this.Text = "Edit Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton savebtn;
        private MetroFramework.Controls.MetroComboBox course_combo;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox student_email;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox student_studentID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox student_name;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}