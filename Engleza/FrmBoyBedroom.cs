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
    public partial class FrmBoyBedroom : Form
    {
        public FrmBoyBedroom(FrmMain fMain)
        {
            this.MdiParent = fMain; 
            InitializeComponent();
        }
        string[] A = { "dragon", "drawing","rabbit","carts","bear","chair","light", "soldier","box","telephone","lamp","cheir","capet", "cupboard","ball","sabs", "sneakers" };
        string[] B = {  "snake","draw","moouse","books","cat","sofa","chandelier","solder","cup", "radio","window","scan","cower","armchair","sofa", "sword" , "adidasi" };
        string[] C = {  "sheep","painting","mose","news","dog","bed","lamp","soldat","bocs","television","geam","chair","carpet","box","teddy bear","sourd","clothes"};
        string[] corect = { "A", "A", "B", "B", "C", "C", "C" ,"A","A","B","B","C","C","A","A","B","B"};
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
            penIntrebare.Visible = true;
            pbCorect.Visible = false;
            pbIncorect.Visible = false;
            btver.Enabled = true;
        }
        int scor = 0;
        private void FrmMybed_Load(object sender, EventArgs e)
        {
            lblBest.Text = variabile.utilizator + "' best score: " + score.ShowBestScore("Home-Boy Bedroom");
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

        private void btver_Click(object sender, EventArgs e)
        {
            if (rbA.Checked && btver.Tag.ToString() == "A" || rbB.Checked && btver.Tag.ToString() == "B" || rbC.Checked && btver.Tag.ToString() == "C")
            {
                pbCorect.Visible = true;
                pbIncorect.Visible = false;
                variabile.punctaj++;
                scor++;
                lblrezultat.Text = "Your score :" + variabile.punctaj;
                if (score.SetBestScore("Home-Boy Bedroom", scor) == 1)
                {
                    lblBest.Text = variabile.utilizator + "' best score: " + score.ShowBestScore("Home-Boy Bedroom");
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

        

        private void lblrezultat_Click(object sender, EventArgs e)
        {

        }

        private void rbDragon_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
            rbDragon.Enabled = false;
        }

        private void rbDragon2_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
            rbDragon2.Enabled = false;
        }

        private void rbDragoni_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
            rbDragoni.Enabled = false;
        }

        private void rbDesen_CheckedChanged(object sender, EventArgs e)
        {
            afis(1);
            rbDesen.Enabled = false;
        }

        private void rbSoarece_CheckedChanged(object sender, EventArgs e)
        {
            afis(2);
            rbSoarece.Enabled = false;
        }

        private void rbCarte_CheckedChanged(object sender, EventArgs e)
        {
            afis(3);
            rbCarte.Enabled = false;
        }

        private void rbDragons_CheckedChanged(object sender, EventArgs e)
        {
            afis(0);
            rbDragons.Enabled = false;
        }

        private void rbCaine_CheckedChanged(object sender, EventArgs e)
        {
            afis(4);
            rbCaine.Enabled = false;
        }

        private void rbCaine1_CheckedChanged(object sender, EventArgs e)
        {
            afis(4);
            rbCaine1.Enabled = false;
        }

        private void rbPat_CheckedChanged(object sender, EventArgs e)
        {
            afis(5);
            rbPat.Enabled = false;
        }

        private void rbLampa_CheckedChanged(object sender, EventArgs e)
        {
            afis(6);
            rbLampa.Enabled = false;
        }

        private void rbSoldat_CheckedChanged(object sender, EventArgs e)
        {
            afis(7);
            rbSoldat.Enabled = false;
        }

        private void rbCutii_CheckedChanged(object sender, EventArgs e)
        {
            afis(8);
            rbCutii.Enabled = false;
        }

        private void rbRadio_CheckedChanged(object sender, EventArgs e)
        {
            afis(9);
            rbRadio.Enabled = false;
        }

        private void rbGeam_CheckedChanged(object sender, EventArgs e)
        {
            afis(10);
            rbGeam.Enabled = false;
        }

        private void rbScaun_CheckedChanged(object sender, EventArgs e)
        {
            afis(11);
            rbScaun.Enabled = false;
        }

        private void rbScaun1_CheckedChanged(object sender, EventArgs e)
        {
            afis(11);
            rbScaun1.Enabled = false;
        }

        private void rbCovor_CheckedChanged(object sender, EventArgs e)
        {
            afis(12);
            rbCovor.Enabled = false;
        }

        private void rbDulap_CheckedChanged(object sender, EventArgs e)
        {
            afis(13);
            rbDulap.Enabled = false;
        }

        private void rbMinge_CheckedChanged(object sender, EventArgs e)
        {
            afis(14);
            rbMinge.Enabled = false;
        }

        private void rbSabie_CheckedChanged(object sender, EventArgs e)
        {
            afis(15);
            rbSabie.Enabled = false;
        }

        private void rbAdidasi_CheckedChanged(object sender, EventArgs e)
        {
            afis(16);
            rbAdidasi.Enabled = false;
        }

        private void lblIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
