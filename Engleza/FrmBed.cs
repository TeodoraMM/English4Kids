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
    public partial class FrmBed : Form
    {
        public FrmBed(FrmMain fMain)
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }
        string[] A = { "tableu", "jewelry box","wood", "wallpaper","bed","chan" ,"vase","chair","chair", "television","mass","sun","perdals" };
        string[] B = { "picture","boxx","bedstand","paper","bad", "chandelier", "lamp","papers","chesee","playstation","tableu","cowor", "curtains" };
        string[] C = {  "imagine","wood", "nightstand","flower","deb","lier","vasse","books","cheese","wall","table","carpet","pedals" };
        string[] corect = { "B","A","C","A","A","B","B","C","A","A","C","C","B", };
        void afis(int i)
        {
            rbA.Text = A[i];
            rbB.Text = B[i];
            rbC.Text = C[i];
            btver.Tag = corect[i];
            lblrezultat.Text = "  ";
            rbB.Checked = false;
            rbC.Checked = false;
            rbA.Checked = false;
            pbCorect.Visible = false;
            pbIncorect.Visible = false;
            penIntrebare.Visible = true;
            btver.Enabled = true;
        }
        private void FrmBed_Load(object sender, EventArgs e)
        {
            lblBest.Text = variabile.utilizator + "' best score: " + score.ShowBestScore("Home-Parents Bedroom");
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

        private void lblxvar_Click(object sender, EventArgs e)
        {
            penIntrebare.Visible = false;
        }
        int scor = 0;

        private void btver_Click_1(object sender, EventArgs e)
        {
            if (rbA.Checked && btver.Tag.ToString() == "A" || rbB.Checked && btver.Tag.ToString() == "B" || rbC.Checked && btver.Tag.ToString() == "C")
            {
                pbCorect.Visible = true;
                pbIncorect.Visible = false;
                variabile.punctaj++;
                scor++;
                lblrezultat.Text = "Your score :" + variabile.punctaj ;
                if (score.SetBestScore("Home-Parents Bedroom", scor) == 1)
                {
                    lblBest.Text = variabile.utilizator + "' best score: " + score.ShowBestScore("Home-Parents Bedroom");
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

        private void penIntrebare_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbTablou_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
            rbTablou.Enabled = false;
        }

        private void afisCutie_CheckedChanged(object sender, EventArgs e)
        {
            afis(1);
            afisCutie.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            afis(2);
            radioButton1.Enabled = false;
        }

        private void rbTapet_CheckedChanged(object sender, EventArgs e)
        {
            afis(3);
            rbTapet.Enabled = false;
        }

        private void rbPat_CheckedChanged(object sender, EventArgs e)
        {
            afis(4);
            rbPat.Enabled = false;
        }

        private void rbCandelabru_CheckedChanged(object sender, EventArgs e)
        {
            afis(5);
            rbCandelabru.Enabled = false;
        }

        private void rbCandelabru1_CheckedChanged(object sender, EventArgs e)
        {
            afis(5);
            rbCandelabru1.Enabled = false;
        }

        private void rbLampa_CheckedChanged(object sender, EventArgs e)
        {
            afis(6);
            rbLampa.Enabled = false;
        }

        private void rbScaun_CheckedChanged(object sender, EventArgs e)
        {
            afis(8);
            rbScaun.Enabled = false;
        }

        private void rbCarti_CheckedChanged(object sender, EventArgs e)
        {
            afis(7);
            rbCarti.Enabled = false;
        }

        private void rbMasa_CheckedChanged(object sender, EventArgs e)
        {
            afis(10);
            rbMasa.Enabled = false;
        }

        private void rbTelevizor_CheckedChanged(object sender, EventArgs e)
        {
            afis(9);
            rbTelevizor.Enabled = false;
        }

        private void rbCovor_CheckedChanged(object sender, EventArgs e)
        {
            afis(11);
            rbCovor.Enabled = false;
        }

        private void rbPerdele_CheckedChanged(object sender, EventArgs e)
        {
            afis(12);
            rbPerdele.Enabled = false;
        }

        private void LblIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            penIntrebare.Visible = false;
        }
    }
}
