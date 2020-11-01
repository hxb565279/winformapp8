using System;
using System.Windows.Forms;
using WindowsFormsApp7;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp8
{
    public partial class create1 : Form
    {
        public create1()
        {
            InitializeComponent();
        }

        private void ord_name_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void shop_name_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void create1_Load(object sender, EventArgs e)
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


        private void pricebox_TextChanged(object sender, EventArgs e)
        {
        }

        private void numberbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void person_TextChanged(object sender, EventArgs e)
        {
        }

        private void phonebox_TextChanged(object sender, EventArgs e)
        {
        }

        private void addressbox_TextChanged(object sender, EventArgs e)
        {
        }


        private void createbox1_Click(object sender, EventArgs e)
        {
            String ord_name = this.ord_name.Text;
            Database2 db = new Database2();
            MySqlConnection conn = db.getConn();
            String shop_name = this.shop_name.Text;
            String shop_price = this.pricebox.Text;
            String shop_number = this.numberbox.Text;
            String person = this.person.Text;
            String phone = this.phonebox.Text;
            String address = this.addressbox.Text;
            if (ord_name == "" || shop_name == "" || shop_price == "" || shop_number == "" || person == "" ||
                phone == "" || address == "")
            {
                MessageBox.Show("输入为空");
            }
            else
            {
                try
                {
                    conn.Open();
                    String sql = String.Format("select * from  `c#_store`.user_customer where username = '{0}'",
                        ord_name);
                    MySqlCommand comm = new MySqlCommand(sql, conn);
                    if (Convert.ToInt32(comm.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("该用户已存入系统,将更新订单");
                        String sql6 = String.Format("select id from `c#_store`.user_customer where username = '{0}'",ord_name);
                        String sql7 = String.Format("select * from `c#_store`.outbound where outbound_shop_name='{0}'",shop_name);
                        MySqlCommand comm6 = new MySqlCommand(sql6,conn);
                        MySqlCommand COMM7 = new MySqlCommand(sql7,conn);
                        int num6 = comm6.ExecuteNonQuery();
                        int num7 = Convert.ToInt32(COMM7.ExecuteScalar());
                        //该用户的该订单商品存在
                        if ( num7 > 0)
                        {
                          String num =   Interaction.InputBox("添加商品数量", "添加", "", 3, 3);
                            
                            String sql8 = String.Format("update `c#_store`.outbound  set outbound_shop_number= outbound_shop_number+ '{0}' ,outbound_data='{1}'",num,DateTime.Now.ToString());
                            MySqlCommand comm8 = new MySqlCommand(sql8,conn);
                             int num8 =     comm8.ExecuteNonQuery();
                             if (num8>0)
                             {
                                 MessageBox.Show("更新订单成功");
                             }
                             else
                             {
                                 MessageBox.Show("更新订单失败");
                             }
                        }
                        else
                        {
                            
                        }



                    }
                    else
                    {
                        MessageBox.Show("该用户为新用户,将注册");


                        String sql2 =
                            String.Format(" insert into `c#_store`.user_customer   (username) values ('{0}') ",
                                ord_name);
                        MySqlCommand comm2 = new MySqlCommand(sql2, conn);
                        comm2.ExecuteNonQuery();
                        String sql4 = String.Format("select id from `c#_store`.user_customer where username = '{0}'",
                            ord_name);
                        MySqlCommand comm4 = new MySqlCommand(sql4, conn);
                        int num = Convert.ToInt32(comm4.ExecuteScalar());
                        if (num > 0)
                        {
                            String sql3 = String.Format(
                                "insert into `c#_store`.outbound (outbound_shop_name, outbound_shop_price, outbound_shop_number, outbound_to_person, outbound_to_phone, outbound_to_address, outbound_data,out_user_id) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')     ",
                                shop_name, shop_price, shop_number, person, phone, address, DateTime.Now.ToString(),
                                num.ToString());
                            MySqlCommand comm3 = new MySqlCommand(sql3, conn);
                            int num3 = comm3.ExecuteNonQuery();
                            if (num3 > 0)
                            {
                                MessageBox.Show("添加订单成功");
                            }
                            else
                            {
                                MessageBox.Show("添加订单失败");
                            }
                        }
                        else
                        {
                            MessageBox.Show("添加订单失败");
                            string sql5 = String.Format("delete from `c#_store`.user_customer where username='{0}'",
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

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}