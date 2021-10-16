using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace Engleza
{
    public partial class FrmLog : Form
    {
        public FrmLog(FrmMain fMain)
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }
        string cale = Path.GetDirectoryName(Application.ExecutablePath); //numele folderului in care se afla aplicatia

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSlogan_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Trim() == "" || txtparola.Text.Trim() == "")
            {
                lblStare.Text = "Informatii incomplete";
                return;
            }
                int flag = 0;


            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\soft.accdb");//se creeaza o noua conexiune
            con.Open();
            string text = "select* from utilizatori where utilizator =@utilizator";
            OleDbCommand com = new OleDbCommand(text, con);
            com.Parameters.AddWithValue("utilizator", txtname.Text);
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                flag = -1;
                if ( r["parola"].ToString() == txtparola.Text)
                {
                    lblStare.Text="Bine ai venit " + r["utilizator"];
                    flag = 1;
                    variabile.utilizator = txtname.Text;
                   // this.Close();
                }
            }
            r.Close();
            if(flag==-1)
            {
                frmMessageboxOk fMesaj = new frmMessageboxOk("Utilizator sau parola incorecta!");
                fMesaj.ShowDialog();
            }
            if (flag == 0)
            {
                frmMessageBoxYesNo fMesaj = new frmMessageBoxYesNo("Utilizator inexistent.Creati utilizator?");

                if (fMesaj.ShowDialog() == DialogResult.Yes)
                {
                    com.CommandText = "INSERT INTO utilizatori(utilizator,parola) values(@utilizator,@parola)";
                    com.Parameters.AddWithValue("utilizator", txtname.Text);
                    com.Parameters.AddWithValue("parola", txtparola.Text);
                    com.ExecuteNonQuery();
                    lblStare.Text = "Utilizatorul a fost creat!";
                    variabile.utilizator = txtname.Text;
                    flag = 1;


                }
            }
                if (flag == 1)
                {
                frmMessageboxOk fMesaj = new frmMessageboxOk("Welcome "+variabile.utilizator+"!");
                fMesaj.ShowDialog();
                this.Close();
               // lblStare.Text="Welcome "+ variabile.utilizator;
                  //  timer1.Enabled = true;
                //  (this.MdiParent as FrmMain).lblutilizator.Text = variabile.utilizator;
            }
            
        }
        
        private void FrmLog_Load(object sender, EventArgs e)
        {
            lblStare.Text = "User: " + variabile.utilizator;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
