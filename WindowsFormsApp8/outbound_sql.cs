using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp7;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp8
{
    public partial class outbound_sql : Form
    {
        public outbound_sql()
        {
            InitializeComponent();
            selectall();
        }

        public void selectall()
        {
            Database2 db = new Database2();
            MySqlConnection conn = db.getConn();
            try
            {
                conn.Open();
                String sql = String.Format("select *  from `c#_store`.to_sql");
                MySqlCommand comm = new MySqlCommand(sql, conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = comm;
                //数据集
                DataSet ds = new DataSet();
                sda.Fill(ds, "to_sql");
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "id";
                dataGridView1.Columns[1].HeaderText = "记录";
                dataGridView1.Columns[2].HeaderText = "时间";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show(e.Message.ToString());
            }
            finally
            {
                conn.Close();
            }

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}