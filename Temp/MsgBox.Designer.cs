﻿namespace Temp
{
    partial class MsgBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBox));
            this.message = new MetroFramework.Controls.MetroLabel();
            this.addbtn = new MetroFramework.Controls.MetroButton();
            this.icon = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(49, 9);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(240, 50);
            this.message.TabIndex = 1;
            this.message.Text = "Some Warning Message";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(295, 22);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(69, 23);
            this.addbtn.TabIndex = 2;
            this.addbtn.Text = "OK";
            this.addbtn.UseSelectable = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.Transparent;
            this.icon.Image = global::Temp.Properties.Resources.icons8_Poison_64__1_;
            this.icon.ImageActive = null;
            this.icon.Location = new System.Drawing.Point(12, 18);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(30, 30);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            this.icon.Zoom = 10;
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 62);
            this.ControlBox = false;
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.message);
            this.Controls.Add(this.icon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MsgBox";
            this.Resizable = false;
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton icon;
        private MetroFramework.Controls.MetroLabel message;
        private MetroFramework.Controls.MetroButton addbtn;
    }
}