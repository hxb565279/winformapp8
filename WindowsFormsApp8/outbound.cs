using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp7;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp8
{
    public partial class outbound : Form
    {
        public outbound()
        {
            InitializeComponent();
            @select();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void outbound_Load(object sender, EventArgs e)
        {
            
        }

        public void select()
        {
            Database2 db = new Database2();
            MySqlConnection conn = db.getConn();
            try
            {
                conn.Open();
                String sql = String.Format("select outbound_id,outbound_shop_name,outbound_shop_price,outbound_shop_number,outbound_to_person,outbound_to_phone,outbound_to_address,outbound_data,c.username  from outbound o,user_customer c where o.out_user_id = c.id ");
                MySqlCommand comm = new MySqlCommand(sql, conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = comm;
                //数据集
                DataSet ds = new DataSet();
                sda.Fill(ds, "outbound");
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "id";
                dataGridView1.Columns[1].HeaderText = "商品名";
                dataGridView1.Columns[2].HeaderText = "价格";
                dataGridView1.Columns[3].HeaderText = "数量";
                dataGridView1.Columns[4].HeaderText = "收货人";
                dataGridView1.Columns[5].HeaderText = "电话";
                dataGridView1.Columns[6].HeaderText = "地址";
                dataGridView1.Columns[7].HeaderText = "创建时间";
                dataGridView1.Columns[8].HeaderText = "订单人";
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void create1_Click(object sender, EventArgs e)
        {
            create1  create = new create1();
            create.Show();
        }
    }
}