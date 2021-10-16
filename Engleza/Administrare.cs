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
    public partial class Administrare : Form
    {
        string numeF = "";
        string cale = Path.GetDirectoryName(Application.ExecutablePath);// + "\\";
        public Administrare(FrmMain fMain)
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            grAd.Visible = true;

            grModifica.Visible = false;
            txtRomana.Text = "";
            txtFranceza.Text = "";
            
            txtGen.Text = "";
            picM.Image = null;
            lstCod.Items.Clear();
            lstCuvinte.Items.Clear();
            txtRo.Enabled = true;
            txtFr.Enabled = true;
            cbCategorieM.Enabled = true;
            cboPv.Enabled = true;

            button1.Text = "Adaugă cuvânt";
            button2.Text = "Şterge";
            button3.Text = "Modifică";
            lblCaracter.Text = "Cuvânt(RO):";
            lblCaracter.Text = "Caractere(RO):";
         
            label10.Text = "Cuvânt (RO):";
            label9.Text = "Cuvânt limba romană:";
            label8.Text = "Cuvânt limba engleză:";
            label7.Text = "Categorie:";
            label6.Text = "Parte de vorbire:";
            btnSterge.Text = "Şterge";
            btnModI.Text = "Imagine";
            btnMod.Text = "Modifică";
            label12.Text = "Cuvinte găsite:";
            label1.Text = "Cuvânt(RO):";
            label2.Text = "Cuvânt(EN):";
            label3.Text = "Categorie:";
            lblPvorbire.Text = "Parte de vorbire:";
            btnIncarca.Text = "Imagine";
            btnRenunta.Text = "Renunţare";
            btnAdauga.Text = "Adăugare";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCaut.Clear();
            grAd.Visible = false;
           
            grModifica.Visible = true;
            btnMod.Visible = false;
            btnSterge.Visible = true;
            btnSterge.Location = btnMod.Location;
            txtRo.Text = "";
            txtFr.Text = "";
           
            cboPv.Text = "";
            picM.Image = null;
            lstCod.Items.Clear();
            lstCuvinte.Items.Clear();
            txtRo.Enabled = false;
            txtFr.Enabled = false;
            cbCategorieM.Enabled = false;
            cboPv.Enabled = false;
            picM.Enabled = false;

        }



        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (txtRomana.Text == "" || txtFranceza.Text == "" || cbCategorie.Text == "" || txtGen.Text == "")
            {
                MessageBox.Show("Exista campuri necompletate", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Directory.Exists(cale + "\\imagini\\" + cbCategorie.Text))
                Directory.CreateDirectory(cale + "\\imagini\\" + cbCategorie.Text);
            if (!File.Exists(cale + "\\imagini\\" + cbCategorie.Text + "\\" + numeF))
                File.Copy(ofd.FileName, cale + "\\imagini\\" + cbCategorie.Text + "\\" + numeF);
            String cs = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=" + Path.GetDirectoryName(Application.ExecutablePath) + "\\cuvinte.mdb";

            OleDbConnection con = new OleDbConnection(cs);
            con.Open();
            String qs = "Insert into cuvinte(Romana,Engleza,Categorie,Imagine,Pvorbire)Values('" + txtRomana.Text + "','" + txtFranceza.Text + "','"+cbCategorie.Text + "','" + ("\\imagini\\" + cbCategorie.Text + "\\" + numeF) + "','" + txtGen.Text + "')";
            OleDbCommand com = new OleDbCommand(qs, con);
            OleDbDataReader r = com.ExecuteReader();

            //if (txtRo.Text == "" || txtFr.Text == "" || cbCategorieM.Text == "" || cboPv.Text == "")
            //    MessageBox.Show("Exista campuri necompletate", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //else
            

                MessageBox.Show("S-a adaugat", "Adaugare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                r.Close();
                con.Close();
            
            txtRomana.Clear();
            txtFranceza.Clear();
            cbCategorie.Text = "";
            txtGen.Text = "";
            pic.Image = null;
            refa_categorii();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grAd_Enter(object sender, EventArgs e)
        {
            label10.Text = "Word(RO):";
            label9.Text = "Word(RO):";
            label8.Text = "Word(EN):";
            label7.Text = "Categorie:";
            label6.Text = "Part of speech:";
            btnSterge.Text = "Delete";
            btnModI.Text = "Image";
            btnMod.Text = "Change";
            label12.Text = "Words found";
        }

        private void lblPvorbire_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnIncarca_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "Imagini";
            ofd.FileName = "";
            ofd.Filter = "Bitmap (*.bmp)|*.bmp|jpeg(*.jpg)|*.jpg|All files (*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.ShowDialog();
            if (ofd.FileName != "")      // if(ofd.ShowDialog()==DialogResult.OK)
            {
                pic.ImageLocation = ofd.FileName; // schimbam imaginea
                numeF =  Path.GetFileName(ofd.FileName);
                
            }
        }

        private void grModifica_Enter(object sender, EventArgs e)
        {

        }

        private void grSt_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtCaut.Clear();
            grAd.Visible = false;
           
            grModifica.Visible = true;
            btnMod.Visible = true;
            btnSterge.Visible = false;
            //  btnSterge.Location = btnMod.Location;
            txtRo.Text = "";
            txtFr.Text = "";
            
            cboPv.Text = "";
            picM.Image = null;
            lstCod.Items.Clear();
            lstCuvinte.Items.Clear();
            txtRo.Enabled = true;
            txtFr.Enabled = true;
            cbCategorieM.Enabled = true;
            cboPv.Enabled = true;
            picM.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            txtRo.Text = "";
            txtFr.Text = "";
          
            cboPv.Text = "";
            picM.Image = null;
            lstCod.Items.Clear();
            lstCuvinte.Items.Clear();

            String cs = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + cale + "\\cuvinte.mdb";


            string qs = "select * from cuvinte where romana like '" + txtCaut.Text + "%' order by romana";
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

        private void button6_Click(object sender, EventArgs e)
        {
            int p = lstCuvinte.SelectedIndex;
            if (p < 0) return;
            if (txtRo.Text == "" || txtFr.Text == "" || cbCategorieM.Text == "" || cboPv.Text == "")
                MessageBox.Show("Exista campuri necompletate", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                


                String cs = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.GetDirectoryName(Application.ExecutablePath) + "\\cuvinte.mdb";
                String fisImag = ofd.FileName; //"imagini\\" + cbCategorieM.Text + "\\" + Path.GetFileName(numeF);





                OleDbConnection con = new OleDbConnection(cs);
                con.Open();
                String qs = "update cuvinte set Romana='" + txtRo.Text + "', Engleza='" + txtFr.Text + "' ,Imagine='" + ("\\imagini\\" + cbCategorie.Text + "\\" + numeF) + "',Pvorbire='" + cboPv.Text + "', categorie='" + cbCategorieM.Text + "' where id=" + lstCod.Items[p].ToString();
                OleDbCommand com = new OleDbCommand(qs, con);
                OleDbDataReader r = com.ExecuteReader();

                r.Close();
                con.Close();
                btnCauta_Click(sender, e);
                lstCuvinte.SelectedIndex = p;
                MessageBox.Show("S-a modificat", "Modificare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                refa_categorii();
                txtCaut.Clear();
            }
        }

        private void btnModI_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "Imagini";
            ofd.FileName = "";
            ofd.Filter = "Bitmap (*.bmp)|*.bmp|jpeg(*.jpg)|*.jpg|All files (*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.ShowDialog();
            if (ofd.FileName != "")      // if(ofd.ShowDialog()==DialogResult.OK)
            {
                picM.ImageLocation = ofd.FileName; // schimbam imaginea
                numeF =  Path.GetFileName(ofd.FileName);
                if (!Directory.Exists(cale + "\\imagini\\" + cbCategorieM.Text))
                    Directory.CreateDirectory(cale + "\\imagini\\" + cbCategorieM.Text);
                if (!File.Exists(cale + "\\imagini\\" + cbCategorie.Text + "\\" + numeF))
                    File.Copy(ofd.FileName, cale + "\\imagini\\" + cbCategorieM.Text/* + "\\" + numeF*/);
                

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
                txtRo.Text= r["romana"].ToString();
                txtFr.Text = r["engleza"].ToString();
                cbCategorieM.Text=r["categorie"].ToString();
                cboPv.Text = r["pvorbire"].ToString();
                if (File.Exists(cale+r["imagine"].ToString()))
                    picM.ImageLocation = cale + r["imagine"].ToString();
                else
                    picM.ImageLocation = cale + "\\imagini\\noimage.jpg";
                numeF = r["imagine"].ToString();
            }

            r.Close();
            con.Close();
        }

        private void picM_Click(object sender, EventArgs e)
        {
            btnModI_Click(sender, e);
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            int p = lstCuvinte.SelectedIndex;
            if (p < 0) return;
            String cs = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.GetDirectoryName(Application.ExecutablePath) + "\\cuvinte.mdb";

            OleDbConnection con = new OleDbConnection(cs);
            con.Open();
            String qs = "delete from cuvinte where id=" + lstCod.Items[p].ToString();
            OleDbCommand com = new OleDbCommand(qs, con);
            OleDbDataReader r = com.ExecuteReader();

            r.Close();
            con.Close();
            btnCauta_Click(sender, e);
            if(p<lstCuvinte.Items.Count)lstCuvinte.SelectedIndex = p;
            else if (p - 1 >= 0) lstCuvinte.SelectedIndex = p-1;
            MessageBox.Show("S-a sters", "Stergere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void refa_categorii()
        {
            cbCategorie.Items.Clear();
            cbCategorieM.Items.Clear();
            cboPv.Items.Clear();
            String cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + Path.GetDirectoryName(Application.ExecutablePath) + "\\cuvinte.mdb";


            string qs = "select distinct categorie from cuvinte order by categorie";
            OleDbConnection con = new OleDbConnection(cs);
            OleDbCommand com = new OleDbCommand(qs, con);
            con.Open();
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                cbCategorie.Items.Add(r["Categorie"].ToString());
                cbCategorieM.Items.Add(r["Categorie"].ToString());



            }

            r.Close();
            con.Close();
            
        }

        private void Administrare_Load(object sender, EventArgs e)
        {


            lstCod.Visible = false;
            this.Size = new Size(945, 530);
            btnCauta.Image = new Bitmap("images\\lupa.png");
            grAd.Location = new Point(390,100);
            grAd.Size = new Size(318, 335);
            grModifica.Location = new Point(390, 100);
            grModifica.Size = new Size(346, 341);
            refa_categorii();
        }

        private void r1_Click(object sender, EventArgs e)
        {
            txtRomana.SelectedText = r1.Text;
            txtRo.SelectedText = r1.Text;
        }

        private void r2_Click(object sender, EventArgs e)
        {
            txtRomana.SelectedText = r2.Text;
            txtRo.SelectedText = r2.Text;
        }


        private void r3_Click(object sender, EventArgs e)
        {
            txtRomana.SelectedText = r3.Text;
            txtRo.SelectedText = r3.Text;
        }

        private void r4_Click(object sender, EventArgs e)
        {
            txtRomana.SelectedText = r4.Text;
            txtRo.SelectedText = r4.Text;

        }

        private void r5_Click(object sender, EventArgs e)
        {
            txtRomana.SelectedText = r5.Text;
            txtRo.SelectedText = r5.Text;
        }

        private void f1_Click(object sender, EventArgs e)
        {
            txtFranceza.SelectedText = f1.Text;
            txtFr.SelectedText = f1.Text;
        }

        private void f2_Click(object sender, EventArgs e)
        {
            txtFranceza.SelectedText = f2.Text;
            txtFr.SelectedText = f2.Text;
        }

        private void f3_Click(object sender, EventArgs e)
        {
            txtFranceza.SelectedText = f3.Text;
            txtFr.SelectedText = f3.Text;
        }

        private void f4_Click(object sender, EventArgs e)
        {
            txtFranceza.SelectedText = f4.Text;
            txtFr.SelectedText = f4.Text;
        }

        private void f5_Click(object sender, EventArgs e)
        {
            txtFranceza.SelectedText = f5.Text;
            txtFr.SelectedText = f5.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("S-a anulat operaţia", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
      

            txtRomana.Clear();
            txtFranceza.Clear();
            cbCategorie.Text = "";
            txtGen.Text = "";
            pic.Image = null;
            refa_categorii();
            return;
        }

        private void f6_Click(object sender, EventArgs e)
        {
            txtFranceza.SelectedText = f6.Text;
            txtFr.SelectedText = f6.Text;
        }

        private void f7_Click(object sender, EventArgs e)
        {
            txtFranceza.SelectedText = f7.Text;
            txtFr.SelectedText = f7.Text;
        }

        private void f8_Click(object sender, EventArgs e)
        {
            txtFranceza.SelectedText = f8.Text;
            txtFr.SelectedText = f8.Text;
        }

        private void f9_Click(object sender, EventArgs e)
        {
            txtFranceza.SelectedText = f9.Text;
            txtFr.SelectedText = f9.Text;
        }

        private void f10_Click(object sender, EventArgs e)
        {
            txtFranceza.SelectedText = f10.Text;
            txtFr.SelectedText = f10.Text;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Administrare_FormClosed(object sender, FormClosedEventArgs e)
        {
           ((FrmMain)(this.MdiParent)).fadm = null;
        }

        private void pbRo_Click(object sender, EventArgs e)
        {
            button1.Text = "Adaugă cuvânt";
            button2.Text = "Şterge";
            button3.Text = "Modifică";
            lblCaracter.Text = "Cuvânt(RO)";
            lblCaracter.Text = "Caractere(RO):";
           
            label10.Text = "Cuvânt (RO)";
            label9.Text = "Cuvânt limba romană:";
            label8.Text = "Cuvânt limba franceză:";
            label7.Text = "Categorie:";
            label6.Text = "Parte de vorbire:";
            btnSterge.Text = "Şterge";
            btnModI.Text = "Imagine";
            btnMod.Text = "Modifică";
            label12.Text = "Cuvinte găsite:";
            label1.Text = "Cuvânt(RO):";
            label2.Text = "Cuvânt(EN):";
            label3.Text = "Categorie:";
            lblPvorbire.Text = "Parte de vorbire:";
            btnIncarca.Text = "Imagine";
            btnRenunta.Text = "Renunţare";
            btnAdauga.Text = "Adăugare";
        }

        private void pbFr_Click(object sender, EventArgs e)
        {
            button1.Text = "Add a word";
            button2.Text = "Delete a word";
            button3.Text = "Change un word";
            lblCaracter.Text ="Word(RO)";
            lblCaracter.Text="Caracteres(RO)";
       
            label10.Text="Word(RO)";
            label9.Text = " Word in Roumain:";
            label8.Text = "Word in English:";
            label7.Text="Categorie:";
            label6.Text= "Part of speech:";
            btnSterge.Text="Delete";
            btnModI.Text="Image";
            btnMod.Text="Change";
            label12.Text = "Words found:";
            label1.Text = "Word(RO):";
            label2.Text = "Word(EN):";
            label3.Text = "Categorie:";
            lblPvorbire.Text = "Part of speech:";
            btnIncarca.Text = "Image";
            btnRenunta.Text="Abandon";
            btnAdauga.Text = "Add";
            
        }

        private void grModifica_Enter_1(object sender, EventArgs e)
        {
            /*label10.Text = "Word(RO):";
            label9.Text = "Word(RO):";
            label8.Text = "Word(EN):";
            label7.Text = "Categorie";
            label6.Text = "part of speech:";
            btnSterge.Text = "Erased";
            btnModI.Text = "Image";
            btnMod.Text = "Change";
            label12.Text = "Word found";*/
        }

        private void txtCaut_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void grdi_Enter(object sender, EventArgs e)
        {

        }

        private void lblCaracter_Click(object sender, EventArgs e)
        {

        }

        private void cbCategorieM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
