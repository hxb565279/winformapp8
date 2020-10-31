using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp7
{
    public partial class store_register : Form
    {
        public store_register()
        {
            InitializeComponent();
        }

        private void store_register_box1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void store_register_box2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void 店铺注册_button_Click(object sender, EventArgs e)
        {
            String username = this.store_register_box1.Text;
            String password = this.store_register_box2.Text;
            Database2 db2  = new Database2();
            MySqlConnection conn = db2.getConn();
            if (username.Equals("")||password.Equals(""))
            {
                MessageBox.Show("账号密码为空");
            }
            else
            {
                try
                {
                    conn.Open();
                    String  sql1 = String.Format("select * from user_store where username= '{0}'",username);
                    MySqlCommand comm1 = new MySqlCommand(sql1,conn);
                    String sql2=  String.Format("insert into user_store (username,password) values ('{0}','{1}')",username,password);
                    MySqlCommand comm2 = new MySqlCommand(sql2,conn);
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
                }
                finally
                {
                    conn.Close();
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