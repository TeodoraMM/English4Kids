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
    public partial class FrmYard : Form
    {
        public FrmYard(FrmMain fMain)
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }
        string[] A = { "pool"  , "tret" ,"ring-shaped life-buoy","boi","gow","desk","fere","flower", "umbrella", "trash","chair" };
        string[] B = { "pol", "tre", "ring", "boy","dog","chair","firre", "flower pot","umbrela","trash can","chezlong" };
        string[] C = { "poll" , "tree","ring life","girl","cat", "lounge chair","fire","plant","rella","bin","long" };
        string[] corect = { "A" ,"C","A","B","B","C","C","B","A","A","A"};
        void afis(int i)
        {
            rbA.Text = A[i];
            rbB.Text = B[i];
            rbC.Text = C[i];
            btver.Tag = corect[i];
            lblrezultat.Text = "  ";
            penIntrebare.Visible = true;
            rbB.Checked = false;
            rbC.Checked = false;
            rbA.Checked = false;
            pbCorect.Visible = false;
            pbIncorect.Visible = false;
            btver.Enabled = true;
        }
        private void FrmYard_Load(object sender, EventArgs e)
        {
            lblBest.Text = variabile.utilizator + "' best score: " + score.ShowBestScore("Home-Yard");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelInstructiuni.Visible = true;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            panelInstructiuni.Visible = false;
        }

        private void lblExit_Click_1(object sender, EventArgs e)
        {
            panelInstructiuni.Visible = false;
        }

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void lblrezultat_Click(object sender, EventArgs e)
        {

        }
        int scor = 0;
        private void btver_Click(object sender, EventArgs e)
        {
          if (rbA.Checked && btver.Tag.ToString() == "A" || rbB.Checked && btver.Tag.ToString() == "B" || rbC.Checked && btver.Tag.ToString() == "C")
            {
                pbCorect.Visible = true;
                pbIncorect.Visible = false;
                variabile.punctaj++;
                scor++;
                lblrezultat.Text = "Your score :" + variabile.punctaj;
                if (score.SetBestScore("Home-Yard", scor) == 1)
                {
                    lblBest.Text = variabile.utilizator + "' best score: " + score.ShowBestScore("Home-Yard");
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

        private void lblxvar_Click(object sender, EventArgs e)
        {
            penIntrebare.Visible = false;
        }
        

        private void penIntrebare_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbPiscina_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
            //rbrbPiscina.Enabled = false;
        }

        private void rbPiscina1_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
            rbPiscina1.Enabled = false;
        }

        private void rbCopac_CheckedChanged(object sender, EventArgs e)
        {
            afis(1);
            rbCopac.Enabled = false;
        }

        private void rbColac_CheckedChanged(object sender, EventArgs e)
        {
            afis(2);
            rbColac.Enabled = false;
        }

        private void rbColac1_CheckedChanged(object sender, EventArgs e)
        {
            afis(2);
            rbColac1.Enabled = false;
        }

        private void rbSezlong_CheckedChanged(object sender, EventArgs e)
        {
            afis(3);
            //rbSezlong.Enabled = false;
        }

        private void rbSezlong1_CheckedChanged(object sender, EventArgs e)
        {
            afis(5);
            rbSezlong1.Enabled = false;
        }

        private void rbFoc_CheckedChanged(object sender, EventArgs e)
        {
            afis(6);
            rbFoc.Enabled = false;
        }

        private void rbGhiveci_CheckedChanged(object sender, EventArgs e)
        {
            afis(7);
            rbGhiveci.Enabled = false;
        }

        private void rbBaiat_CheckedChanged(object sender, EventArgs e)
        {
            afis(3);
            rbBaiat.Enabled = false;
        }

        private void rbCaine_CheckedChanged(object sender, EventArgs e)
        {
            afis(4);
            rbCaine.Enabled = false;
        }

        private void rbUmbrela_CheckedChanged(object sender, EventArgs e)
        {
            afis(8);
            rbUmbrela.Enabled = false;
        }

        private void rbGunoi_CheckedChanged(object sender, EventArgs e)
        {
            afis(9);
            rbGunoi.Enabled = false;
        }

        private void rbScaun_CheckedChanged(object sender, EventArgs e)
        {
            afis(10);
            rbScaun.Enabled = false;
        }

        private void rbScaun1_CheckedChanged(object sender, EventArgs e)
        {
            afis(11);
            rbScaun1.Enabled = false;
        }

        private void LblIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
