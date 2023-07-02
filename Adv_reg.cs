using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;


namespace WindowsFormsApplication2
{

    public partial class Stu_reg : Form
    {



        string ordb = "Data Source=orcl;User Id=scott;Password=scott;";
        OracleConnection conn;

        public Stu_reg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "insert into Customer values(:email,:name,:password)";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("email", textBox1.Text);
            c.Parameters.Add("name", textBox3.Text);
            c.Parameters.Add("pass", textBox2.Text);
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Your account is ready");
                Student stu = new Student();
                stu.Show();
                Visible = false;
            }
        }

        private void Stu_reg_Load(object sender, EventArgs e)
        {
            
            conn = new OracleConnection(ordb);
            conn.Open();
        }
    }
}
