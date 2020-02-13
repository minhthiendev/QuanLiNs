namespace WindowsFormsApp1
{
    partial class UcNVdetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hoso = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanthan = new System.Windows.Forms.ToolStripMenuItem();
            this.nghiphep = new System.Windows.Forms.ToolStripMenuItem();
            this.thaisan = new System.Windows.Forms.ToolStripMenuItem();
            this.thuong = new System.Windows.Forms.ToolStripMenuItem();
            this.kiluat = new System.Windows.Forms.ToolStripMenuItem();
            this.pContainer1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 41);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoso,
            this.nhanthan,
            this.nghiphep,
            this.thaisan,
            this.thuong,
            this.kiluat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1263, 41);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hoso
            // 
            this.hoso.Name = "hoso";
            this.hoso.Size = new System.Drawing.Size(62, 37);
            this.hoso.Text = "Hồ sơ";
            this.hoso.Click += new System.EventHandler(this.hoso_Click);
            // 
            // nhanthan
            // 
            this.nhanthan.Name = "nhanthan";
            this.nhanthan.Size = new System.Drawing.Size(98, 37);
            this.nhanthan.Text = "Người thân";
            this.nhanthan.Click += new System.EventHandler(this.nhânThânToolStripMenuItem1_Click);
            // 
            // nghiphep
            // 
            this.nghiphep.Name = "nghiphep";
            this.nghiphep.Size = new System.Drawing.Size(93, 37);
            this.nghiphep.Text = "Nghỉ phép";
            this.nghiphep.Click += new System.EventHandler(this.ngườiThânToolStripMenuItem_Click);
            // 
            // thaisan
            // 
            this.thaisan.Name = "thaisan";
            this.thaisan.Size = new System.Drawing.Size(77, 37);
            this.thaisan.Text = "Thai sản";
            this.thaisan.Click += new System.EventHandler(this.thaiSảnToolStripMenuItem_Click);
            // 
            // thuong
            // 
            this.thuong.Name = "thuong";
            this.thuong.Size = new System.Drawing.Size(74, 37);
            this.thuong.Text = "Thưởng";
            this.thuong.Click += new System.EventHandler(this.thưởngToolStripMenuItem_Click);
            // 
            // kiluat
            // 
            this.kiluat.Name = "kiluat";
            this.kiluat.Size = new System.Drawing.Size(65, 37);
            this.kiluat.Text = "Kĩ luật";
            this.kiluat.Click += new System.EventHandler(this.kĩLuậtToolStripMenuItem_Click);
            // 
            // pContainer1
            // 
            this.pContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer1.Location = new System.Drawing.Point(0, 41);
            this.pContainer1.Name = "pContainer1";
            this.pContainer1.Size = new System.Drawing.Size(1263, 680);
            this.pContainer1.TabIndex = 1;
            // 
            // UcNVdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "UcNVdetail";
            this.Size = new System.Drawing.Size(1263, 721);
            this.Load += new System.EventHandler(this.UcNVdetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hoso;
        private System.Windows.Forms.ToolStripMenuItem nhanthan;
        private System.Windows.Forms.ToolStripMenuItem nghiphep;
        private System.Windows.Forms.ToolStripMenuItem thaisan;
        private System.Windows.Forms.ToolStripMenuItem thuong;
        private System.Windows.Forms.ToolStripMenuItem kiluat;
        private System.Windows.Forms.Panel pContainer1;
    }
}
