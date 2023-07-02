using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using Oracle.DataAccess.Client;
//using Oracle.DataAccess.Types;
using System.Data.OracleClient;

namespace disconeccted_mode27
{

    public partial class manage_grades : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;

        public manage_grades()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source = orcl; User Id=  scott; Password = tiger;";
            String cmdstr = @"select grade 
                              from examiner_informtation 
                              where examiner_id = :n ";
            OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("n", textBox1.Text);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            int v = adapter.Update(ds.Tables[0]);
        }
    }
}
