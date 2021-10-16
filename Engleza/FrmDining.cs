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
    public partial class FrmDining : Form
    {
        public FrmDining(FrmMain fMain)
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }
        string[] A = {"plant","lamp","fenetre","piture","mass","chair","books","vas"};
        string[] B = { "flower", "chandelier", "window", "tablo", "tabe", "chese", "rews", "cup" };
        string[] C = {"vase","table","light","picture","table","cair", "magazines","sun" };
        string[] corect = {"A","B","B","C","A","C","B"};
        void afis(int i)
        {
            rbA.Text = A[i];
            rbB.Text = B[i];
            rbC.Text = C[i];
            rbB.Checked = false;
            rbC.Checked = false;
            rbA.Checked = false;
            pbCorect.Visible = false;
            pbIncorect.Visible = false;
            btnVerifica.Tag = corect[i];
            lblRezultat.Text = " ";
            pnlMASA.Visible = true;
            btnVerifica.Enabled = true;
        }
        private void FrmDining_Load(object sender, EventArgs e)
        {
            lblBest.Text = variabile.utilizator + "' best score: " + score.ShowBestScore("Home-Dinning Room");
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

        private void pbStatuie_Click(object sender, EventArgs e)
        {
            afis(0);
        }
        int scor = 0;
        private void btnVerifica_Click(object sender, EventArgs e)
        {
            if (rbA.Checked && btnVerifica.Tag.ToString() == "A" || rbB.Checked && btnVerifica.Tag.ToString() == "B" || rbC.Checked && btnVerifica.Tag.ToString() == "C")
            {
                pbCorect.Visible = true;
                pbIncorect.Visible = false;
                variabile.punctaj++;
                scor++;
                lblRezultat.Text = "Your score :" + variabile.punctaj;
                if (score.SetBestScore("Home-Dinning Room", scor) == 1)
                {
                    lblBest.Text = variabile.utilizator + "' best score: " + score.ShowBestScore("Home-Dinning Room");
                }
            }
            else
            {
                pbIncorect.Visible = true;
                pbCorect.Visible = false;
                variabile.punctaj--;
                scor--;
                lblRezultat.Text = "Your score :";

            }
            btnVerifica.Enabled = false;
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            pnlMASA.Visible = false;
        }


        private void rbPLanta_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
            rbPLanta.Enabled = false;
        }

        private void rbCandelabru_CheckedChanged(object sender, EventArgs e)
        {
            afis(1);
            rbCandelabru.Enabled = false;
        }

        private void rbGeam_CheckedChanged(object sender, EventArgs e)
        {
            afis(2);
            rbGeam.Enabled = false;
        }

        private void rbTablou_CheckedChanged(object sender, EventArgs e)
        {
            afis(3);
            rbTablou.Enabled = false;
        }

        private void rbTablou1_CheckedChanged(object sender, EventArgs e)
        {
            afis(3);
            rbTablou1.Enabled = false;
        }

        private void rbTablou2_CheckedChanged(object sender, EventArgs e)
        {
            afis(3);
            rbTablou2.Enabled = false;
        }

        private void rbMasa_CheckedChanged(object sender, EventArgs e)
        {
            afis(4);
            rbMasa.Enabled = false;
        }

        private void rbScaun_CheckedChanged(object sender, EventArgs e)
        {
            afis(5);
            rbScaun.Enabled = false;
        }

        private void rbScaun1_CheckedChanged(object sender, EventArgs e)
        {
            afis(5);
            rbScaun1.Enabled = false;
        }

        private void rbScaun2_CheckedChanged(object sender, EventArgs e)
        {
            afis(5);
            rbScaun2.Enabled = false;
        }

        private void rbScaun3_CheckedChanged(object sender, EventArgs e)
        {
            afis(5);
            rbScaun3.Enabled = false;
        }

        private void rbReviste_CheckedChanged(object sender, EventArgs e)
        {
            afis(6);
            rbReviste.Enabled = false;
        }

        private void rbCesti_CheckedChanged(object sender, EventArgs e)
        {
            afis(7);
            rbCesti.Enabled = false;

        }

        private void pnlMASA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbVasa_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
            rbVasa.Enabled = false;
        }

        private void rbCandelabruu_CheckedChanged(object sender, EventArgs e)
        {
            afis(1);
            rbCandelabruu.Enabled = false;
        }
    }
}
