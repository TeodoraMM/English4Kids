using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engleza
{
    public partial class FrmBath : Form
    {
        public FrmBath(FrmMain fMain)
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }
        string[] A = { "vase","window","sapp","towel","hunt" ,"VC", "miror", "sink", "shoer", "towle","laundry basket","hunt","USA"};
        string[] B = { "vass","fenetre","soap","proop","kunt" , "WC", "mirro", "sinck", "shower", "towell","clouths bascket","siink","door" };
        string[] C = { "vaze","vindow","soapun","tovel","huntk","WK" , "mirror","sank", "showre", "towel","bascket","hunts","us"};
        string[] corect = { "A","A","B","A","A","B" ,"C", "A", "B", "C","A","A","B"};
        void afis(int i)
        {
            rbA.Text = A[i];
            rbB.Text = B[i];
            rbC.Text = C[i];
            btver.Tag = corect[i];
            rbB.Checked = false;
            rbC.Checked = false;
            rbA.Checked = false;
            pbCorect.Visible = false;
            pbIncorect.Visible = false;
            lblrezultat.Text = "  ";
            penIntrebare.Visible = true;
            btver.Enabled = true;
        }
        int scor = 0;

        private void FrmBath_Load(object sender, EventArgs e)
        {
            lblBest.Text = variabile.utilizator + "' best score: " + score.ShowBestScore("Home-Bathroom");
        }

        private void lblxvar_Click(object sender, EventArgs e)
        {
            penIntrebare.Visible = false;
        }
        

        private void btver_Click_1(object sender, EventArgs e)
        {

            if (rbA.Checked && btver.Tag.ToString() == "A" || rbB.Checked && btver.Tag.ToString() == "B" || rbC.Checked && btver.Tag.ToString() == "C")
            {
                pbCorect.Visible = true;
                pbIncorect.Visible = false;
                variabile.punctaj++;
                scor++;
                lblrezultat.Text = "Your score :" + variabile.punctaj;
                if (score.SetBestScore("Home-Bathroom", scor) == 1)
                {
                    lblBest.Text = variabile.utilizator + "' best score: " + score.ShowBestScore("Home-Bathroom");
                }
            }
            else
            {
                pbCorect.Visible = false;
                pbIncorect.Visible = true;
                variabile.punctaj--;
                scor--;
                lblrezultat.Text = "Your score :";

            }
            btver.Enabled = false;

        }

        private void rbVaza_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
            rbVaza.Enabled = false;
        }

        private void rbFereastra_CheckedChanged(object sender, EventArgs e)
        {
            afis(1);
            rbFereastra.Enabled = false;
        }

        private void rbOglinda_CheckedChanged(object sender, EventArgs e)
        {
            afis(6);
            rbOglinda.Enabled = false;
        }

        private void rbSapun_CheckedChanged(object sender, EventArgs e)
        {
            afis(2);
            rbSapun.Enabled = false;
        }

        private void rbWC_CheckedChanged(object sender, EventArgs e)
        {
            afis(5);
            rbWC.Enabled = false;
        }

        private void rbProsop1_CheckedChanged(object sender, EventArgs e)
        {
            afis(3);
            rbProsop1.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            afis(3);
            radioButton1.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            afis(10);
            //radioButton2.Enabled = false;
        }

        private void rbVana_CheckedChanged(object sender, EventArgs e)
        {
            afis(11);
            rbVana.Enabled = false;
        }

        private void rbDus_CheckedChanged(object sender, EventArgs e)
        {
            afis(8);
            rbDus.Enabled = false;
        }

        private void rbChiuveta_CheckedChanged(object sender, EventArgs e)
        {
            afis(7);
            rbChiuveta.Enabled = false;
        }

        private void rbUsa_CheckedChanged(object sender, EventArgs e)
        {
            afis(12);
            rbUsa.Enabled = false;
        }

        private void penIntrebare_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelInstructiuni_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            panelInstructiuni.Visible = false;
        }

        private void lblIEngleza_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelInstructiuni.Visible = true;
        }

        private void LblIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblIRomana_Click(object sender, EventArgs e)
        {

        }
    }
    
}
