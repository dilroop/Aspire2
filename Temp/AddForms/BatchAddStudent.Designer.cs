namespace Temp
{
    partial class BatchAddStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchAddStudent));
            this.datagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addstudentbtn = new MetroFramework.Controls.MetroButton();
            this.message = new MetroFramework.Controls.MetroLabel();
            this.course_name = new MetroFramework.Controls.MetroComboBox();
            this.course_level = new MetroFramework.Controls.MetroComboBox();
            this.refresh = new Bunifu.Framework.UI.BunifuImageButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToAddRows = false;
            this.datagrid.AllowUserToResizeColumns = false;
            this.datagrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.datagrid.DoubleBuffered = true;
            this.datagrid.EnableHeadersVisualStyles = false;
            this.datagrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.datagrid.HeaderForeColor = System.Drawing.Color.White;
            this.datagrid.Location = new System.Drawing.Point(30, 103);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagrid.Size = new System.Drawing.Size(258, 229);
            this.datagrid.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Student Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "Student Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 117;
            // 
            // addstudentbtn
            // 
            this.addstudentbtn.Location = new System.Drawing.Point(242, 350);
            this.addstudentbtn.Name = "addstudentbtn";
            this.addstudentbtn.Size = new System.Drawing.Size(46, 23);
            this.addstudentbtn.TabIndex = 1;
            this.addstudentbtn.Text = "Add";
            this.addstudentbtn.UseSelectable = true;
            this.addstudentbtn.Click += new System.EventHandler(this.addstudentbtn_Click);
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(70, 350);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(166, 23);
            this.message.TabIndex = 2;
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // course_name
            // 
            this.course_name.FormattingEnabled = true;
            this.course_name.ItemHeight = 23;
            this.course_name.Items.AddRange(new object[] {
            "DEMO - Graduate Diploma in Computing"});
            this.course_name.Location = new System.Drawing.Point(30, 63);
            this.course_name.Name = "course_name";
            this.course_name.Size = new System.Drawing.Size(170, 29);
            this.course_name.TabIndex = 4;
            this.course_name.UseSelectable = true;
            this.course_name.Validating += new System.ComponentModel.CancelEventHandler(this.course_name_Validating);
            // 
            // course_level
            // 
            this.course_level.FormattingEnabled = true;
            this.course_level.ItemHeight = 23;
            this.course_level.Items.AddRange(new object[] {
            "Level 5",
            "Level 6",
            "Level 7",
            "GD"});
            this.course_level.Location = new System.Drawing.Point(206, 63);
            this.course_level.Name = "course_level";
            this.course_level.Size = new System.Drawing.Size(82, 29);
            this.course_level.TabIndex = 5;
            this.course_level.UseSelectable = true;
            this.course_level.Validating += new System.ComponentModel.CancelEventHandler(this.course_level_Validating);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.Image = global::Temp.Properties.Resources.refresh2;
            this.refresh.ImageActive = null;
            this.refresh.Location = new System.Drawing.Point(30, 350);
            this.refresh.Margin = new System.Windows.Forms.Padding(0);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(20, 20);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refresh.TabIndex = 6;
            this.refresh.TabStop = false;
            this.refresh.Zoom = 10;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // BatchAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(320, 397);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.course_level);
            this.Controls.Add(this.course_name);
            this.Controls.Add(this.message);
            this.Controls.Add(this.addstudentbtn);
            this.Controls.Add(this.datagrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BatchAddStudent";
            this.Resizable = false;
            this.Text = "Add Multiple Students";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private MetroFramework.Controls.MetroButton addstudentbtn;
        private MetroFramework.Controls.MetroLabel message;
        private MetroFramework.Controls.MetroComboBox course_name;
        private MetroFramework.Controls.MetroComboBox course_level;
        private Bunifu.Framework.UI.BunifuImageButton refresh;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}