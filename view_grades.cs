using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

//using Oracle.ManagedDataAccess.Types;
//using Oracle.ManagedDataAccess.Client;
using System.Data.OracleClient;

namespace disconeccted_mode27
{
    public partial class view_grades : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public view_grades()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source = orcl; User Id=  scott; Password = tiger;";
            String cmdstr = @"select student_grade  
                              from student_information 
                              where student_id = :n ";
            OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("n", textBox1.Text);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
