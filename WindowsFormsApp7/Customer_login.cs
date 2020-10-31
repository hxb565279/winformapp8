using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp7
{
    public partial class Customer_login : Form
    {
        public Customer_login()
        {
            InitializeComponent();
        }

        private void customer_login1_TextChanged(object sender, EventArgs e)
        {
        }

        private void customer_login2_TextChanged(object sender, EventArgs e)
        {
        }

        private void customer_login3_Click(object sender, EventArgs e)
        {
            String username = this.customer_login1.Text;
            String password = this.customer_login2.Text;
            Database1 db1 = new Database1();
            MySqlConnection conn1 = db1.getConn();
            if (username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("账号或密码为空");
            }
            else
            {
                try
                {
                    conn1.Open();
                    String sql1 = String.Format("select * from user_customer where username= '{0}' ", username);
                    MySqlCommand comm2 = new MySqlCommand(sql1, conn1);
                    if (Convert.ToInt32(comm2.ExecuteScalar()) > 0)
                    {
                        String sql = String.Format("select username,password from user_customer where username = '{0}' limit 1",
                            username);
                        MySqlCommand comm1 = new MySqlCommand(sql, conn1);
                        MySqlDataReader reader = comm1.ExecuteReader();
                        while (reader.Read())
                        {
                            String username1 = reader[0].ToString();
                            String password1 = reader[1].ToString();
                            if (username1 != null && password.Equals(password1))
                            {
                                MessageBox.Show("登录成功");
                            }
                            else
                            {
                                MessageBox.Show("密码错误,请重新输入");
                            }
                        }
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("账户不存在,请注册");
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    MessageBox.Show(exception.Message.ToString());
                }
                finally
                {
                    conn1.Close();
                }
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
    }
}