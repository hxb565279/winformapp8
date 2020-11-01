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
        public Form1()
        {
            form1 = this;
            InitializeComponent();
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
    }
}