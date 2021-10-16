using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Engleza
{
    public partial class FrmAjutor : Form
    {
        string numeF = " ";
        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        public FrmAjutor(FrmMain fMain)
           
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }

        private void Ajutorfrm_Load(object sender, EventArgs e)
        {
            
            String qs = "Select distinct intrebari from help ";
            string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; ; Data Source =" + Path.GetDirectoryName(Application.ExecutablePath) + "\\cuvinte.mdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand com = new OleDbCommand(qs, connection);
                connection.Open();
                OleDbDataReader r = com.ExecuteReader();
                while (r.Read())
                    cboIntrebare.Items.Add(r["intrebari"]);
                //lblRaspuns.Text=(r["intrebari"].ToString());
                r.Close();
                connection.Close();
                if(cboIntrebare.Items.Count>0)

                cboIntrebare.SelectedIndex = 0;
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            String cs = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.GetDirectoryName(Application.ExecutablePath) + "\\cuvinte.mdb";
            String qs = "Select distinct intrebari from help ";

            
            OleDbConnection con = new OleDbConnection(cs);

            OleDbCommand com = new OleDbCommand(qs, con);
            con.Open();
            OleDbDataReader r = com.ExecuteReader();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            String qs = "select Raspunsuri from Help where Intrebari = '" + cboIntrebare.Text + "'";
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;;Data Source =" + cale + "\\cuvinte.mdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand com = new OleDbCommand(qs, connection);
                connection.Open();
                OleDbDataReader r = com.ExecuteReader();
                while (r.Read())
                    lblRaspuns.Text = (r["Raspunsuri"].ToString());
                r.Close();
                connection.Close();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ajutorfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmMain)(this.MdiParent)).aj = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblRaspuns_Click(object sender, EventArgs e)
        {

        }
    }
}
