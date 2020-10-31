using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public  static Form1 form1;
        public Form1()
        {
            form1 = this;
            InitializeComponent();
          
        }


        
    
        public void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void 入货单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


    }
}