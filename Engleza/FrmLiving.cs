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
    public partial class FrmLiving : Form
    {
        public FrmLiving(FrmMain fMain)
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }
        string[] A = { "television","news","chair","bed","window","chandelir","lamp","window","plan","tableu","cower" };
        string[] B = { "tevision" ,"books","sofa","sofa","picture", "chandelier","vass","wall","vass","mass","floor" };
        string[] C = {"picture","wall", "armchair","lamp","books","lamp","vase","carpet","plant","table","carpet" };
        string[] corect = { "A","B","C","B","B","B","A","A","C","C","C"  };
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
            pnlUsa.Visible = true;
            btnVerifica.Enabled = true;//-----------------------
        }
        private void FrmLiving_Load(object sender, EventArgs e)
        {
            lblBest.Text = variabile.utilizator + "' best score: " + score.ShowBestScore("Home-Living Room"); 
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
                if (score.SetBestScore("Home-Living Room", scor) == 1)
                {
                    lblBest.Text = variabile.utilizator + "' best score: " + score.ShowBestScore("Home-Living Room");
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
            btnVerifica.Enabled = false;//-----------------------
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

        
        private void lblX_Click(object sender, EventArgs e)
        {
            pnlUsa.Visible = false;
        }

        private void btnVerifica_Click_1(object sender, EventArgs e)
        {
            if (rbA.Checked && btnVerifica.Tag.ToString() == "A" || rbB.Checked && btnVerifica.Tag.ToString() == "B" || rbC.Checked && btnVerifica.Tag.ToString() == "C")
            {
                pbCorect.Visible = true;
                pbIncorect.Visible = false;
                variabile.punctaj++;
                lblRezultat.Text = "Corect :" + variabile.punctaj + " puncte";
            }
            else
            {
                pbIncorect.Visible = true;
                pbCorect.Visible = false;
                lblRezultat.Text = "Incorect";

            }
            btnVerifica.Enabled = false;//-----------------------
        }


        private void lblX_Click_1(object sender, EventArgs e)
        {
            pnlUsa.Visible = false;
        }

        private void lblRezultat_Click(object sender, EventArgs e)
        {

        }

        private void rbTV_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
            rbTV.Enabled = false; //-----------------------
        }

        private void rbCarti_CheckedChanged(object sender, EventArgs e)
        {
            afis(1);
            rbCarti.Enabled = false;
        }

        private void rbCarti1_CheckedChanged(object sender, EventArgs e)
        {
            afis(1);
            rbCarti1.Enabled = false;
        }

        private void rbFotoliu_CheckedChanged(object sender, EventArgs e)
        {
            afis(2);
            rbFotoliu.Enabled = false;
        }

        private void rbFotoliu2_CheckedChanged(object sender, EventArgs e)
        {
            afis(2);
            rbFotoliu2.Enabled = false;
        }

        private void rbCanapea_CheckedChanged(object sender, EventArgs e)
        {
            afis(3);
            rbCanapea.Enabled = false;
        }

        private void rbTablouri_CheckedChanged(object sender, EventArgs e)
        {
            afis(4);
            rbTablouri.Enabled = false;
        }

        private void rbCandelabru_CheckedChanged(object sender, EventArgs e)
        {
            afis(5);
            rbCandelabru.Enabled = false;
        }

        private void rbLampa_CheckedChanged(object sender, EventArgs e)
        {
            afis(6);
            rbLampa.Enabled = false;
        }

        private void rbFereastra_CheckedChanged(object sender, EventArgs e)
        {
            afis(7);
            rbFereastra.Enabled = false;
        }

        private void rbPlanta_CheckedChanged(object sender, EventArgs e)
        {
            afis(8);
            rbPlanta.Enabled = false;
        }

        private void rbMasa_CheckedChanged(object sender, EventArgs e)
        {
            afis(9);
            rbMasa.Enabled = false;
        }

        private void rbCovor_CheckedChanged(object sender, EventArgs e)
        {
            afis(10);
            rbCovor.Enabled = false;
        }

        private void LblIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pnlUsa.Visible = false;
        }
    }
}
