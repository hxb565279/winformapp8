using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp7;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp8
{
    public partial class manu : Form
    {
        public manu()
        {
            InitializeComponent();
            selectall2();
        }

        public void selectall2()
        {
            Database2 db = new Database2();
            MySqlConnection conn = db.getConn();
            try
            {
                conn.Open();
                String sql = String.Format("select *  from `c#_store`.stock_supplier");
                MySqlCommand comm = new MySqlCommand(sql, conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = comm;
                //数据集
                DataSet ds = new DataSet();
                sda.Fill(ds, "stock_store");
                dataGridView2.DataSource = ds.Tables[0];
                dataGridView2.Columns[0].HeaderText = "id";
                dataGridView2.Columns[1].HeaderText = "商品名";
                dataGridView2.Columns[2].HeaderText = "价格";
                dataGridView2.Columns[3].HeaderText = "数量";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show(e.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        
        
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}