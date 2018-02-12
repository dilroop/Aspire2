namespace Temp.AddForms
{
    partial class AddLevel
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
            this.level_lbl = new MetroFramework.Controls.MetroLabel();
            this.level_name = new MetroFramework.Controls.MetroTextBox();
            this.Addcoursebtn = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.message = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // level_lbl
            // 
            this.level_lbl.AutoSize = true;
            this.level_lbl.Location = new System.Drawing.Point(15, 66);
            this.level_lbl.Name = "level_lbl";
            this.level_lbl.Size = new System.Drawing.Size(78, 19);
            this.level_lbl.TabIndex = 3;
            this.level_lbl.Text = "Level Name";
            // 
            // level_name
            // 
            this.level_name.Lines = new string[] {
        "Level "};
            this.level_name.Location = new System.Drawing.Point(128, 66);
            this.level_name.MaxLength = 32767;
            this.level_name.Name = "level_name";
            this.level_name.PasswordChar = '\0';
            this.level_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.level_name.SelectedText = "";
            this.level_name.Size = new System.Drawing.Size(157, 23);
            this.level_name.TabIndex = 2;
            this.level_name.Text = "Level ";
            this.level_name.UseSelectable = true;
            this.level_name.Validating += new System.ComponentModel.CancelEventHandler(this.level_name_Validating);
            // 
            // Addcoursebtn
            // 
            this.Addcoursebtn.Location = new System.Drawing.Point(128, 109);
            this.Addcoursebtn.Name = "Addcoursebtn";
            this.Addcoursebtn.Size = new System.Drawing.Size(75, 23);
            this.Addcoursebtn.TabIndex = 10;
            this.Addcoursebtn.Text = "Add";
            this.Addcoursebtn.UseSelectable = true;
            this.Addcoursebtn.Click += new System.EventHandler(this.Addcoursebtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(209, 113);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(12, 19);
            this.message.TabIndex = 11;
            this.message.Text = ".";
            // 
            // AddLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 150);
            this.Controls.Add(this.message);
            this.Controls.Add(this.Addcoursebtn);
            this.Controls.Add(this.level_lbl);
            this.Controls.Add(this.level_name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddLevel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Add Level";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel level_lbl;
        private MetroFramework.Controls.MetroTextBox level_name;
        private MetroFramework.Controls.MetroButton Addcoursebtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroLabel message;
    }
}