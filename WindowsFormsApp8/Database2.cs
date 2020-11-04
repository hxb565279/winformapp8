using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp7
{
    public class Database2
    {
        public MySqlConnection getConn()
        {
            String strConnection =
                "server=localhost; User id = root; password=123456; Database=c#_store; Character Set=utf8; ";
            MySqlConnection conn = new MySqlConnection(strConnection);
            return conn;
        }


        public void insert(String sql)
        {
            MySqlConnection conn = getConn();
            conn.Open();
            String sql1 = String.Format("insert into `c#_store`.login_sql (`sql`, data) VALUES ('{0}','{1}')", sql,
                DateTime.Now.ToString());
            MySqlCommand comm = new MySqlCommand(sql1, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }

        public void insert_re(String sql)
        {
            MySqlConnection conn = getConn();
            conn.Open();
            String sql1 = String.Format("insert into re_sql (`sql`, data) VALUES ('{0}','{1}')", sql,
                DateTime.Now.ToString());
            MySqlCommand comm = new MySqlCommand(sql1, conn);
             comm.ExecuteNonQuery();
            conn.Close();
        }
        
        public void insert_to(String sql)
        {
            MySqlConnection conn = getConn();
            conn.Open();
            String sql1 = String.Format("insert into to_sql (`sql`, data) VALUES ('{0}','{1}')", sql,
                DateTime.Now.ToString());
            MySqlCommand comm = new MySqlCommand(sql1, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        
        
        
    }
}