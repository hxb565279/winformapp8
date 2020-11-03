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
            selectall3();
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

        public void selectall3()
        {
            Database2 db = new Database2();
            MySqlConnection conn = db.getConn();
            try
            {
                conn.Open();
                String sql = String.Format(
                    "select m.manu_id, manu_shop_name, manu_shop_price, manu_shop_number, manu_re_person, manu_re_phone, manu_re_address, manu_data,  s.username   from `c#_store`.manu m,`c#_store`.user_supplier s where m.manu_out_user = s.id");
                MySqlCommand comm = new MySqlCommand(sql, conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = comm;
                //数据集
                DataSet ds = new DataSet();
                sda.Fill(ds, "stock_store");
                dataGridView3.DataSource = ds.Tables[0];
                dataGridView3.Columns[0].HeaderText = "id";
                dataGridView3.Columns[1].HeaderText = "商品名";
                dataGridView3.Columns[2].HeaderText = "价格";
                dataGridView3.Columns[3].HeaderText = "数量";
                dataGridView3.Columns[4].HeaderText = "收货人";
                dataGridView3.Columns[5].HeaderText = "电话";
                dataGridView3.Columns[6].HeaderText = "地址";
                dataGridView3.Columns[7].HeaderText = "创建时间";
                dataGridView3.Columns[8].HeaderText = "订单人";
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

        private void addbutton_Click(object sender, EventArgs e)
        {
            create2 c = new create2();
            c.Show();
        }

        private void refrash_Click(object sender, EventArgs e)
        {
            selectall2();
            selectall3();
        }


        private void sumbit1_Click(object sender, EventArgs e)
        {
            Database2 db = new Database2();
            MySqlConnection conn = db.getConn();
            try
            {
                conn.Open();
                String sql = String.Format("select count(*) from `c#_store`.manu ");
                MySqlCommand comm = new MySqlCommand(sql, conn);
                int manu_num = Convert.ToInt32(comm.ExecuteScalar());
                if (manu_num > 0)
                {
                    for (int i = 1; i <= manu_num; i++)
                    {
                        String sql1 = String.Format("select * from `c#_store`.manu limit {0} ", i.ToString());
                        MySqlCommand comm1 = new MySqlCommand(sql1, conn);
                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = comm1;
                        //数据集
                        DataSet ds = new DataSet();
                        sda.Fill(ds, "manu");
                        String shop_name = ds.Tables[0].Rows[0]["manu_shop_name"].ToString().Trim();
                        String shop_price = ds.Tables[0].Rows[0]["manu_shop_price"].ToString().Trim();
                        String shop_number = ds.Tables[0].Rows[0]["manu_shop_number"].ToString().Trim();
                        String stock_supplier_shop_name =
                            String.Format(
                                "select * from `c#_store`.stock_supplier where `c#_store`.stock_supplier.supplier_shop_name='{0}'",
                                shop_name);
                        MySqlCommand comm_supplier = new MySqlCommand(stock_supplier_shop_name, conn);
                      
                        if (Convert.ToInt32(comm_supplier.ExecuteScalar()) > 0)
                        {
                            MySqlDataAdapter sda1 = new MySqlDataAdapter();
                            sda1.SelectCommand = comm_supplier;
                            DataSet ds1 = new DataSet();
                            sda1.Fill(ds1, "stock_supplier");
                            String supplier_shop_number =
                                ds1.Tables[0].Rows[0]["SUPPLIER_SHOP_NUMBER"].ToString().Trim();
                            if (Convert.ToInt32((supplier_shop_number)) >= Convert.ToInt32(shop_number))
                            {
                                String shop_number_sql1 =
                                    String.Format(
                                        "update `c#_store`.stock_supplier set `c#_store`.stock_supplier.supplier_shop_number= {0}-{1} where supplier_shop_name ='{2}'",
                                        supplier_shop_number, shop_number,shop_name);
                                MySqlCommand comm2 = new MySqlCommand(shop_number_sql1, conn);
                                if (comm2.ExecuteNonQuery() > 0)
                                {
                                    //商品名是否存在
                                    String select_a =
                                        String.Format(
                                            "select * from `c#_store`.stock_store where stock_shop_name ='{0}'",
                                            shop_name);
                                    MySqlCommand comm_s = new MySqlCommand(select_a, conn);
                                    if (Convert.ToInt32(comm_s.ExecuteScalar()) > 0)
                                    {
                                        String sql10 = String.Format(
                                            "select * from `c#_store`.stock_store where stock_shop_name ='{0}' limit 1",
                                            shop_name);
                                        MySqlCommand comm10 = new MySqlCommand(sql10, conn);
                                        MySqlDataAdapter sda10 = new MySqlDataAdapter();
                                        sda.SelectCommand = comm10;
                                        //数据集
                                        DataSet ds10 = new DataSet();
                                        sda.Fill(ds10, "stock_store");
                                        String number = ds10.Tables[0].Rows[0]["stock_shop_number"].ToString().Trim();
                                        String update_sql = String.Format(
                                            "update `c#_store`.stock_store  set  stock_shop_number={0}+{1} where stock_shop_name='{2}'", number,
                                            shop_number,shop_name);
                                        MySqlCommand comm_update_sql = new MySqlCommand(update_sql, conn);
                                        int num5 = comm_update_sql.ExecuteNonQuery();
                                        if (num5 > 0)
                                        {
                                            String manu_sql = String.Format(
                                                "delete from `c#_store`.manu where manu_shop_name ='{0}'", shop_name);
                                            MySqlCommand comm6 = new MySqlCommand(manu_sql, conn);
                                            int num6 = comm6.ExecuteNonQuery();
                                            if (num6 > 0)
                                            {
                                                String sql7 = String.Format(
                                                    "delete from `c#_store`.stock_supplier where supplier_shop_number= 0");
                                                MySqlCommand comm7 = new MySqlCommand(sql7, conn);
                                                comm7.ExecuteNonQuery();
                                                MessageBox.Show("该订单更新成功");
                                            }
                                            else
                                            {
                                                MessageBox.Show("该订单库存删除失败");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("该订单更新插入失败");
                                        }
                                    }
                                    else
                                    {
                                        String insert_sql = String.Format(
                                            "insert into `c#_store`.stock_store (stock_shop_name, stock_shop_price, stock_shop_number) VALUES ('{0}','{1}','{2}')",
                                            shop_name, shop_price, shop_number);
                                        MySqlCommand comm4 = new MySqlCommand(insert_sql, conn);
                                        int num4 = comm4.ExecuteNonQuery();
                                        if (num4 > 0)
                                        {
                                            String manu_sql = String.Format(
                                                "delete from `c#_store`.manu where manu_shop_name ='{0}'", shop_name);
                                            MySqlCommand comm6 = new MySqlCommand(manu_sql, conn);
                                            int num6 = comm6.ExecuteNonQuery();
                                            if (num6 > 0)
                                            {
                                                String sql7 = String.Format(
                                                    "delete from `c#_store`.stock_supplier where supplier_shop_number= 0");
                                                MySqlCommand comm7 = new MySqlCommand(sql7, conn);
                                                comm7.ExecuteNonQuery();
                                                MessageBox.Show("该订单更新成功");
                                            }
                                            else
                                            {
                                                MessageBox.Show("该订单库存删除失败");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("该订单更新插入失败");
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("该订单库存请求,供应商库存失败");
                                }
                            }
                            else
                            {
                                MessageBox.Show("该订单库存不足,是否需求剩余订单");
                            }
                        }
                        else
                        {
                            MessageBox.Show("供应商该订单无库存");
                        }
                    }
                }
                else
                {
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

        private void manu_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database2 db = new Database2();
            MySqlConnection conn = db.getConn(); 
            try
            {
                conn.Open();
                int index = dataGridView3.CurrentRow.Index;
                String value = dataGridView3.Rows[index].Cells[0].Value.ToString();
                String sql = String.Format("delete from `c#_store`.manu where `c#_store`.manu.manu_id = '{0}'", value);
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
    }
}