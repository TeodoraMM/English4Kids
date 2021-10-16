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
    public partial class FrmKitchen : Form
    {
        public FrmKitchen( FrmMain fMain )
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }
        string[] A = { "gas range","fruits","oven","traten","wood","vass","cnife", "spice pots","poons","mass" };
        string[] B = { "oven","legums" ,"gas", "threaten", "furniture","cupp","kniffer","cups", "spoons","light" };
        string[] C = { "ranger","plants","range","reaten","items", "road","knife","knife","spons","chair" };
        string[] corect = {  "A","A","A","B","B","C","C","A","B","C"};
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
            lblRezultat.Text =" ";
            panelFrigider.Visible = true;

            btnVerifica.Enabled = true;
        }
        private void FrmKitchen_Load(object sender, EventArgs e)
        {
            lblBest.Text = variabile.utilizator + "' best score: " + score.ShowBestScore("Home-Kitchen");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelInstructiuni.Visible = true;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            panelInstructiuni.Visible = false;
        }

      //  private void pictureBox2_Click(object sender, EventArgs e)
      //  {
           // afis(0);
           // pictureBox2.Enabled = false;
       // }
        private void panelFrigider_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

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
                if (score.SetBestScore("Home-Kitchen", scor) == 1)
                {
                    lblBest.Text = variabile.utilizator + "' best score: " + score.ShowBestScore("Home-Kitchen");
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
            panelFrigider.Visible = false;
        }

        private void rbCuptor_CheckedChanged(object sender, EventArgs e)
        {
            afis(2);
            rbCuptor.Enabled = false;
        }

        private void rbAragaz_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
            rbAragaz.Enabled = false;
        }

        private void rbFructe_CheckedChanged(object sender, EventArgs e)
        {
            afis(1);
            rbFructe.Enabled = false;
        }

        private void rbHota_CheckedChanged(object sender, EventArgs e)
        {
            afis(3);
            rbHota.Enabled = false;
        }

        private void rbMobila_CheckedChanged(object sender, EventArgs e)
        {
            afis(4);
            rbMobila.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            afis(4);
            radioButton1.Enabled = false;
        }

        private void rbMobila3_CheckedChanged(object sender, EventArgs e)
        {
            afis(4);
            rbMobila3.Enabled = false;
        }

        private void rbCesti_CheckedChanged(object sender, EventArgs e)
        {
            afis(5);
            rbCesti.Enabled = false;
        }

        private void rbCutite_CheckedChanged(object sender, EventArgs e)
        {
            afis(6);
            rbCutite.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            afis(7);
            radioButton2.Enabled = false;
        }

        private void rbLinguri_CheckedChanged(object sender, EventArgs e)
        {
            afis(8);
            rbLinguri.Enabled = false;
        }

        private void rbScaun_CheckedChanged(object sender, EventArgs e)
        {
            afis(9);
            rbScaun.Enabled = false;
        }

        private void LblIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
