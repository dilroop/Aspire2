namespace Temp
{
    partial class EditSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSubject));
            this.savebtn = new MetroFramework.Controls.MetroButton();
            this.course_combo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.subject_credits = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.subject_hours = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.subject_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.message = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // savebtn
            // 
            this.savebtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.savebtn.Location = new System.Drawing.Point(156, 199);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 22;
            this.savebtn.Text = "Save";
            this.savebtn.UseSelectable = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // course_combo
            // 
            this.course_combo.FormattingEnabled = true;
            this.course_combo.ItemHeight = 23;
            this.course_combo.Location = new System.Drawing.Point(107, 144);
            this.course_combo.Name = "course_combo";
            this.course_combo.Size = new System.Drawing.Size(250, 29);
            this.course_combo.TabIndex = 21;
            this.course_combo.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(32, 144);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(50, 19);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "Course";
            // 
            // subject_credits
            // 
            this.subject_credits.Lines = new string[0];
            this.subject_credits.Location = new System.Drawing.Point(314, 105);
            this.subject_credits.MaxLength = 32767;
            this.subject_credits.Name = "subject_credits";
            this.subject_credits.PasswordChar = '\0';
            this.subject_credits.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.subject_credits.SelectedText = "";
            this.subject_credits.Size = new System.Drawing.Size(43, 23);
            this.subject_credits.TabIndex = 19;
            this.subject_credits.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(238, 105);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Credits";
            // 
            // subject_hours
            // 
            this.subject_hours.Lines = new string[0];
            this.subject_hours.Location = new System.Drawing.Point(107, 105);
            this.subject_hours.MaxLength = 32767;
            this.subject_hours.Name = "subject_hours";
            this.subject_hours.PasswordChar = '\0';
            this.subject_hours.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.subject_hours.SelectedText = "";
            this.subject_hours.Size = new System.Drawing.Size(44, 23);
            this.subject_hours.TabIndex = 17;
            this.subject_hours.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 105);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Hours";
            // 
            // subject_name
            // 
            this.subject_name.Lines = new string[0];
            this.subject_name.Location = new System.Drawing.Point(107, 66);
            this.subject_name.MaxLength = 32767;
            this.subject_name.Name = "subject_name";
            this.subject_name.PasswordChar = '\0';
            this.subject_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.subject_name.SelectedText = "";
            this.subject_name.Size = new System.Drawing.Size(250, 23);
            this.subject_name.TabIndex = 15;
            this.subject_name.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Name";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(237, 199);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(12, 19);
            this.message.TabIndex = 23;
            this.message.Text = ".";
            // 
            // EditSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 248);
            this.Controls.Add(this.message);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.course_combo);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.subject_credits);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.subject_hours);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.subject_name);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditSubject";
            this.Resizable = false;
            this.Text = "Edit Subject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton savebtn;
        private MetroFramework.Controls.MetroComboBox course_combo;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox subject_credits;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox subject_hours;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox subject_name;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel message;
    }
}