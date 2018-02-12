namespace Temp.ListViews
{
    partial class CoursesView
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
            this.course_name_lbl = new MetroFramework.Controls.MetroLabel();
            this.course_level_lbl = new MetroFramework.Controls.MetroLabel();
            this.deletebtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.editbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.strength = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.deletebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // course_name_lbl
            // 
            this.course_name_lbl.Location = new System.Drawing.Point(7, 6);
            this.course_name_lbl.Name = "course_name_lbl";
            this.course_name_lbl.Size = new System.Drawing.Size(317, 19);
            this.course_name_lbl.TabIndex = 0;
            this.course_name_lbl.Text = "COURSE NAME";
            // 
            // course_level_lbl
            // 
            this.course_level_lbl.AutoSize = true;
            this.course_level_lbl.Location = new System.Drawing.Point(340, 5);
            this.course_level_lbl.Name = "course_level_lbl";
            this.course_level_lbl.Size = new System.Drawing.Size(55, 19);
            this.course_level_lbl.TabIndex = 1;
            this.course_level_lbl.Text = "LEVEL X";
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Transparent;
            this.deletebtn.Image = global::Temp.Properties.Resources.delete21;
            this.deletebtn.ImageActive = null;
            this.deletebtn.Location = new System.Drawing.Point(511, 5);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(20, 20);
            this.deletebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deletebtn.TabIndex = 3;
            this.deletebtn.TabStop = false;
            this.deletebtn.Zoom = 10;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.Transparent;
            this.editbtn.Image = global::Temp.Properties.Resources.Edit_48px;
            this.editbtn.ImageActive = null;
            this.editbtn.Location = new System.Drawing.Point(485, 6);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(20, 20);
            this.editbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editbtn.TabIndex = 2;
            this.editbtn.TabStop = false;
            this.editbtn.Zoom = 10;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // strength
            // 
            this.strength.AutoSize = true;
            this.strength.Location = new System.Drawing.Point(415, 6);
            this.strength.Name = "strength";
            this.strength.Size = new System.Drawing.Size(23, 19);
            this.strength.TabIndex = 4;
            this.strength.Text = "56";
            // 
            // CoursesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.strength);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.course_level_lbl);
            this.Controls.Add(this.course_name_lbl);
            this.Name = "CoursesView";
            this.Size = new System.Drawing.Size(536, 30);
            ((System.ComponentModel.ISupportInitialize)(this.deletebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel course_name_lbl;
        private MetroFramework.Controls.MetroLabel course_level_lbl;
        private Bunifu.Framework.UI.BunifuImageButton editbtn;
        private Bunifu.Framework.UI.BunifuImageButton deletebtn;
        private MetroFramework.Controls.MetroLabel strength;
    }
}
