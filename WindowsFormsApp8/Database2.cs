using System;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp7
{
    public class Database2
    {
        public MySqlConnection getConn()
        {
            String strConnection = "server=localhost; User id = root; password=123456; Database=c#_store; Character Set=utf8; ";
            MySqlConnection conn = new MySqlConnection(strConnection);
            return conn;
        }
    }
}