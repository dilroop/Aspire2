namespace Temp
{
    partial class AddSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSubject));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.subject_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.subject_hours = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.subject_credits = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.course_combo = new MetroFramework.Controls.MetroComboBox();
            this.addbtn = new MetroFramework.Controls.MetroButton();
            this.message = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Name";
            // 
            // subject_name
            // 
            this.subject_name.Lines = new string[0];
            this.subject_name.Location = new System.Drawing.Point(101, 67);
            this.subject_name.MaxLength = 32767;
            this.subject_name.Name = "subject_name";
            this.subject_name.PasswordChar = '\0';
            this.subject_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.subject_name.SelectedText = "";
            this.subject_name.Size = new System.Drawing.Size(250, 23);
            this.subject_name.TabIndex = 1;
            this.subject_name.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(26, 106);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Hours";
            // 
            // subject_hours
            // 
            this.subject_hours.Lines = new string[0];
            this.subject_hours.Location = new System.Drawing.Point(101, 106);
            this.subject_hours.MaxLength = 32767;
            this.subject_hours.Name = "subject_hours";
            this.subject_hours.PasswordChar = '\0';
            this.subject_hours.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.subject_hours.SelectedText = "";
            this.subject_hours.Size = new System.Drawing.Size(44, 23);
            this.subject_hours.TabIndex = 3;
            this.subject_hours.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(232, 106);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Credits";
            // 
            // subject_credits
            // 
            this.subject_credits.Lines = new string[0];
            this.subject_credits.Location = new System.Drawing.Point(308, 106);
            this.subject_credits.MaxLength = 32767;
            this.subject_credits.Name = "subject_credits";
            this.subject_credits.PasswordChar = '\0';
            this.subject_credits.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.subject_credits.SelectedText = "";
            this.subject_credits.Size = new System.Drawing.Size(43, 23);
            this.subject_credits.TabIndex = 5;
            this.subject_credits.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(26, 145);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(50, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Course";
            // 
            // course_combo
            // 
            this.course_combo.FormattingEnabled = true;
            this.course_combo.ItemHeight = 23;
            this.course_combo.Location = new System.Drawing.Point(101, 145);
            this.course_combo.Name = "course_combo";
            this.course_combo.Size = new System.Drawing.Size(250, 29);
            this.course_combo.TabIndex = 9;
            this.course_combo.UseSelectable = true;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(150, 200);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 12;
            this.addbtn.Text = "Add";
            this.addbtn.UseSelectable = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(231, 200);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(12, 19);
            this.message.TabIndex = 13;
            this.message.Text = ".";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(389, 248);
            this.Controls.Add(this.message);
            this.Controls.Add(this.addbtn);
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
            this.Name = "AddSubject";
            this.Resizable = false;
            this.Text = "Add New Subject";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox subject_name;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox subject_hours;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox subject_credits;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox course_combo;
        private MetroFramework.Controls.MetroButton addbtn;
        private MetroFramework.Controls.MetroLabel message;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}