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
    public partial class Student : Form
    {
        public static string text = "";
        public static string pass = "";
        public static string login = "";
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public Student()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            welcome wel = new welcome();
            wel.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from student_information where student_email =:email and student_password =:pass";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("email", textBox1.Text);
            c.Parameters.Add("pass", textBox2.Text);
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                text = textBox1.Text;
                login = textBox1.Text;
                pass = textBox2.Text;
            }
            Grade Grd = new Grade();
            Grd.Show();
            Visible = false;
        }
    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Stu_reg sreg = new Stu_reg ();
           sreg.Show();
           Visible = false;
        }
}
}
