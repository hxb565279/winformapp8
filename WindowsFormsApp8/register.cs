using System;
using System.Windows.Forms;
using WindowsFormsApp7;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp8
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = this.textBox1.Text;
            String password = this.textBox2.Text;
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
                    String  sql1 = String.Format("select * from `c#_store`.user_store where username= '{0}'",username);
                    MySqlCommand comm1 = new MySqlCommand(sql1,conn);
                    String sql2=  String.Format("insert into `c#_store`.user_store (username,password) values ('{0}','{1}')",username,password);
                    MySqlCommand comm2 = new MySqlCommand(sql2,conn);
                    if (Convert.ToInt32( comm1.ExecuteScalar())>0)
                    {
                        MessageBox.Show("账号已经注册,请登录");
                        login l = new login();
                        l.Show();
                        this.Hide();
                    }
                    else
                    {
                        comm2.ExecuteNonQuery();
                        MessageBox.Show("注册成功");
                         login l = new login();
                         l.Show();
                         this.Hide();
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

        private void button2_Click(object sender, EventArgs e)
        {
            login l = new login();
            this.Hide();
            l.Show();
        }
    }
}