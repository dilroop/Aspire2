namespace Temp
{
    partial class AddCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourse));
            this.course_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.course_level = new MetroFramework.Controls.MetroComboBox();
            this.Addcoursebtn = new MetroFramework.Controls.MetroButton();
            this.message = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.course_strength = new MetroFramework.Controls.MetroTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // course_name
            // 
            this.course_name.Lines = new string[] {
        "Diploma in"};
            this.course_name.Location = new System.Drawing.Point(136, 64);
            this.course_name.MaxLength = 32767;
            this.course_name.Name = "course_name";
            this.course_name.PasswordChar = '\0';
            this.course_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.course_name.SelectedText = "";
            this.course_name.Size = new System.Drawing.Size(157, 23);
            this.course_name.TabIndex = 0;
            this.course_name.Text = "Diploma in";
            this.course_name.UseSelectable = true;
            this.course_name.Validating += new System.ComponentModel.CancelEventHandler(this.course_name_Validating);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Course Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 103);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Course Level";
            // 
            // course_level
            // 
            this.course_level.FormattingEnabled = true;
            this.course_level.ItemHeight = 23;
            this.course_level.Location = new System.Drawing.Point(136, 99);
            this.course_level.Name = "course_level";
            this.course_level.Size = new System.Drawing.Size(157, 29);
            this.course_level.TabIndex = 4;
            this.course_level.UseSelectable = true;
            this.course_level.Validating += new System.ComponentModel.CancelEventHandler(this.course_level_Validating);
            // 
            // Addcoursebtn
            // 
            this.Addcoursebtn.Location = new System.Drawing.Point(136, 189);
            this.Addcoursebtn.Name = "Addcoursebtn";
            this.Addcoursebtn.Size = new System.Drawing.Size(75, 23);
            this.Addcoursebtn.TabIndex = 9;
            this.Addcoursebtn.Text = "Add";
            this.Addcoursebtn.UseSelectable = true;
            this.Addcoursebtn.Click += new System.EventHandler(this.Addcoursebtn_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(222, 193);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(12, 19);
            this.message.TabIndex = 10;
            this.message.Text = ".";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 140);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(99, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "No Of Students";
            // 
            // course_strength
            // 
            this.course_strength.Lines = new string[0];
            this.course_strength.Location = new System.Drawing.Point(136, 140);
            this.course_strength.MaxLength = 32767;
            this.course_strength.Name = "course_strength";
            this.course_strength.PasswordChar = '\0';
            this.course_strength.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.course_strength.SelectedText = "";
            this.course_strength.Size = new System.Drawing.Size(52, 23);
            this.course_strength.TabIndex = 12;
            this.course_strength.UseSelectable = true;
            this.course_strength.Validating += new System.ComponentModel.CancelEventHandler(this.course_strength_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(332, 235);
            this.Controls.Add(this.course_strength);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.message);
            this.Controls.Add(this.Addcoursebtn);
            this.Controls.Add(this.course_level);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.course_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCourse";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Add New Course";
            this.TransparencyKey = System.Drawing.Color.Empty;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox course_name;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox course_level;
        private MetroFramework.Controls.MetroButton Addcoursebtn;
        private MetroFramework.Controls.MetroLabel message;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox course_strength;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}