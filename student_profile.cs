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
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApplication2
{
    public partial class student_profile : Form
    {
        string ordb = "Data Source=orcl;User Id=scott;Password=scott;";
        OracleConnection conn;
        public student_profile()
        {
            InitializeComponent();
        }
        private void student_profile_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select student_grade from student_information where student_team_id  =:ID";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("ID", textBox1.Text.ToString());
            OracleDataReader dr = c.ExecuteReader();
            /*if (dr.Read())
            {
                text = textBox1.Text;
                login = textBox1.Text;
                pass = textBox2.Text;
            }*/
        }


    }
}
