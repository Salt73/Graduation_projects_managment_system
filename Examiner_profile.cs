using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
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
    public partial class Examiner_profile : Form
    {
        string ordb = "Data Source=orcl;User Id=scott;Password=scott;";
        OracleConnection conn;
        public Examiner_profile()
        {
            InitializeComponent();
        }

        private void Examiner_profile_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Grade Grd = new Grade();
            Grd.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Submit_Grades Sgrade =new Submit_Grades();
            Sgrade.Show();
            Visible=false;
        }
    }
}
