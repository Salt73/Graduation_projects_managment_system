﻿using System;
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
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Advisor adv = new Advisor();
            adv.Show();
            Visible = false;
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            Examiner Exam = new Examiner();
            Exam.Show();
            Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            TAssistant ta = new TAssistant();
            ta.Show();
            Visible = false;
         
        }
        }
    }

