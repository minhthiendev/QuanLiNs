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
            this.nhânThânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânThânToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiThânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thaiSảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thưởngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kĩLuậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảoHiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panel1.Size = new System.Drawing.Size(790, 41);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoso,
            this.nhânThânToolStripMenuItem,
            this.nhânThânToolStripMenuItem1,
            this.ngườiThânToolStripMenuItem,
            this.thaiSảnToolStripMenuItem,
            this.thưởngToolStripMenuItem,
            this.kĩLuậtToolStripMenuItem,
            this.bảoHiểmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 41);
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
            // nhânThânToolStripMenuItem
            // 
            this.nhânThânToolStripMenuItem.Name = "nhânThânToolStripMenuItem";
            this.nhânThânToolStripMenuItem.Size = new System.Drawing.Size(91, 37);
            this.nhânThânToolStripMenuItem.Text = "Hợp đồng";
            this.nhânThânToolStripMenuItem.Click += new System.EventHandler(this.nhânThânToolStripMenuItem_Click);
            // 
            // nhânThânToolStripMenuItem1
            // 
            this.nhânThânToolStripMenuItem1.Name = "nhânThânToolStripMenuItem1";
            this.nhânThânToolStripMenuItem1.Size = new System.Drawing.Size(98, 37);
            this.nhânThânToolStripMenuItem1.Text = "Người thân";
            // 
            // ngườiThânToolStripMenuItem
            // 
            this.ngườiThânToolStripMenuItem.Name = "ngườiThânToolStripMenuItem";
            this.ngườiThânToolStripMenuItem.Size = new System.Drawing.Size(93, 37);
            this.ngườiThânToolStripMenuItem.Text = "Nghỉ phép";
            // 
            // thaiSảnToolStripMenuItem
            // 
            this.thaiSảnToolStripMenuItem.Name = "thaiSảnToolStripMenuItem";
            this.thaiSảnToolStripMenuItem.Size = new System.Drawing.Size(77, 37);
            this.thaiSảnToolStripMenuItem.Text = "Thai sản";
            // 
            // thưởngToolStripMenuItem
            // 
            this.thưởngToolStripMenuItem.Name = "thưởngToolStripMenuItem";
            this.thưởngToolStripMenuItem.Size = new System.Drawing.Size(74, 37);
            this.thưởngToolStripMenuItem.Text = "Thưởng";
            // 
            // kĩLuậtToolStripMenuItem
            // 
            this.kĩLuậtToolStripMenuItem.Name = "kĩLuậtToolStripMenuItem";
            this.kĩLuậtToolStripMenuItem.Size = new System.Drawing.Size(65, 37);
            this.kĩLuậtToolStripMenuItem.Text = "Kĩ luật";
            // 
            // bảoHiểmToolStripMenuItem
            // 
            this.bảoHiểmToolStripMenuItem.Name = "bảoHiểmToolStripMenuItem";
            this.bảoHiểmToolStripMenuItem.Size = new System.Drawing.Size(86, 37);
            this.bảoHiểmToolStripMenuItem.Text = "Bảo hiểm";
            // 
            // pContainer1
            // 
            this.pContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer1.Location = new System.Drawing.Point(0, 41);
            this.pContainer1.Name = "pContainer1";
            this.pContainer1.Size = new System.Drawing.Size(790, 817);
            this.pContainer1.TabIndex = 1;
            // 
            // UcNVdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "UcNVdetail";
            this.Size = new System.Drawing.Size(790, 858);
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
        private System.Windows.Forms.ToolStripMenuItem nhânThânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânThânToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ngườiThânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thaiSảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thưởngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kĩLuậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảoHiểmToolStripMenuItem;
        private System.Windows.Forms.Panel pContainer1;
    }
}
