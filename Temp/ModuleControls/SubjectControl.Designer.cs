namespace Temp
{
    partial class SubjectControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectControl));
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.message = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.filter_combo = new System.Windows.Forms.ComboBox();
            this.Title = new MetroFramework.Controls.MetroLabel();
            this.saveimgbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.addimgbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.loadimgbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.subject_layout = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuGradientPanel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveimgbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addimgbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadimgbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.message);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 369);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(543, 21);
            this.bunifuGradientPanel2.TabIndex = 9;
            // 
            // message
            // 
            this.message.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.message.BackColor = System.Drawing.Color.Transparent;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(263, 0);
            this.message.Name = "message";
            this.message.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.message.Size = new System.Drawing.Size(280, 21);
            this.message.TabIndex = 0;
            this.message.Text = "Subjects Module Opened";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(488, 377);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(52, 13);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Teachers";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.filter_combo);
            this.bunifuGradientPanel1.Controls.Add(this.Title);
            this.bunifuGradientPanel1.Controls.Add(this.saveimgbtn);
            this.bunifuGradientPanel1.Controls.Add(this.addimgbtn);
            this.bunifuGradientPanel1.Controls.Add(this.loadimgbtn);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(543, 30);
            this.bunifuGradientPanel1.TabIndex = 8;
            // 
            // filter_combo
            // 
            this.filter_combo.Location = new System.Drawing.Point(301, 3);
            this.filter_combo.Name = "filter_combo";
            this.filter_combo.Size = new System.Drawing.Size(147, 21);
            this.filter_combo.TabIndex = 8;
            this.filter_combo.SelectedValueChanged += new System.EventHandler(this.filter_combo_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(3, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(56, 19);
            this.Title.TabIndex = 4;
            this.Title.Text = "Subjects";
            // 
            // saveimgbtn
            // 
            this.saveimgbtn.BackColor = System.Drawing.Color.Transparent;
            this.saveimgbtn.Image = global::Temp.Properties.Resources.save1;
            this.saveimgbtn.ImageActive = null;
            this.saveimgbtn.Location = new System.Drawing.Point(518, 5);
            this.saveimgbtn.Margin = new System.Windows.Forms.Padding(5);
            this.saveimgbtn.Name = "saveimgbtn";
            this.saveimgbtn.Size = new System.Drawing.Size(20, 20);
            this.saveimgbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.saveimgbtn.TabIndex = 3;
            this.saveimgbtn.TabStop = false;
            this.saveimgbtn.Zoom = 10;
            this.saveimgbtn.Click += new System.EventHandler(this.saveimgbtn_Click);
            // 
            // addimgbtn
            // 
            this.addimgbtn.BackColor = System.Drawing.Color.Transparent;
            this.addimgbtn.Image = global::Temp.Properties.Resources.add;
            this.addimgbtn.ImageActive = null;
            this.addimgbtn.Location = new System.Drawing.Point(465, 5);
            this.addimgbtn.Margin = new System.Windows.Forms.Padding(0);
            this.addimgbtn.Name = "addimgbtn";
            this.addimgbtn.Size = new System.Drawing.Size(20, 20);
            this.addimgbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addimgbtn.TabIndex = 1;
            this.addimgbtn.TabStop = false;
            this.addimgbtn.Zoom = 10;
            this.addimgbtn.Click += new System.EventHandler(this.addimgbtn_Click);
            // 
            // loadimgbtn
            // 
            this.loadimgbtn.BackColor = System.Drawing.Color.Transparent;
            this.loadimgbtn.Image = global::Temp.Properties.Resources.Open_48px;
            this.loadimgbtn.ImageActive = null;
            this.loadimgbtn.Location = new System.Drawing.Point(491, 5);
            this.loadimgbtn.Margin = new System.Windows.Forms.Padding(5);
            this.loadimgbtn.Name = "loadimgbtn";
            this.loadimgbtn.Padding = new System.Windows.Forms.Padding(5);
            this.loadimgbtn.Size = new System.Drawing.Size(20, 20);
            this.loadimgbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadimgbtn.TabIndex = 2;
            this.loadimgbtn.TabStop = false;
            this.loadimgbtn.Zoom = 10;
            this.loadimgbtn.Click += new System.EventHandler(this.loadimgbtn_Click);
            // 
            // subject_layout
            // 
            this.subject_layout.Location = new System.Drawing.Point(0, 28);
            this.subject_layout.Name = "subject_layout";
            this.subject_layout.Size = new System.Drawing.Size(543, 338);
            this.subject_layout.TabIndex = 10;
            // 
            // SubjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.subject_layout);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "SubjectControl";
            this.Size = new System.Drawing.Size(543, 390);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveimgbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addimgbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadimgbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuCustomLabel message;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private MetroFramework.Controls.MetroLabel Title;
        private Bunifu.Framework.UI.BunifuImageButton saveimgbtn;
        private Bunifu.Framework.UI.BunifuImageButton addimgbtn;
        private Bunifu.Framework.UI.BunifuImageButton loadimgbtn;
        private System.Windows.Forms.FlowLayoutPanel subject_layout;
        private System.Windows.Forms.ComboBox filter_combo;
    }
}
