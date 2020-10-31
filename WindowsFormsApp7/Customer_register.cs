using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp7
{
    public partial class Customer_register : Form
    {
        public Customer_register()
        {
            InitializeComponent();
        }


        private void register_customer1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void register_customer2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void register_customer_Click(object sender, EventArgs e)
        {
            String username = this.register_customer1.Text;
            String password = this.register_customer2.Text;
            Database1 db1 = new Database1();
            MySqlConnection conn1 = db1.getConn();
            if (username.Equals("")||password.Equals(""))
            {
                MessageBox.Show("账号密码为空");
            }
            else
            {
                try
                {
                   conn1.Open();
                   String  sql1 = String.Format("select * from user_customer where username= '{0}'",username);
                   MySqlCommand comm1 = new MySqlCommand(sql1,conn1);
                   String sql2=  String.Format("insert into user_customer (username,password) values ('{0}','{1}')",username,password);
                   MySqlCommand comm2 = new MySqlCommand(sql2,conn1);
                   if (Convert.ToInt32( comm1.ExecuteScalar())>0)
                   {
                       MessageBox.Show("账号已经注册,请登录");
                   }
                   else
                   {
                       comm2.ExecuteNonQuery();
                       MessageBox.Show("注册成功");
                   }

                  
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
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