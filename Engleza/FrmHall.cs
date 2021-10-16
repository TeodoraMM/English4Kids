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
    public partial class FrmHall : Form
    {
        public FrmHall(FrmMain fMain)
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }
        string[] A = { "stairs" ,"boor","lamp", "vase","pern", "chandelier" };
        string[] B = { "scairs","door","plan","vaz","bed","lamp"};
        string[] C = {"scan","USA","plant","plant","sofa","light" };
        string[] corect = {"A","B","C","A","C","A"};
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
        private void FrmHall_Load(object sender, EventArgs e)
        {
            lblBest.Text = variabile.utilizator + "' best score: " + score.ShowBestScore("Home-Hall");
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
                if (score.SetBestScore("Home-Hall", scor) == 1)
                {
                    lblBest.Text = variabile.utilizator + "' best score: " + score.ShowBestScore("Home-Hall");
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


        private void rbUsa_CheckedChanged(object sender, EventArgs e)
        {
            afis(1);
            rbUsa.Enabled = false;
        }

        private void rbUsa2_CheckedChanged(object sender, EventArgs e)
        {
            afis(1);
            rbUsa2.Enabled = false;
        }

        private void rbScari_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
            rbScari.Enabled = false;
        }

        private void rbPlanta_CheckedChanged(object sender, EventArgs e)
        {
            afis(2);
            rbPlanta.Enabled = false;
        }

        private void rbVaza_CheckedChanged(object sender, EventArgs e)
        {
            afis(3);
            rbVaza.Enabled = false;
        }

        private void rbPat_CheckedChanged(object sender, EventArgs e)
        {
            afis(4);
            rbPat.Enabled = false;
        }
        

        private void LblIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pnlMASA.Visible = false;
        }

        private void rbCandelabru_CheckedChanged(object sender, EventArgs e)
        {
            afis(5);
            rbCandelabru.Enabled = false;
        }
    }
}
