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
    public partial class FrmCifre : Form
    {
        public FrmCifre(FrmMain fMain)
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }

        string[] fructe = { "apple", "banana", "pear", "avocado","orange", "strawberry", "pineapple", "watermelon", "grapes" };
        string[] cifre = { "zero","one", "two", "three", "four","five","six","seven","eight","nine","ten","eleven", "twelve", "thirteen","fourteen","fiveteen","sixteen","seventeen","eighteen","nineteen", "twenty" };
        int scor = 0,cate=0,necesar;

        private void FrmCifre_Load(object sender, EventArgs e)
        {
            btnJocNou.PerformClick();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            cate++;
            lblCate.Text = cate.ToString();

        }

        private void btnVerif_Click(object sender, EventArgs e)
        {
            if(cate==necesar)
            {
                scor++;
            }
            else
            {
                scor--;
            }
            lblScor.Text = scor.ToString();
            btnVerif.Enabled = false;
        }

        private void lblIRomana_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelInstructiuni.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panelInstructiuni.Visible = false;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_Click(object sender, EventArgs e)
        {

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (cate == 0)
                return;
            cate--;
            lblCate.Text = cate.ToString();
        }

        private void btnJocNou_Click(object sender, EventArgs e)
        {
            int care = new Random().Next(0,9);
            necesar = new Random().Next(0, 21);
            lblCerinta1.Text = "I need some " + fructe[care] + "s.";
            lblCerinta3.Text = cifre[necesar];
            cate = 0;
            lblCate.Text = "0";
            pb.Image = new Bitmap("cifre/" + fructe[care] + ".jpg");
            btnVerif.Enabled = true;
        }
    }
}
