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
using Oracle.DataAccess.Types;


namespace WindowsFormsApplication2
{
    public partial class Grade : Form
    {
        string ordb = "Data Source=orcl;User Id=scott;Password=scott;";
        OracleConnection conn;
        public Grade()
        {
            InitializeComponent();
        }
        private void Grade_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select student_grade from student_information where student_team_id  =:ID and student_project =:Name";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("ID", textBox3.Text.ToString());
            c.Parameters.Add("Name", textBox2.Text.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                textBox5.Text = dr[0].ToString();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
