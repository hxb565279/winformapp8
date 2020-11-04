using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp7;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp8
{
    public partial class outbound : Form
    {
        public outbound()
        {
            InitializeComponent();
            @select();
            selectall();
            selectall2();
        String   username=        Form1.form1.username;
        MessageBox.Show("欢迎管理员"+username);
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
                String value4 = dataGridView1.Rows[index].Cells[4].Value.ToString();
                String value5 = dataGridView1.Rows[index].Cells[5].Value.ToString();
                String value6 = dataGridView1.Rows[index].Cells[6].Value.ToString();
                String value7 = dataGridView1.Rows[index].Cells[7].Value.ToString();


                String sql = String.Format(
                    "update outbound set outbound_shop_name = '{0}',outbound_shop_price='{1}',outbound_shop_number='{2}',outbound_to_person='{3}',outbound_to_phone = '{4}',outbound_to_address = '{5}',outbound_data='{6}' where outbound_id='{7}'",
                    value1, value2, value3, value4, value5, value6, value7, value0);
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
            Database2 db = new Database2();
            MySqlConnection conn = db.getConn();
            try
            {
                conn.Open();
                String sql = String.Format("select count(*) from outbound ");
                MySqlCommand comm = new MySqlCommand(sql, conn);
                int out_bound_num = Convert.ToInt32(comm.ExecuteScalar());
                if (out_bound_num > 0)
                {
                    for (int i = 1; i <= out_bound_num; i++)
                    {
                        String sql1 = String.Format("select * from outbound limit {0}", i.ToString());
                        MySqlCommand comm1 = new MySqlCommand(sql1, conn);
                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = comm1;
                        //数据集
                        DataSet ds = new DataSet();
                        sda.Fill(ds, "outbound");
                        String shop_name = ds.Tables[0].Rows[0]["OUTBOUND_SHOP_NAME"].ToString().Trim();
                        String shop_number = ds.Tables[0].Rows[0]["outbound_shop_number"].ToString().Trim();
                        String sql2 = String.Format("select * from stock_store where stock_shop_name = '{0}'",
                            shop_name);
                        MySqlCommand comm2 = new MySqlCommand(sql2, conn);
                        MySqlDataAdapter sda1 = new MySqlDataAdapter();
                        sda1.SelectCommand = comm2;
                        DataSet ds1 = new DataSet();
                        sda1.Fill(ds1, "stock_store");
                        if (Convert.ToInt32(comm2.ExecuteScalar()) > 0)
                        {
                            String stock_number = ds1.Tables[0].Rows[0]["stock_shop_number"].ToString().Trim();
                            if (Convert.ToInt32(stock_number) > Convert.ToInt32(shop_number))
                            {
                                String stock_sql =
                                    String.Format(
                                        "update stock_store set stock_shop_number = '{0}'-'{1}' where stock_shop_name = '{2}'",
                                        stock_number, shop_number, shop_name);
                                MySqlCommand comm_stock_sql = new MySqlCommand(stock_sql, conn);
                                int stock_sql_num1 = comm_stock_sql.ExecuteNonQuery();
                                if (stock_sql_num1 > 0)
                                {
                                    String outbound_sql =
                                        String.Format("delete from outbound where outbound_shop_name = '{0}'",
                                            shop_name);
                                    MySqlCommand comm_outbound_sql = new MySqlCommand(outbound_sql, conn);
                                    int out_sql_num = comm_outbound_sql.ExecuteNonQuery();
                                    if (out_sql_num > 0)
                                    {
                                        db.insert_to("出库订单更新成功");
                                        MessageBox.Show("订单更新成功");
                                    }
                                    else
                                    {
                                        db.insert_to("订单更新失败");
                                        MessageBox.Show("订单更新失败");
                                    }
                                }
                                else
                                {
                                    db.insert_to("请求订单失败");
                                    MessageBox.Show("请求订单失败");
                                }
                            }
                            else
                            {
                                db.insert_to("库存不足");
                                MessageBox.Show("库存不足");
                                String num2 = Interaction.InputBox("库存剩余量" + stock_number + ",是否选择选择剩余库存量进行提交", "订单处理",
                                    "", 3, 3);
                                if (num2 == "")
                                {
                                    db.insert_to("该订单请求已经取消");

                                    MessageBox.Show("该订单请求已经取消");
                                }
                                else
                                {
                                    String sql3 =
                                        String.Format(
                                            "update stock_store set stock_shop_number = {0}-{1} where stock_shop_name = '{2}' ",
                                            stock_number, num2, shop_name);
                                    MySqlCommand comm3 = new MySqlCommand(sql3, conn);
                                    int num = comm3.ExecuteNonQuery();
                                    if (num > 0)
                                    {
                                        String sql5 = String.Format(
                                            "update outbound set outbound_shop_number = {0}-{1} where outbound_shop_name = '{2}'",
                                            shop_number, num2, shop_name);
                                        MySqlCommand comm5 = new MySqlCommand(sql5, conn);
                                        int num5 = comm5.ExecuteNonQuery();
                                        if (num5 > 0)
                                        {
                                            db.insert_to("出库订单更新成功");
                                            MessageBox.Show("该订单提交成功");
                                        }
                                        else
                                        {
                                            db.insert_to("该订单提交失败");
                                            MessageBox.Show("该订单提交失败");
                                        }
                                    }
                                    else
                                    {
                                        db.insert_to("订单处理失败");
                                        MessageBox.Show("订单处理失败");
                                        // String sql4 = String.Format("update stock_store set stock_number = {0}+{1} where stock_shop_name = '{2}' ",stock_number,shop_number,shop_name);    
                                        // MySqlCommand comm4 = new MySqlCommand(sql4,conn);
                                        //  int num4 =   comm4.ExecuteNonQuery();
                                        //  if (num4>0)
                                        //  {
                                        //      
                                        //  }
                                        //  else
                                        //  {
                                        //      MessageBox.Show("");
                                        //  }
                                    }
                                }
                            }
                        }
                        else
                        {
                            db.insert_to("无订单库存");
                            MessageBox.Show("无该订单库存");
                        }
                    }
                }
                else
                {
                    db.insert_to("处理订单为空");
                    MessageBox.Show("处理订单为空");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void selectall()
        {
            Database2 db = new Database2();
            MySqlConnection conn = db.getConn();
            try
            {
                conn.Open();
                String sql11 = String.Format("select *  from stock_store");
                MySqlCommand comm11 = new MySqlCommand(sql11, conn);
                MySqlDataAdapter sda11 = new MySqlDataAdapter();
                sda11.SelectCommand = comm11;
                //数据集
                DataSet ds11 = new DataSet();
                sda11.Fill(ds11, "stock_store");
                dataGridView2.DataSource = ds11.Tables[0];
                dataGridView2.Columns[0].HeaderText = "id";
                dataGridView2.Columns[1].HeaderText = "商品名";
                dataGridView2.Columns[2].HeaderText = "价格";
                dataGridView2.Columns[3].HeaderText = "数量";
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void selectall2()
        {
            Database2 db = new Database2();
            MySqlConnection conn = db.getConn();
            try
            {
                conn.Open();
                String sql11 = String.Format("select *  from stock_store");
                MySqlCommand comm11 = new MySqlCommand(sql11, conn);
                MySqlDataAdapter sda11 = new MySqlDataAdapter();
                sda11.SelectCommand = comm11;
                //数据集
                DataSet ds11 = new DataSet();
                sda11.Fill(ds11, "stock_store");
                dataGridView2.DataSource = ds11.Tables[0];
                dataGridView2.Columns[0].HeaderText = "id";
                dataGridView2.Columns[1].HeaderText = "商品名";
                dataGridView2.Columns[2].HeaderText = "价格";
                dataGridView2.Columns[3].HeaderText = "数量";
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        
        
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
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