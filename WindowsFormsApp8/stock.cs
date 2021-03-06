﻿using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp7;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;

namespace WindowsFormsApp8
{
    public partial class stock : Form
    {
        public stock()
        {
            InitializeComponent();
            selectall();
            String   username=        Form1.form1.username;
            MessageBox.Show("欢迎管理员"+username);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkbutton1_Click(object sender, EventArgs e)
        {
            String shop_name = this.textBox1.Text;
            string shop_price = this.textBox2.Text;
            string shop_number = this.textBox3.Text;
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
                        String sql1 = String.Format("select * from stock_store where stock_shop_name like '%{0}%'",
                            shop_name);
                        MySqlCommand comm = new MySqlCommand(sql1, conn);
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
                    else if (shop_name == "" && shop_price != "" && shop_number == "")
                    {
                        String sql1 = String.Format("select * from stock_store where stock_shop_price like '%{0}%'",
                            shop_price);
                        MySqlCommand comm = new MySqlCommand(sql1, conn);
                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = comm;
                        //数据集
                        DataSet ds = new DataSet();
                        sda.Fill(ds, "stock_store");
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
                            "select * from stock_store group by  stock_shop_number having count(*) < number3 ";
                        MySqlCommand comm = new MySqlCommand(sql1, conn);
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
                    else if (shop_name != "" && shop_price != "" && shop_number == "")
                    {
                        String sql1 =
                            String.Format(
                                "select * from stock_store where stock_shop_name like '%{0}%' and stock_shop_price like  '%{1}%'",
                                shop_name, shop_price);
                        MySqlCommand comm = new MySqlCommand(sql1, conn);
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
                    else if (shop_name != "" && shop_price == "" && shop_number != "")
                    {
                        String sql1 =
                            String.Format(
                                "select * from stock_store where stock_shop_name like '%{0}%' and stock_shop_number like  '%{1}%'",
                                shop_name, shop_number);
                        MySqlCommand comm = new MySqlCommand(sql1, conn);
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
                    else if (shop_name == "" && shop_price != "" && shop_number != "")
                    {
                        String sql1 =
                            String.Format(
                                "select * from stock_store where stock_shop_name like '%{0}%' and stock_shop_price like '%{1}%'",
                                shop_name, shop_price);
                        MySqlCommand comm = new MySqlCommand(sql1, conn);
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
                    else
                    {
                        String sql1 =
                            String.Format(
                                "select * from stock_store where stock_shop_name like '%{0}%' and stock_shop_price  like '%{1}%' and stock_shop_number like '%{2}%'",
                                shop_name, shop_price, shop_number);
                        MySqlCommand comm = new MySqlCommand(sql1, conn);
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
                String sql = String.Format("select *  from stock_store");
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
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void add_stock_Click(object sender, EventArgs e)
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
                    String sql2 = String.Format("select * from stock_store where stock_shop_name = '{0}' ", shop_name);
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
                                String.Format("select stock_shop_number from stock_store where stock_shop_name = '{0}'",
                                    shop_name);
                            String sql5 =
                                String.Format("select stock_shop_price from stock_store where stock_shop_name = '{0}'",
                                    shop_name);
                            MySqlCommand comm3 = new MySqlCommand(sql4, conn);
                            MySqlCommand comm5 = new MySqlCommand(sql5, conn);
                            int numbers = Convert.ToInt32(comm3.ExecuteScalar());
                            String sql3 =
                                String.Format(
                                    "update  stock_store  set    stock_shop_number='{2}' where stock_shop_name='{0}' ",
                                    shop_name, comm5.ExecuteNonQuery().ToString(), (numbers + nums).ToString());
                            MySqlCommand comm4 = new MySqlCommand(sql3, conn);
                            int num1 = comm4.ExecuteNonQuery();
                            if (num1 > 0)
                            {
                                MessageBox.Show("插入成功");
                                Form1.form1.库存管理ToolStripMenuItem_Click(null, null);
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
                                    "insert into stock_store (stock_shop_name,stock_shop_price,stock_shop_number) values ('{0}','{1}','{2}')",
                                    shop_name, shop_price2, shop_number2);

                            MySqlCommand comm = new MySqlCommand(sql, conn);
                            int num = comm.ExecuteNonQuery();
                            if (num > 0)
                            {
                                MessageBox.Show("插入成功");
                                Form1.form1.库存管理ToolStripMenuItem_Click(null, null);
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

        private void delete1_Click(object sender, EventArgs e)
        {
            Database2 db = new Database2();
            MySqlConnection conn = db.getConn();
            try
            {
                String name = Interaction.InputBox("商品名", "删除", "", 3, 3);
                if (name == "")
                {
                    MessageBox.Show("输入为空");
                }
                else
                {
                    conn.Open();
                    String sql =
                        String.Format("select stock_shop_number from stock_store where stock_shop_name = '{0}'", name);
                    String sql2 = String.Format("select * from stock_store where stock_shop_name = '{0}'", name);
                    MySqlCommand comm1 = new MySqlCommand(sql, conn);
                    MySqlCommand comm = new MySqlCommand(sql2, conn);
                    int num3 = Convert.ToInt32(comm.ExecuteScalar());
                    if (num3 > 0)
                    {
                        int numbers = Convert.ToInt32(comm1.ExecuteScalar());
                        if (numbers < 5 && numbers > 0)
                        {
                            MessageBox.Show(name + "库存仅剩" + numbers.ToString() + "请及时进货");
                        }
                        else
                        {
                            MessageBox.Show(name + "剩余数量为" + numbers.ToString());
                        }

                        String num2 = Interaction.InputBox("要删除数量", "删除", "", 3, 3);
                        int num22 = Convert.ToInt32(num2);
                        if (num22 >= numbers)
                        {
                            MessageBox.Show("删除商品数量够多,库存不足");
                        }
                        else
                        {
                            String sql3 =
                                String.Format(
                                    "update stock_store set stock_shop_number= '{0}' where stock_shop_name='{1}'",
                                    (numbers - num22).ToString(), name);
                            MySqlCommand COMM = new MySqlCommand(sql3, conn);
                            int num4 = COMM.ExecuteNonQuery();
                            if (num4 > 0)
                            {
                                MessageBox.Show("删除成功");
                                Form1.form1.库存管理ToolStripMenuItem_Click(null, null);
                            }
                            else
                            {
                                MessageBox.Show("删除失败");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("该商品已无");
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
                String sql = String.Format("delete from stock_store where stock_id = '{0}'", value);
                MySqlCommand comm = new MySqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("删除成功");
                Form1.form1.库存管理ToolStripMenuItem_Click(null, null);
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

        private void updateone_Click(object sender, EventArgs e)
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
                    "update stock_store set stock_shop_name='{0}',stock_shop_price='{1}',stock_shop_number='{2}'     where stock_id='{3}'", value0,
                    value1, value2, value);
                MySqlCommand comm = new MySqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("修改成功");
                Form1.form1.库存管理ToolStripMenuItem_Click(null, null);
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

        private void add2_Click(object sender, EventArgs e)
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

                String sql = String.Format(
                    "insert into stock_store (stock_id,stock_shop_name,stock_shop_price,stock_shop_number) values('{0}','{1}','{2}','{3}')", value0, value1
                    , value2, value3);
                MySqlCommand comm = new MySqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("插入成功");
             Form1.form1.库存管理ToolStripMenuItem_Click(null,null);
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