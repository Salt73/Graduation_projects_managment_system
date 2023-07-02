using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Submit_Grades : Form
    {
        string ordb = "Data Source=orcl;User Id=scott;Password=scott;";
        OracleConnection conn;
        public Submit_Grades()
        {
            InitializeComponent();
        }

        private void Submit_Grades_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "insert into examiner_informtation values (:ID,:email,:name,:pass,:grade";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("ID", textBox2.Text);
            c.Parameters.Add("email", textBox1.Text);
            c.Parameters.Add("name", textBox3.Text);
            c.Parameters.Add("pass", textBox4.Text);
            c.Parameters.Add("grade", textBox5.Text);
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Grades submitted");
            }
        }
    }
}
