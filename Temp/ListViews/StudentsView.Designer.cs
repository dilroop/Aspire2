namespace Temp.ListViews
{
    partial class StudentsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.student_id = new MetroFramework.Controls.MetroLabel();
            this.deletebtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.editbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.course_name = new MetroFramework.Controls.MetroLabel();
            this.student_name = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.deletebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // student_id
            // 
            this.student_id.Location = new System.Drawing.Point(335, 6);
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(128, 19);
            this.student_id.TabIndex = 9;
            this.student_id.Text = "YTI000001a";
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Transparent;
            this.deletebtn.Image = global::Temp.Properties.Resources.delete21;
            this.deletebtn.ImageActive = null;
            this.deletebtn.Location = new System.Drawing.Point(510, 5);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(20, 20);
            this.deletebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deletebtn.TabIndex = 8;
            this.deletebtn.TabStop = false;
            this.deletebtn.Zoom = 10;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.Transparent;
            this.editbtn.Image = global::Temp.Properties.Resources.Edit_48px;
            this.editbtn.ImageActive = null;
            this.editbtn.Location = new System.Drawing.Point(484, 6);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(20, 20);
            this.editbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editbtn.TabIndex = 7;
            this.editbtn.TabStop = false;
            this.editbtn.Zoom = 10;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // course_name
            // 
            this.course_name.Location = new System.Drawing.Point(152, 5);
            this.course_name.Name = "course_name";
            this.course_name.Size = new System.Drawing.Size(177, 19);
            this.course_name.TabIndex = 6;
            this.course_name.Text = "COURSE NAME";
            // 
            // student_name
            // 
            this.student_name.Location = new System.Drawing.Point(6, 6);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(140, 19);
            this.student_name.TabIndex = 5;
            this.student_name.Text = "STUDENT NAME";
            // 
            // StudentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.student_id);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.course_name);
            this.Controls.Add(this.student_name);
            this.Name = "StudentsView";
            this.Size = new System.Drawing.Size(536, 30);
            ((System.ComponentModel.ISupportInitialize)(this.deletebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editbtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel student_id;
        private Bunifu.Framework.UI.BunifuImageButton deletebtn;
        private Bunifu.Framework.UI.BunifuImageButton editbtn;
        private MetroFramework.Controls.MetroLabel course_name;
        private MetroFramework.Controls.MetroLabel student_name;
    }
}
