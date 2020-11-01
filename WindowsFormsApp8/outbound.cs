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
                String sql = String.Format(
                    "select outbound_id,outbound_shop_name,outbound_shop_price,outbound_shop_number,outbound_to_person,outbound_to_phone,outbound_to_address,outbound_data,c.username  from outbound o,user_customer c where o.out_user_id = c.id ");
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
                MessageBox.Show(e.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void create1_Click(object sender, EventArgs e)
        {
            create1 create = new create1();
            create.Show();
        }

        private void transh_Click(object sender, EventArgs e)
        {
            @select();
        }

        private void update11_Click(object sender, EventArgs e)
        {
            Database2 db = new Database2();
            MySqlConnection conn = db.getConn();
            try
            {
                conn.Open();
                int index = dataGridView1.CurrentRow.Index;
                String value0 = dataGridView1.Rows[index].Cells[0].Value.ToString();
                String value1 = dataGridView1.Rows[index].Cells[1].Value.ToString();
                String value2 = dataGridView1.Rows[index].Cells[2].Value.ToString();
                String value3 = dataGridView1.Rows[index].Cells[3].Value.ToString();
                String value4= dataGridView1.Rows[index].Cells[4].Value.ToString();
                String value5 = dataGridView1.Rows[index].Cells[5].Value.ToString();
                String value6 = dataGridView1.Rows[index].Cells[6].Value.ToString();
                String value7 = dataGridView1.Rows[index].Cells[7].Value.ToString();


                String sql = String.Format(
                    "update outbound set outbound_shop_name = '{0}',outbound_shop_price='{1}',outbound_shop_number='{2}',outbound_to_person='{3}',outbound_to_phone = '{4}',outbound_to_address = '{5}',outbound_data='{6}' where outbound_id='{7}'",
                    value1, value2, value3, value4, value5, value6,value7, value0);
                MySqlCommand comm = new MySqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("修改成功");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message.ToString() + "数据库打开失败");
            }
            finally
            {
                conn.Close();
            }
        }

        private void deletebutton1_Click(object sender, EventArgs e)
        {
            Database2 db = new Database2();
            MySqlConnection conn = db.getConn();
            try
            {
                conn.Open();
                int index = dataGridView1.CurrentRow.Index;
                String value = dataGridView1.Rows[index].Cells[0].Value.ToString();
                String sql = String.Format("delete from outbound where outbound_id = '{0}'", value);
                MySqlCommand comm = new MySqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("删除成功");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message.ToString() + "数据库打开失败");
            }
            finally
            {
                conn.Close();
            }
            
            
            
        }

        private void submit1_Click(object sender, EventArgs e)
        {
            
        }
    }
}