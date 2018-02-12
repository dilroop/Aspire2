namespace Temp
{
    partial class RoomView
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
            this.room_capacity_lbl = new MetroFramework.Controls.MetroLabel();
            this.room_name_lbl = new MetroFramework.Controls.MetroLabel();
            this.deletebtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.editbtn = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.deletebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // room_capacity_lbl
            // 
            this.room_capacity_lbl.AutoSize = true;
            this.room_capacity_lbl.Location = new System.Drawing.Point(124, 7);
            this.room_capacity_lbl.Name = "room_capacity_lbl";
            this.room_capacity_lbl.Size = new System.Drawing.Size(59, 19);
            this.room_capacity_lbl.TabIndex = 10;
            this.room_capacity_lbl.Text = "Capacity";
            // 
            // room_name_lbl
            // 
            this.room_name_lbl.Location = new System.Drawing.Point(6, 6);
            this.room_name_lbl.Name = "room_name_lbl";
            this.room_name_lbl.Size = new System.Drawing.Size(112, 19);
            this.room_name_lbl.TabIndex = 9;
            this.room_name_lbl.Text = "Room Name";
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
            this.deletebtn.TabIndex = 12;
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
            this.editbtn.TabIndex = 11;
            this.editbtn.TabStop = false;
            this.editbtn.Zoom = 10;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // RoomView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.room_capacity_lbl);
            this.Controls.Add(this.room_name_lbl);
            this.Name = "RoomView";
            this.Size = new System.Drawing.Size(536, 30);
            ((System.ComponentModel.ISupportInitialize)(this.deletebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton deletebtn;
        private Bunifu.Framework.UI.BunifuImageButton editbtn;
        private MetroFramework.Controls.MetroLabel room_capacity_lbl;
        private MetroFramework.Controls.MetroLabel room_name_lbl;
    }
}
