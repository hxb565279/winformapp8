using System;
using System.Windows.Forms;
using WindowsFormsApp7;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp8
{
    public partial class create2 : Form
    {
        public create2()
        {
            InitializeComponent();
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

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void ord_person_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void shop_name_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void shop_price_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void shop_number_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void re_person_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void phone_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void address_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            String ord_name = this.ord_person_box.Text;
            Database2 db= new Database2();
            MySqlConnection conn = db.getConn();
            String shop_name = this.shop_name_box.Text;
            String shop_price = this.shop_price_box.Text;
            String shop_number = this.shop_number_box.Text;
            String person = this.re_person_box.Text;
            String phone = this.phone_box.Text;
            String address = this.address_box.Text;
            if (ord_name == "" || shop_name == "" || shop_price == "" || shop_number == "" || person == "" ||
                phone == "" || address == "")
            {
                MessageBox.Show("输入为空 ");
            }
            else
            {
                try
                {
                    conn.Open();
                    String sql = String.Format("select * from  `c#_store`.user_supplier where `c#_store`.user_supplier.username = '{0}'",
                        ord_name);
                    MySqlCommand comm = new MySqlCommand(sql, conn);
                    if (Convert.ToInt32(comm.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("该用户已存入系统,将更新订单");
                        String sql6 = String.Format("select id from `c#_store`.user_supplier where `c#_store`.user_supplier.username = '{0}'",
                            ord_name);
                        String sql7 = String.Format("select * from `c#_store`.manu where `c#_store`.manu.manu_shop_name='{0}'",
                            shop_name);
                        MySqlCommand comm6 = new MySqlCommand(sql6, conn);
                        MySqlCommand COMM7 = new MySqlCommand(sql7, conn);
                        int num6 = comm6.ExecuteNonQuery();
                        int num7 = Convert.ToInt32(COMM7.ExecuteScalar());
                        //该用户的该订单商品存在
                        if (num7 > 0)
                        {
                            String num = Interaction.InputBox("添加商品数量", "添加", "", 3, 3);

                            String sql8 =
                                String.Format(
                                    "update `c#_store`.manu set `c#_store`.manu.manu_shop_number= `c#_store`.manu.manu_shop_number+ '{0}' ,`c#_store`.manu.manu_data='{1}'",
                                    num, DateTime.Now.ToString());
                            MySqlCommand comm8 = new MySqlCommand(sql8, conn);
                            int num8 = comm8.ExecuteNonQuery();
                            if (num8 > 0)
                            {
                                MessageBox.Show("更新订单成功");
                                manu m = new manu();
                                m.selectall3();
                            }
                            else
                            {
                                MessageBox.Show("更新订单失败");
                            }
                        }
                        else
                        {
                            MessageBox.Show("该订单不存在");
                            String sql10 = String.Format("select id from `c#_store`.user_supplier where `c#_store`.user_supplier.username = '{0}'",
                                ord_name);
                            MySqlCommand comm10 = new MySqlCommand(sql10, conn);
                            int num10 = Convert.ToInt32(comm10.ExecuteScalar());
                            String sql9 = String.Format(
                                "insert into `c#_store`.manu(manu_shop_name, manu_shop_price, manu_shop_number, manu_re_person, manu_re_phone, manu_re_address, manu_data, manu_out_user) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                                shop_name,shop_price,shop_number,person,phone,address,DateTime.Now.ToString(),num10.ToString());
                            MySqlCommand comm9 = new MySqlCommand(sql9,conn);
                           int num9 =    comm9.ExecuteNonQuery();
                           if (num9>0)
                           {
                               MessageBox.Show("订单更新成功");
                               manu m = new manu();
                               m.selectall3();
                           }
                           else
                           {
                               MessageBox.Show("订单更新失败");

                           }
                        }
                    }
                    else
                    {
                        MessageBox.Show("该用户为新用户,将注册");


                        String sql2 =
                            String.Format(" insert into `c#_store`.user_supplier   (username) values ('{0}') ",
                                ord_name);
                        MySqlCommand comm2 = new MySqlCommand(sql2, conn);
                        comm2.ExecuteNonQuery();
                        String sql4 = String.Format("select id from `c#_store`.user_supplier where username = '{0}'",
                            ord_name);
                        MySqlCommand comm4 = new MySqlCommand(sql4, conn);
                        int num = Convert.ToInt32(comm4.ExecuteScalar());
                        if (num > 0)
                        {
                            String sql3 = String.Format(
                                "insert into `c#_store`.manu(manu_shop_name, manu_shop_price, manu_shop_number, manu_re_person, manu_re_phone, manu_re_address, manu_data, manu_out_user) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')     ",
                                shop_name, shop_price, shop_number, person, phone, address, DateTime.Now.ToString(),
                                num.ToString());
                            MySqlCommand comm3 = new MySqlCommand(sql3, conn);
                            int num3 = comm3.ExecuteNonQuery();
                            if (num3 > 0)
                            {
                                MessageBox.Show("添加订单成功");
                                manu m = new manu();
                                m.selectall3();
                            }
                            else
                            {
                                MessageBox.Show("添加订单失败");
                            }
                        }
                        else
                        {
                            MessageBox.Show("添加订单失败");
                            string sql5 = String.Format("delete from `c#_store`.user_supplier where username='{0}'",
                                ord_name);
                            MySqlCommand comm5 = new MySqlCommand(sql5, conn);
                            comm5.ExecuteNonQuery();
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
            
            
            
        }

        private void close_Click(object sender, EventArgs e)
        {
           this.Close();

        }
    }
}