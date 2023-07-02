﻿using System;
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



        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
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
            c.CommandText = "insert into student_information values(:student_id,:student_team_id,:student_email,:student_name,:student_password,:student_project,:student_meeting,:student_grade)";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("student_id", textBox1.Text);
            c.Parameters.Add("student_team_id", textBox3.Text);
            c.Parameters.Add("student_email", textBox2.Text);
            c.Parameters.Add("student_name", textBox4.Text);
            c.Parameters.Add("student_password", textBox5.Text);
            c.Parameters.Add("student_project", textBox6.Text);
            c.Parameters.Add("student_meeting", textBox7.Text);
            c.Parameters.Add("student_grade", textBox8.Text);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
