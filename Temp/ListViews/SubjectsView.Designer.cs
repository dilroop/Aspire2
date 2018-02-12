namespace Temp.ListViews
{
    partial class SubjectsView
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
            this.subject_credits_lbl = new MetroFramework.Controls.MetroLabel();
            this.deletebtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.editbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.subject_hour_lbl = new MetroFramework.Controls.MetroLabel();
            this.subject_name_lbl = new MetroFramework.Controls.MetroLabel();
            this.course_name_lbl = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.deletebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // subject_credits_lbl
            // 
            this.subject_credits_lbl.AutoSize = true;
            this.subject_credits_lbl.Location = new System.Drawing.Point(414, 6);
            this.subject_credits_lbl.Name = "subject_credits_lbl";
            this.subject_credits_lbl.Size = new System.Drawing.Size(23, 19);
            this.subject_credits_lbl.TabIndex = 9;
            this.subject_credits_lbl.Text = "56";
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
            // subject_hour_lbl
            // 
            this.subject_hour_lbl.AutoSize = true;
            this.subject_hour_lbl.Location = new System.Drawing.Point(385, 5);
            this.subject_hour_lbl.Name = "subject_hour_lbl";
            this.subject_hour_lbl.Size = new System.Drawing.Size(23, 19);
            this.subject_hour_lbl.TabIndex = 6;
            this.subject_hour_lbl.Text = "6h";
            // 
            // subject_name_lbl
            // 
            this.subject_name_lbl.Location = new System.Drawing.Point(6, 6);
            this.subject_name_lbl.Name = "subject_name_lbl";
            this.subject_name_lbl.Size = new System.Drawing.Size(205, 19);
            this.subject_name_lbl.TabIndex = 5;
            this.subject_name_lbl.Text = "Subject Name";
            // 
            // course_name_lbl
            // 
            this.course_name_lbl.Location = new System.Drawing.Point(217, 5);
            this.course_name_lbl.Name = "course_name_lbl";
            this.course_name_lbl.Size = new System.Drawing.Size(162, 19);
            this.course_name_lbl.TabIndex = 10;
            this.course_name_lbl.Text = "Subject Name";
            // 
            // SubjectsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.course_name_lbl);
            this.Controls.Add(this.subject_credits_lbl);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.subject_hour_lbl);
            this.Controls.Add(this.subject_name_lbl);
            this.Name = "SubjectsView";
            this.Size = new System.Drawing.Size(536, 30);
            ((System.ComponentModel.ISupportInitialize)(this.deletebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel subject_credits_lbl;
        private Bunifu.Framework.UI.BunifuImageButton deletebtn;
        private Bunifu.Framework.UI.BunifuImageButton editbtn;
        private MetroFramework.Controls.MetroLabel subject_hour_lbl;
        private MetroFramework.Controls.MetroLabel subject_name_lbl;
        private MetroFramework.Controls.MetroLabel course_name_lbl;
    }
}
