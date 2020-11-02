namespace WindowsFormsApp8
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.首选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.货单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入货单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出货单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.店铺管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.首选项ToolStripMenuItem, this.货单ToolStripMenuItem, this.店铺管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 首选项ToolStripMenuItem
            // 
            this.首选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.关闭ToolStripMenuItem, this.登录ToolStripMenuItem, this.注册ToolStripMenuItem});
            this.首选项ToolStripMenuItem.Name = "首选项ToolStripMenuItem";
            this.首选项ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.首选项ToolStripMenuItem.Text = "首选项";
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // 登录ToolStripMenuItem
            // 
            this.登录ToolStripMenuItem.Name = "登录ToolStripMenuItem";
            this.登录ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.登录ToolStripMenuItem.Text = "登录";
            this.登录ToolStripMenuItem.Click += new System.EventHandler(this.登录ToolStripMenuItem_Click);
            // 
            // 注册ToolStripMenuItem
            // 
            this.注册ToolStripMenuItem.Name = "注册ToolStripMenuItem";
            this.注册ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.注册ToolStripMenuItem.Text = "注册";
            this.注册ToolStripMenuItem.Click += new System.EventHandler(this.注册ToolStripMenuItem_Click);
            // 
            // 货单ToolStripMenuItem
            // 
            this.货单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.入货单ToolStripMenuItem, this.出货单ToolStripMenuItem});
            this.货单ToolStripMenuItem.Name = "货单ToolStripMenuItem";
            this.货单ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.货单ToolStripMenuItem.Text = "货单";
            // 
            // 入货单ToolStripMenuItem
            // 
            this.入货单ToolStripMenuItem.Name = "入货单ToolStripMenuItem";
            this.入货单ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.入货单ToolStripMenuItem.Text = "入货单";
            this.入货单ToolStripMenuItem.Click += new System.EventHandler(this.入货单ToolStripMenuItem_Click);
            // 
            // 出货单ToolStripMenuItem
            // 
            this.出货单ToolStripMenuItem.Name = "出货单ToolStripMenuItem";
            this.出货单ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.出货单ToolStripMenuItem.Text = "出货单";
            this.出货单ToolStripMenuItem.Click += new System.EventHandler(this.出货单ToolStripMenuItem_Click);
            // 
            // 店铺管理ToolStripMenuItem
            // 
            this.店铺管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.库存管理ToolStripMenuItem});
            this.店铺管理ToolStripMenuItem.Name = "店铺管理ToolStripMenuItem";
            this.店铺管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.店铺管理ToolStripMenuItem.Text = "店铺管理";
            // 
            // 库存管理ToolStripMenuItem
            // 
            this.库存管理ToolStripMenuItem.Name = "库存管理ToolStripMenuItem";
            this.库存管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.库存管理ToolStripMenuItem.Text = "库存管理";
            this.库存管理ToolStripMenuItem.Click += new System.EventHandler(this.库存管理ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 564);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "管理系统";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem 登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注册ToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem 出货单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 店铺管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 货单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入货单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 首选项ToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion
    }
}