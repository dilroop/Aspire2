namespace Temp
{
    partial class AddRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRoom));
            this.Addcoursebtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.name = new MetroFramework.Controls.MetroTextBox();
            this.capacity = new MetroFramework.Controls.MetroTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.message = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Addcoursebtn
            // 
            this.Addcoursebtn.Location = new System.Drawing.Point(102, 163);
            this.Addcoursebtn.Name = "Addcoursebtn";
            this.Addcoursebtn.Size = new System.Drawing.Size(75, 23);
            this.Addcoursebtn.TabIndex = 14;
            this.Addcoursebtn.Text = "Add";
            this.Addcoursebtn.UseSelectable = true;
            this.Addcoursebtn.Click += new System.EventHandler(this.Addcoursebtn_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 110);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Capacity";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Name";
            // 
            // name
            // 
            this.name.Lines = new string[0];
            this.name.Location = new System.Drawing.Point(102, 71);
            this.name.MaxLength = 32767;
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name.SelectedText = "";
            this.name.Size = new System.Drawing.Size(157, 23);
            this.name.TabIndex = 10;
            this.name.UseSelectable = true;
            this.name.Validating += new System.ComponentModel.CancelEventHandler(this.name_Validating);
            // 
            // capacity
            // 
            this.capacity.Lines = new string[0];
            this.capacity.Location = new System.Drawing.Point(102, 110);
            this.capacity.MaxLength = 32767;
            this.capacity.Name = "capacity";
            this.capacity.PasswordChar = '\0';
            this.capacity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.capacity.SelectedText = "";
            this.capacity.Size = new System.Drawing.Size(75, 23);
            this.capacity.TabIndex = 15;
            this.capacity.UseSelectable = true;
            this.capacity.Validating += new System.ComponentModel.CancelEventHandler(this.capacity_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(183, 164);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 0);
            this.message.TabIndex = 16;
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(290, 215);
            this.Controls.Add(this.message);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.Addcoursebtn);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRoom";
            this.Resizable = false;
            this.Text = "Add a Room";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Addcoursebtn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox name;
        private MetroFramework.Controls.MetroTextBox capacity;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroLabel message;
    }
}