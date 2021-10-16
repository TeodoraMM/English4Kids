using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Engleza
{
    public partial class Ilustratfrm : Form
    {
        string cale = Path.GetDirectoryName(Application.ExecutablePath);// + "\\";
        public Ilustratfrm(FrmMain fMain)
        {

            this.MdiParent = fMain;
            InitializeComponent();
        }


        private void Ilustratfrm_Load(object sender, EventArgs e)
        {
            txtRo.Enabled = false;
            txtFr.Enabled = false;
            cboPv.Enabled = false;
          
            String cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + Path.GetDirectoryName(Application.ExecutablePath) + "\\cuvinte.mdb";


            string qs = "select distinct categorie from cuvinte order by categorie";
            OleDbConnection con = new OleDbConnection(cs);

            OleDbCommand com = new OleDbCommand(qs, con);
            con.Open();
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                cbAlege.Items.Add(r["Categorie"].ToString());
            }

        }

        private void cbAlege_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRo.Text = "";
            txtFr.Text = "";

            cboPv.Text = "";
            picM.Image = null;
            lstCod.Items.Clear();
            lstCuvinte.Items.Clear();

            String cs = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.GetDirectoryName(Application.ExecutablePath) + "\\cuvinte.mdb";


            string qs = "select * from cuvinte where categorie like '" + cbAlege.Text + "%' order by romana";
            OleDbConnection con = new OleDbConnection(cs);

            OleDbCommand com = new OleDbCommand(qs, con);
            con.Open();
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                lstCuvinte.Items.Add(r["romana"].ToString());
                lstCod.Items.Add(r["id"].ToString());
            }

            r.Close();
            con.Close();
        }

        private void lstCuvinte_SelectedIndexChanged(object sender, EventArgs e)
        {
            int p = lstCuvinte.SelectedIndex;
            if (p < 0) return;
            String cs = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.GetDirectoryName(Application.ExecutablePath) + "\\cuvinte.mdb";


            string qs = "select * from cuvinte where id=" + lstCod.Items[p].ToString();
            OleDbConnection con = new OleDbConnection(cs);

            OleDbCommand com = new OleDbCommand(qs, con);
            con.Open();
            OleDbDataReader r = com.ExecuteReader();
            if (r.Read())
            {
                txtRo.Text = r["romana"].ToString();
                txtFr.Text = r["engleza"].ToString();

                cboPv.Text = r["pvorbire"].ToString();
                if (File.Exists(cale + r["imagine"].ToString()))
                    picM.Image = new Bitmap(cale + r["imagine"].ToString());
                else
                    picM.Image = new Bitmap(cale + "\\imagini\\noimage.jpg");
                
                
            }

            r.Close();
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ilustratfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        private void refa_categorii()
        {
            cbAlege.Items.Clear();
           
            String cs = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.GetDirectoryName(Application.ExecutablePath) + "\\cuvinte.mdb";


            string qs = "select distinct categorie from cuvinte order by categorie";
            OleDbConnection con = new OleDbConnection(cs);
            OleDbCommand com = new OleDbCommand(qs, con);
            con.Open();
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                cbAlege.Items.Add(r["Categorie"].ToString());
              


            }

            r.Close();
            con.Close();

        }

        private void pbFr_Click(object sender, EventArgs e)
        {
            lblCategorie.Text = "Categorie:";
            label9.Text = "Word(RO):";
            label8.Text = "Word(EN):";
            label6.Text = "Part of speech: ";
            lblImag.Text = "Image";
        }

        private void txtRo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pbRo_Click(object sender, EventArgs e)
        {
            lblCategorie.Text = "Categorie:";
            label9.Text = "Cuvânt(RO):";
            label8.Text = "Cuvânt(EN):";
            label6.Text = "Parte de vorbire:";
            lblImag.Text = "Imagine";
        }

        private void picM_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }
    }
}
