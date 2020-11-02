using System;
using System.Windows.Forms;
using WindowsFormsApp8;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp7
{
    public partial class store_login : Form
    {
      
        public store_login()
        {
            InitializeComponent();
        }
        private void store_login1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void store_login2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void store_button_Click(object sender, EventArgs e)
        {
            String username = this.store_login1.Text;
            String password = this.store_login2.Text;
            Database2 db = new Database2();
            MySqlConnection conn = db.getConn();
            if (username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("账号或密码为空");
            }
            else
            {
                try
                {
                    conn.Open();
                    String sql1 = String.Format("select * from `c#_store`.user_store where username= '{0}' ", username);
                    MySqlCommand comm2 = new MySqlCommand(sql1, conn);
                    if (Convert.ToInt32(comm2.ExecuteScalar()) > 0)
                    {
                        String sql = String.Format("select username,password from `c#_store`.user_store   where username = '{0}' limit 1",
                            username);
                        MySqlCommand comm1 = new MySqlCommand(sql, conn);
                        MySqlDataReader reader = comm1.ExecuteReader();
                        while (reader.Read())
                        {
                            String username1 = reader[0].ToString();
                            String password1 = reader[1].ToString();
                            if (username1 != null && password.Equals(password1))
                            {
                             Form1 form1 = new Form1();
                             form1.username = username;
                                MessageBox.Show("登录成功");
                                this.Close();
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
                        Form1.form1.注册ToolStripMenuItem_Click(null,null);
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