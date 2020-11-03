using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp7;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp8
{
    public partial class stock_supplier : Form
    {
        public stock_supplier()
        {
            InitializeComponent();
            selectall();
        }

        public void selectall()
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
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "id";
                dataGridView1.Columns[1].HeaderText = "商品名";
                dataGridView1.Columns[2].HeaderText = "价格";
                dataGridView1.Columns[3].HeaderText = "数量";
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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void stock_supplier_Load(object sender, EventArgs e)
        {
        }

//添加库存
        private void add1_Click(object sender, EventArgs e)
        {
             Database2 db = new Database2();
            MySqlConnection conn = db.getConn();
            try
            {
                string shop_name = Interaction.InputBox("商品名", "添加库存信息", "", 3, 3);
                if (shop_name == "")
                {
                    MessageBox.Show("填写为空 ");
                }
                else
                {
                    conn.Open();
                    String sql2 = String.Format("select * from `c#_store`.stock_supplier where `c#_store`.stock_supplier.supplier_shop_name = '{0}' ", shop_name);
                    MySqlCommand comm1 = new MySqlCommand(sql2, conn);
                    if (Convert.ToInt32(comm1.ExecuteScalar()) > 0)
                    {
                        string shop_number = Interaction.InputBox("商品数量", "添加库存信息", "", 3, 3);
                        int nums = Convert.ToInt32(shop_number);
                        if (shop_number == "")
                        {
                            MessageBox.Show("输入的数量为空");
                        }
                        else
                        {
                            String sql4 =
                                String.Format("select `c#_store`.stock_supplier.supplier_shop_number  from `c#_store`.stock_supplier where `c#_store`.stock_supplier.supplier_shop_name = '{0}'",
                                    shop_name);
                            String sql5 =
                                String.Format("select `c#_store`.stock_supplier.supplier_shop_price from `c#_store`.stock_supplier where `c#_store`.stock_supplier.supplier_shop_name = '{0}'",
                                    shop_name);
                            MySqlCommand comm3 = new MySqlCommand(sql4, conn);
                            MySqlCommand comm5 = new MySqlCommand(sql5, conn);
                            int numbers = Convert.ToInt32(comm3.ExecuteScalar());
                            String sql3 =
                                String.Format(
                                    "update  `c#_store`.stock_supplier  set    `c#_store`.stock_supplier.supplier_shop_number='{2}' where `c#_store`.stock_supplier.supplier_shop_name='{0}' ",
                                    shop_name, comm5.ExecuteNonQuery().ToString(), (numbers + nums).ToString());
                            MySqlCommand comm4 = new MySqlCommand(sql3, conn);
                            int num1 = comm4.ExecuteNonQuery();
                            if (num1 > 0)
                            {
                                MessageBox.Show("插入成功");
                                selectall();
                            }
                            else
                            {
                                MessageBox.Show("插入失败");
                            }
                        }
                    }
                    else
                    {
                        string shop_price2 = Interaction.InputBox("商品价格", "添加库存信息", "", 3, 3);
                        string shop_number2 = Interaction.InputBox("商品数量", "添加库存信息", "", 3, 3);
                        if (shop_price2 == "" || shop_number2 == "")
                        {
                            MessageBox.Show("输入为空");
                        }
                        else
                        {
                            String sql =
                                String.Format(
                                    "insert into `c#_store`.stock_supplier (`c#_store`.stock_supplier.supplier_shop_name,`c#_store`.stock_supplier.supplier_shop_price,`c#_store`.stock_supplier.supplier_shop_number) values ('{0}','{1}','{2}')",
                                    shop_name, shop_price2, shop_number2);
                            MySqlCommand comm = new MySqlCommand(sql, conn);
                            int num = comm.ExecuteNonQuery();
                            if (num > 0)
                            {
                                MessageBox.Show("插入成功");
                               selectall();
                            }
                            else
                            {
                                MessageBox.Show("插入失败");
                            }
                        }
                    }
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

     


        private void deleteone_Click(object sender, EventArgs e)
        {
            Database2 db = new Database2();
            MySqlConnection conn = db.getConn();
            try
            {
                conn.Open();
                int index = dataGridView1.CurrentRow.Index;
                String value = dataGridView1.Rows[index].Cells[0].Value.ToString();
                String sql = String.Format("delete from `c#_store`.stock_supplier where `c#_store`.stock_supplier.stock_supplier_id= '{0}'", value);
                MySqlCommand comm = new MySqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("删除成功");
                selectall();
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