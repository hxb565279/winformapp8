using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp7
{
    public partial class supplier_register : Form
    {
        public supplier_register()
        {
            InitializeComponent();
        }

        private void supplier_register_Load(object sender, EventArgs e)
        {
            
        }

        private void supplier_register_box1_TextChanged(object sender, EventArgs e)
        {
        }

        private void supplier_register_box2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void supplier_button_register_Click(object sender, EventArgs e)
        {
            String username = this.supplier_register_box1.Text;
            String password = this.supplier_register_box2.Text;
            Database2 db2 = new Database2();
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
                    String  sql1 = String.Format("select * from user_supplier where username= '{0}'",username);
                    MySqlCommand comm1 = new MySqlCommand(sql1,conn);
                    String sql2=  String.Format("insert into user_supplier (username,password) values ('{0}','{1}')",username,password);
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