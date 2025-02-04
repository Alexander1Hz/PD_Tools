namespace ImageGeneratorWithUI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // 在窗体销毁时清理资源
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        private void InitializeComponent()
        {
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.评估ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.电压设定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.时序设定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.投产ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cG旋转度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设计验证ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.奇偶列图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.奇偶行图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版本号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(12, 65);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 21);
            this.txtWidth.TabIndex = 1;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(12, 92);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 21);
            this.txtHeight.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 119);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "确认生成";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.评估ToolStripMenuItem,
            this.投产ToolStripMenuItem,
            this.设计验证ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 评估ToolStripMenuItem
            // 
            this.评估ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.电压设定ToolStripMenuItem,
            this.时序设定ToolStripMenuItem});
            this.评估ToolStripMenuItem.Name = "评估ToolStripMenuItem";
            this.评估ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.评估ToolStripMenuItem.Text = "设计";
            // 
            // 电压设定ToolStripMenuItem
            // 
            this.电压设定ToolStripMenuItem.Name = "电压设定ToolStripMenuItem";
            this.电压设定ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.电压设定ToolStripMenuItem.Text = "电压设定";
            this.电压设定ToolStripMenuItem.Click += new System.EventHandler(this.电压设定ToolStripMenuItem_Click);
            // 
            // 时序设定ToolStripMenuItem
            // 
            this.时序设定ToolStripMenuItem.Name = "时序设定ToolStripMenuItem";
            this.时序设定ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.时序设定ToolStripMenuItem.Text = "时序设定";
            // 
            // 投产ToolStripMenuItem
            // 
            this.投产ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cG旋转度ToolStripMenuItem});
            this.投产ToolStripMenuItem.Name = "投产ToolStripMenuItem";
            this.投产ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.投产ToolStripMenuItem.Text = "投产";
            // 
            // cG旋转度ToolStripMenuItem
            // 
            this.cG旋转度ToolStripMenuItem.Name = "cG旋转度ToolStripMenuItem";
            this.cG旋转度ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.cG旋转度ToolStripMenuItem.Text = "CG旋转度";
            // 
            // 设计验证ToolStripMenuItem
            // 
            this.设计验证ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.奇偶列图片ToolStripMenuItem,
            this.奇偶行图片ToolStripMenuItem});
            this.设计验证ToolStripMenuItem.Name = "设计验证ToolStripMenuItem";
            this.设计验证ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.设计验证ToolStripMenuItem.Text = "设计验证";
            // 
            // 奇偶列图片ToolStripMenuItem
            // 
            this.奇偶列图片ToolStripMenuItem.Name = "奇偶列图片ToolStripMenuItem";
            this.奇偶列图片ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.奇偶列图片ToolStripMenuItem.Text = "奇偶列图片";
            // 
            // 奇偶行图片ToolStripMenuItem
            // 
            this.奇偶行图片ToolStripMenuItem.Name = "奇偶行图片ToolStripMenuItem";
            this.奇偶行图片ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.奇偶行图片ToolStripMenuItem.Text = "奇偶行图片";

            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.版本号ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(12, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 版本号ToolStripMenuItem
            // 
            this.版本号ToolStripMenuItem.Name = "版本号ToolStripMenuItem";
            this.版本号ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.版本号ToolStripMenuItem.Text = "版本号";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "PD Tools";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 评估ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 电压设定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 时序设定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 投产ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cG旋转度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设计验证ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 奇偶列图片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 奇偶行图片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 版本号ToolStripMenuItem;
    }
}
