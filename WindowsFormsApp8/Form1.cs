using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp7;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public  static Form1 form1;
        public String username;

        public Form1(string username)
        {
            this.username = username;
        }

        public Form1()
        {
            form1 = this;
            InitializeComponent();   
            String username = form1.username;
            Text = "管理系统,欢迎" + username+"管理员";
         
        }

        private void 入货单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            manu manu = new manu();
            manu.MdiParent = this;
            manu.FormBorderStyle = FormBorderStyle.None;
            manu.Dock = DockStyle.Fill;
            manu.Show();
        }

        private void 出货单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            outbound outbound = new outbound();
            outbound.MdiParent = this;
            outbound.FormBorderStyle = FormBorderStyle.None;
            outbound.Dock = DockStyle.Fill;
            outbound.Show();
        }

        public void 库存管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            stock stock = new stock();
            stock.MdiParent = this;
            stock.FormBorderStyle = FormBorderStyle.None;
            stock.Dock = DockStyle.Fill;
            stock.Show();
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void 登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            store_login storeLogin = new store_login();
            storeLogin.MdiParent = this;
            storeLogin.FormBorderStyle = FormBorderStyle.None;
            storeLogin.Dock = DockStyle.Fill;
            storeLogin.Show();
        }

        public void 注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            store_register storeRegister = new store_register();
            storeRegister.MdiParent = this;
            storeRegister.FormBorderStyle = FormBorderStyle.None;
            storeRegister.Dock = DockStyle.Fill;
            storeRegister.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
         
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
     
         
        }


        private void 库存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            stock_supplier stockSupplier = new stock_supplier();
            stockSupplier.MdiParent = this;
            stockSupplier.FormBorderStyle = FormBorderStyle.None;
            stockSupplier.Dock = DockStyle.Fill;
            stockSupplier.Show();
        }

        private void 入库日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }

        private void 出库日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }

        private void 登录日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }

        private void 财务明细ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }
    }
}