namespace Temp
{
    partial class TeacherView
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
            this.teacher_contact_lbl = new MetroFramework.Controls.MetroLabel();
            this.teacher_name_lbl = new MetroFramework.Controls.MetroLabel();
            this.deletebtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.editbtn = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.deletebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // teacher_contact_lbl
            // 
            this.teacher_contact_lbl.AutoSize = true;
            this.teacher_contact_lbl.Location = new System.Drawing.Point(139, 5);
            this.teacher_contact_lbl.Name = "teacher_contact_lbl";
            this.teacher_contact_lbl.Size = new System.Drawing.Size(54, 19);
            this.teacher_contact_lbl.TabIndex = 6;
            this.teacher_contact_lbl.Text = "Contact";
            // 
            // teacher_name_lbl
            // 
            this.teacher_name_lbl.Location = new System.Drawing.Point(6, 6);
            this.teacher_name_lbl.Name = "teacher_name_lbl";
            this.teacher_name_lbl.Size = new System.Drawing.Size(112, 19);
            this.teacher_name_lbl.TabIndex = 5;
            this.teacher_name_lbl.Text = "Teacher Name";
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
            // TeacherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.teacher_contact_lbl);
            this.Controls.Add(this.teacher_name_lbl);
            this.Name = "TeacherView";
            this.Size = new System.Drawing.Size(536, 30);
            ((System.ComponentModel.ISupportInitialize)(this.deletebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton deletebtn;
        private Bunifu.Framework.UI.BunifuImageButton editbtn;
        private MetroFramework.Controls.MetroLabel teacher_contact_lbl;
        private MetroFramework.Controls.MetroLabel teacher_name_lbl;
    }
}
