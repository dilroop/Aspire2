namespace Temp
{
    partial class EditCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCourse));
            this.message = new MetroFramework.Controls.MetroLabel();
            this.Savebtn = new MetroFramework.Controls.MetroButton();
            this.course_level = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.course_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.course_strength = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(225, 178);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(12, 19);
            this.message.TabIndex = 16;
            this.message.Text = ".";
            // 
            // Savebtn
            // 
            this.Savebtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Savebtn.Location = new System.Drawing.Point(139, 189);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 15;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseSelectable = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // course_level
            // 
            this.course_level.FormattingEnabled = true;
            this.course_level.ItemHeight = 23;
            this.course_level.Items.AddRange(new object[] {
            "Level 5",
            "Level 6",
            "Level 7"});
            this.course_level.Location = new System.Drawing.Point(139, 101);
            this.course_level.Name = "course_level";
            this.course_level.Size = new System.Drawing.Size(157, 29);
            this.course_level.TabIndex = 14;
            this.course_level.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(26, 105);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Course Level";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Course Name";
            // 
            // course_name
            // 
            this.course_name.Lines = new string[0];
            this.course_name.Location = new System.Drawing.Point(139, 66);
            this.course_name.MaxLength = 32767;
            this.course_name.Name = "course_name";
            this.course_name.PasswordChar = '\0';
            this.course_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.course_name.SelectedText = "";
            this.course_name.Size = new System.Drawing.Size(157, 23);
            this.course_name.TabIndex = 11;
            this.course_name.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(26, 142);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "No of Students";
            // 
            // course_strength
            // 
            this.course_strength.Lines = new string[0];
            this.course_strength.Location = new System.Drawing.Point(139, 142);
            this.course_strength.MaxLength = 32767;
            this.course_strength.Name = "course_strength";
            this.course_strength.PasswordChar = '\0';
            this.course_strength.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.course_strength.SelectedText = "";
            this.course_strength.Size = new System.Drawing.Size(49, 23);
            this.course_strength.TabIndex = 18;
            this.course_strength.UseSelectable = true;
            // 
            // EditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 228);
            this.Controls.Add(this.course_strength);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.message);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.course_level);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.course_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCourse";
            this.Resizable = false;
            this.Text = "Edit Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel message;
        private MetroFramework.Controls.MetroButton Savebtn;
        private MetroFramework.Controls.MetroComboBox course_level;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox course_name;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox course_strength;
    }
}