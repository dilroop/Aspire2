namespace Temp
{
    partial class EditRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRoom));
            this.capacity = new MetroFramework.Controls.MetroTextBox();
            this.updateRoombtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.name = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // capacity
            // 
            this.capacity.Lines = new string[0];
            this.capacity.Location = new System.Drawing.Point(114, 132);
            this.capacity.MaxLength = 32767;
            this.capacity.Name = "capacity";
            this.capacity.PasswordChar = '\0';
            this.capacity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.capacity.SelectedText = "";
            this.capacity.Size = new System.Drawing.Size(157, 23);
            this.capacity.TabIndex = 20;
            this.capacity.UseSelectable = true;
            // 
            // updateRoombtn
            // 
            this.updateRoombtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.updateRoombtn.Location = new System.Drawing.Point(114, 185);
            this.updateRoombtn.Name = "updateRoombtn";
            this.updateRoombtn.Size = new System.Drawing.Size(75, 23);
            this.updateRoombtn.TabIndex = 19;
            this.updateRoombtn.Text = "Save";
            this.updateRoombtn.UseSelectable = true;
            this.updateRoombtn.Click += new System.EventHandler(this.updateRoombtn_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(29, 132);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Capacity";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Name";
            // 
            // name
            // 
            this.name.Lines = new string[0];
            this.name.Location = new System.Drawing.Point(114, 93);
            this.name.MaxLength = 32767;
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name.SelectedText = "";
            this.name.Size = new System.Drawing.Size(157, 23);
            this.name.TabIndex = 16;
            this.name.UseSelectable = true;
            // 
            // EditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 234);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.updateRoombtn);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditRoom";
            this.Resizable = false;
            this.Text = "Edit Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox capacity;
        private MetroFramework.Controls.MetroButton updateRoombtn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox name;
    }
}