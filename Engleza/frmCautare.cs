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
    public partial class frmCautare : Form
    {
        string numeF = "";

        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        public frmCautare(FrmMain fMain)
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void frmCautare_Load(object sender, EventArgs e)
        {
            lstCod.Visible = false;
           
            //this.Size=new Size(879, 499);
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCaut_TextChanged(object sender, EventArgs e)
        {
                string qs;
                lblRo.Text = "";
                lblFr.Text="";

                picM.Image = null;
                lstCod.Items.Clear();
                lstCuvinte.Items.Clear();

                String cs = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=" + cale + "\\cuvinte.mdb";

                if (rbRo.Checked)
                    qs= "select id,romana, engleza from cuvinte where romana like '" + txtCaut.Text + "%' order by romana";
                else
                    qs="select id,engleza,romana  from cuvinte where engleza like '" + txtCaut.Text + "%' order by engleza";
                OleDbConnection con = new OleDbConnection(cs);

                OleDbCommand com = new OleDbCommand(qs, con);
                con.Open();
                OleDbDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    lstCuvinte.Items.Add(r[1].ToString());
                    lstCod.Items.Add(r[0].ToString());
                }

               
                
            
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
                lblRo.Text = r["romana"].ToString();
                lblFr.Text = r["engleza"].ToString();
               
                if (File.Exists(cale+r["imagine"].ToString()))
                    picM.Image = new Bitmap(cale+r["imagine"].ToString());
                else
                    picM.Image = new Bitmap(cale + "\\imagini\\noimage.jpg");
                numeF = r["imagine"].ToString();
            }

            r.Close();
            con.Close();
        }

        private void rbRo_CheckedChanged(object sender, EventArgs e)
        {
            txtCaut.Clear();
            lstCuvinte.Items.Clear();
            lstCod.Items.Clear();
         
       }

        private void r1_Click(object sender, EventArgs e)
        {
            txtCaut.SelectedText = r1.Text;
        }

        private void r2_Click(object sender, EventArgs e)
        {
            txtCaut.SelectedText = r2.Text;
        }

        private void r3_Click(object sender, EventArgs e)
        {
            txtCaut.SelectedText = r3.Text;
        }

        private void r4_Click(object sender, EventArgs e)
        {
            txtCaut.SelectedText = r4.Text;
        }

        private void r5_Click(object sender, EventArgs e)
        {
            txtCaut.SelectedText = r5.Text;
        }

        private void f1_Click(object sender, EventArgs e)
        {
            txtCaut.SelectedText = f1.Text;
        }

        private void f2_Click(object sender, EventArgs e)
        {
            txtCaut.SelectedText = f2.Text;
        }

        private void f3_Click(object sender, EventArgs e)
        {
            txtCaut.SelectedText = f3.Text;
        }

        private void f4_Click(object sender, EventArgs e)
        {
            txtCaut.SelectedText = f4.Text;
        }

        private void f5_Click(object sender, EventArgs e)
        {
            txtCaut.SelectedText = f5.Text;
        }

        private void f1_Click_1(object sender, EventArgs e)
        {
            txtCaut.SelectedText = f1.Text;
           
        }

        private void f2_Click_1(object sender, EventArgs e)
        {
            txtCaut.SelectedText = f2.Text;
       
        }

        private void f5_Click_1(object sender, EventArgs e)
        {
            txtCaut.SelectedText = f5.Text;
          
        }

        private void f4_Click_1(object sender, EventArgs e)
        {
            txtCaut.SelectedText = f4.Text;
           
        }

        private void f3_Click_1(object sender, EventArgs e)
        {
            txtCaut.SelectedText = f3.Text;
          

        }

        private void f6_Click(object sender, EventArgs e)
        {
            txtCaut.SelectedText = f6.Text;
            
        }

        private void f7_Click(object sender, EventArgs e)
        {
            txtCaut.SelectedText = f7.Text;
            
        }

        private void f8_Click(object sender, EventArgs e)
        {
            txtCaut.SelectedText = f8.Text;
           
        }

        private void f9_Click(object sender, EventArgs e)
        {
            txtCaut.SelectedText = f9.Text;
            
        }

        private void f10_Click(object sender, EventArgs e)
        {
            txtCaut.SelectedText = f10.Text;
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
 
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            this.Close();

        }

        

        private void frmCautare_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmMain)(this.MdiParent)).fcaut = null;
        }

        private void pbFr_Click(object sender, EventArgs e)
        {
            label1.Text = "Search Details:";
            label3.Text = "Word:";
            lblCaracter.Text = "Caractere(RO)";
            lblCaracter2.Text = "Characters(EN)";
            lblRo.Text = "Translation";
            lblFr.Text = "Translation";
            lblImag.Text = "Image";
        }

        private void pbRo_Click(object sender, EventArgs e)
        {
            label1.Text = "Detalii căutare:";
            label3.Text = "Cuvânt:";
            lblCaracter.Text = "Caractere(RO)";
            lblCaracter2.Text = "Characters(EN)";
            lblRo.Text = "Traducere";
            lblFr.Text = "Traducere";
            lblImag.Text = "Imagine";
        }

        private void picM_Click(object sender, EventArgs e)
        {

        }
        
    }
    
}
