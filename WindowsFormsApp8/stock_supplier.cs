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
            String   username=        Form1.form1.username;
            MessageBox.Show("欢迎管理员"+username);
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

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void shop_name_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void shop_price_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void shop_number_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String shop_name = this.shop_name_box.Text;
            String shop_price = this.shop_price_box.Text;
            String shop_number = this.shop_number_box.Text;
             Database2 db = new Database2();

            MySqlConnection conn = db.getConn();
            try
            {
                conn.Open();
                if (shop_name == "" && shop_price == "" && shop_number == "")
                {
                    MessageBox.Show("填入信息为空");
                }
                else
                {
                    if (shop_name != "" && shop_price == "" && shop_number == "")
                    {
                        String sql1 = String.Format("select * from `c#_store`.stock_supplier where `c#_store`.stock_supplier.supplier_shop_name like '%{0}%'",
                            shop_name);
                        MySqlCommand comm = new MySqlCommand(sql1, conn);
                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = comm;
                        //数据集
                        DataSet ds = new DataSet();
                        sda.Fill(ds, "stock_supplier");
                        dataGridView1.DataSource = ds.Tables[0];
                        dataGridView1.Columns[0].HeaderText = "id";
                        dataGridView1.Columns[1].HeaderText = "商品名";
                        dataGridView1.Columns[2].HeaderText = "价格";
                        dataGridView1.Columns[3].HeaderText = "数量";
                    }
                    else if (shop_name == "" && shop_price != "" && shop_number == "")
                    {
                        String sql1 = String.Format("select * from `c#_store`.stock_supplier where `c#_store`.stock_supplier.supplier_shop_price like '%{0}%'",
                            shop_price);
                        MySqlCommand comm = new MySqlCommand(sql1, conn);
                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = comm;
                        //数据集
                        DataSet ds = new DataSet();
                        sda.Fill(ds, "stock_supplier");
                        dataGridView1.DataSource = ds.Tables[0];
                        dataGridView1.Columns[0].HeaderText = "id";
                        dataGridView1.Columns[1].HeaderText = "商品名";
                        dataGridView1.Columns[2].HeaderText = "价格";
                        dataGridView1.Columns[2].HeaderText = "价格";
                        dataGridView1.Columns[3].HeaderText = "数量";
                    }
                    else if (shop_name == "" && shop_price == "" && shop_number != "")
                    {
                        String sql1 =
                          Strings.Format(  "select * from `c#_store`.stock_supplier group by  `c#_store`.stock_supplier.supplier_shop_number having count(*) < '{0}' ",shop_number);
                        MySqlCommand comm = new MySqlCommand(sql1, conn);
                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = comm;
                        //数据集
                        DataSet ds = new DataSet();
                        sda.Fill(ds, "stock_supplier");
                        dataGridView1.DataSource = ds.Tables[0];
                        dataGridView1.Columns[0].HeaderText = "id";
                        dataGridView1.Columns[1].HeaderText = "商品名";
                        dataGridView1.Columns[2].HeaderText = "价格";
                        dataGridView1.Columns[3].HeaderText = "数量";
                    }
                    else if (shop_name != "" && shop_price != "" && shop_number == "")
                    {
                        String sql1 =
                            String.Format(
                                "select * from `c#_store`.stock_supplier where `c#_store`.stock_supplier.supplier_shop_name like '%{0}%' and `c#_store`.stock_supplier.supplier_shop_price like  '%{1}%'",
                                shop_name, shop_price);
                        MySqlCommand comm = new MySqlCommand(sql1, conn);
                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = comm;
                        //数据集
                        DataSet ds = new DataSet();
                        sda.Fill(ds, "stock_supplier");
                        dataGridView1.DataSource = ds.Tables[0];
                        dataGridView1.Columns[0].HeaderText = "id";
                        dataGridView1.Columns[1].HeaderText = "商品名";
                        dataGridView1.Columns[2].HeaderText = "价格";
                        dataGridView1.Columns[3].HeaderText = "数量";
                    }
                    else if (shop_name != "" && shop_price == "" && shop_number != "")
                    {
                        String sql1 =
                            String.Format(
                                "select * from `c#_store`.stock_supplier where `c#_store`.stock_supplier.supplier_shop_name like '%{0}%' and `c#_store`.stock_supplier.supplier_shop_number like  '%{1}%'",
                                shop_name, shop_number);
                        MySqlCommand comm = new MySqlCommand(sql1, conn);
                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = comm;
                        //数据集
                        DataSet ds = new DataSet();
                        sda.Fill(ds, "stock_supplier");
                        dataGridView1.DataSource = ds.Tables[0];
                        dataGridView1.Columns[0].HeaderText = "id";
                        dataGridView1.Columns[1].HeaderText = "商品名";
                        dataGridView1.Columns[2].HeaderText = "价格";
                        dataGridView1.Columns[3].HeaderText = "数量";
                    }
                    else if (shop_name == "" && shop_price != "" && shop_number != "")
                    {
                        String sql1 =
                            String.Format(
                                "select * from `c#_store`.stock_supplier where `c#_store`.stock_supplier.supplier_shop_name like '%{0}%' and `c#_store`.stock_supplier.supplier_shop_price like '%{1}%'",
                                shop_name, shop_price);
                        MySqlCommand comm = new MySqlCommand(sql1, conn);
                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = comm;
                        //数据集
                        DataSet ds = new DataSet();
                        sda.Fill(ds, "stock_supplier");
                        dataGridView1.DataSource = ds.Tables[0];
                        dataGridView1.Columns[0].HeaderText = "id";
                        dataGridView1.Columns[1].HeaderText = "商品名";
                        dataGridView1.Columns[2].HeaderText = "价格";
                        dataGridView1.Columns[3].HeaderText = "数量";
                    }
                    else
                    {
                        String sql1 =
                            String.Format(
                                "select * from `c#_store`.stock_supplier where `c#_store`.stock_supplier.supplier_shop_name like '%{0}%' and `c#_store`.stock_supplier.supplier_shop_price  like '%{1}%' and `c#_store`.stock_supplier.supplier_shop_number like '%{2}%'",
                                shop_name, shop_price, shop_number);
                        MySqlCommand comm = new MySqlCommand(sql1, conn);
                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = comm;
                        //数据集
                        DataSet ds = new DataSet();
                        sda.Fill(ds, "stock_supplier");
                        dataGridView1.DataSource = ds.Tables[0];
                        dataGridView1.Columns[0].HeaderText = "id";
                        dataGridView1.Columns[1].HeaderText = "商品名";
                        dataGridView1.Columns[2].HeaderText = "价格";
                        dataGridView1.Columns[3].HeaderText = "数量";
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

        private void update_Click(object sender, EventArgs e)
        {
            Database2 db = new Database2();
            MySqlConnection conn = db.getConn();
            try
            {
                conn.Open();
                int index = dataGridView1.CurrentRow.Index;
                String value = dataGridView1.Rows[index].Cells[0].Value.ToString();
                String value0 = dataGridView1.Rows[index].Cells[1].Value.ToString();
                String value1 = dataGridView1.Rows[index].Cells[2].Value.ToString();
                String value2 = dataGridView1.Rows[index].Cells[3].Value.ToString();
                String sql = String.Format(
                    "update `c#_store`.stock_supplier set `c#_store`.stock_supplier.supplier_shop_name='{0}',`c#_store`.stock_supplier.supplier_shop_price='{1}',`c#_store`.stock_supplier.supplier_shop_number='{2}'     where `c#_store`.stock_supplier.stock_supplier_id='{3}'", value0,
                    value1, value2, value);
                MySqlCommand comm = new MySqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("修改成功");
                selectall();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message.ToString() + "打开数据库失败");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}