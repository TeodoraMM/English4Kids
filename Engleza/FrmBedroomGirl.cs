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
    public partial class FrmBedroomGirl : Form
    {
        public FrmBedroomGirl(FrmMain fMain)
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }
        private void FrmBedroomGirl_Load(object sender, EventArgs e)
        {
            lblBest.Text = variabile.utilizator + "' best score: " + score.ShowBestScore("Home-Girl Bedroom");
        }
        private void label1_Click(object sender, EventArgs e)
        {
            penIntrebare.Visible = false;
        }
        string[] A = { "bed" , "wallpaper","pernnes","bed","time","chair","carpet","stairs","light","banc","banc","books" };
        string[] B = { "bad","paintings", "pillow","furnituure","lamb","chese","sun", "curtains" , "chandelier","table","books","rewiws" };
        string[] C = { "sofa","pillows","pilows", "night stand","lamp","hesee" ,"campet","pedals","lamp", "desk", "box of crayons","panel" };
        string[] corect = { "A","A","B","C","C","A","A","B","B","C","C","A"};
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelInstructiuni.Visible = true;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            panelInstructiuni.Visible = false;
        }

        private void lblxvar_Click(object sender, EventArgs e)
        {
            penIntrebare.Visible = false;
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
                if (score.SetBestScore("Home-Girl Bedroom", scor) == 1)
                {
                    lblBest.Text = variabile.utilizator + "' best score: " + score.ShowBestScore("Home-Girl Bedroom");
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

        private void rbTapet_CheckedChanged(object sender, EventArgs e)
        {
            afis(1);
            rbTapet.Enabled = false;
        }
        private void rbVaza_CheckedChanged(object sender, EventArgs e)
        {
            afis(4);
            rbVaza.Enabled = false;
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

        private void rbCovor_CheckedChanged(object sender, EventArgs e)
        {
            afis(6);
            rbCovor.Enabled = false;
        }

        private void rbPerdele_CheckedChanged(object sender, EventArgs e)
        {
            afis(7);
            rbPerdele.Enabled = false;
        }

        private void rbCandelabru_CheckedChanged(object sender, EventArgs e)
        {
            afis(8);
            rbCandelabru.Enabled = false;
        }

        private void rbBirou_CheckedChanged(object sender, EventArgs e)
        {
            afis(9);
            rbBirou.Enabled = false;
        }

        private void rbCreioane_CheckedChanged(object sender, EventArgs e)
        {
            afis(10);
            rbCreioane.Enabled = false;
        }

        private void rbCarti_CheckedChanged(object sender, EventArgs e)
        {
            afis(11);
            rbCarti.Enabled = false;
        }

        private void LblIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void penIntrebare_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbBed_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
            rbBed.Enabled = false;
        }

        private void rbPillow_CheckedChanged(object sender, EventArgs e)
        {
            afis(2);
            rbPillow.Enabled = false;
        }

        private void rbNightStannd_CheckedChanged(object sender, EventArgs e)
        {
            afis(3);
            rbNightStannd.Enabled = false;
        }

        private void rbCarpet_CheckedChanged(object sender, EventArgs e)
        {
            afis(6);
            rbCarpet.Enabled = false;
        }

        private void rbChair_CheckedChanged(object sender, EventArgs e)
        {
            afis(5);
            rbChair.Enabled = false;
        }

        private void rbDesk_CheckedChanged(object sender, EventArgs e)
        {
            afis(9);
            rbDesk.Enabled = false;
        }

        private void rbPenels_CheckedChanged(object sender, EventArgs e)
        {
            afis(10);
            rbPenels.Enabled = false;
        }

        private void rbBooks_CheckedChanged(object sender, EventArgs e)
        {
            afis(11);
            rbBooks.Enabled = false;
        }

        
    }
}
