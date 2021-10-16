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
    public partial class frmDesen : Form
    {
        public frmDesen(FrmMain fMain)
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }
        string[] A = { "maro", "purple", "albastrwe", "green", "yellow", "power", "roser", "pig", "grey" };
        string[] B = { "brown", "mow", "bleu", "gren", "yelov", "orange ", "red", "punk", "white" };
        string[] C = { "black", "puple", "blue", "grin", "ielow", "portowell", "reed", "pink", "black" };
        string[] corect = { "B", "A", "C", "A", "A", "B", "B", "C", "C" };
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
            btver.Tag = corect[i];
            lblrezultat.Text = " ";
            pnlIntrebare.Visible = true;
        }

        private void LblIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDesen_Load(object sender, EventArgs e)
        {
            lblBest.Text = variabile.utilizator + "' best score: " + score.ShowBestScore("Let's learn about colors !");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelInstructiuni.Visible = true;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            panelInstructiuni.Visible = false;
        }

        private void rbGeam_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
        }
        int scor = 0;
        private void btnVerifica_Click_1(object sender, EventArgs e)
        {
            if (rbA.Checked && btver.Tag.ToString() == "A" || rbB.Checked && btver.Tag.ToString() == "B" || rbC.Checked && btver.Tag.ToString() == "C")
            {
                pbCorect.Visible = true;
                pbIncorect.Visible = false;
                variabile.punctaj++;
                scor++;
                lblrezultat.Text = "Your score :" + variabile.punctaj;
                if (score.SetBestScore("Let's learn about colors !", scor) == 1)
                {
                    lblBest.Text = variabile.utilizator + "' best score: " + score.ShowBestScore("Let's learn about colors !");
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
        }

        private void rbMov_CheckedChanged(object sender, EventArgs e)
        {
            afis(1);
        }

        private void rbAlbastru_CheckedChanged(object sender, EventArgs e)
        {
            afis(2);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            afis(3);
        }

        private void rbGalben_CheckedChanged(object sender, EventArgs e)
        {
            afis(4);
        }

        private void rbPortocaliu_CheckedChanged(object sender, EventArgs e)
        {
            afis(5);
        }

        private void rbRoz_CheckedChanged(object sender, EventArgs e)
        {
            afis(6);
        }

        private void rbRosu_CheckedChanged(object sender, EventArgs e)
        {
            afis(7);
        }

        private void rbNegru_CheckedChanged(object sender, EventArgs e)
        {
            afis(8);
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            pnlIntrebare. Visible = false;
        }

        private void rbVerde2_CheckedChanged(object sender, EventArgs e)
        {
            afis(3);
        }

        private void rbAlnbstru2_CheckedChanged(object sender, EventArgs e)
        {
            afis(2);
        }

        private void pnlIntrebare_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBest_Click(object sender, EventArgs e)
        {

        }
    } 
}
