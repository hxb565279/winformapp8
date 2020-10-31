using System;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp7
{
    public class Database1
    {
         public MySqlConnection getConn()
                {
                    String strConnection = "server=49.233.223.51;User id = root;password=AaA123456;Database=c#_customer;Charset=utf8;";
                    MySqlConnection conn = new MySqlConnection(strConnection);
                    return conn;
                }
    }
}