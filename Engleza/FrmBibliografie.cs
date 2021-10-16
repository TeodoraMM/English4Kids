using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engleza
{
    public partial class FrmBibliografie : Form
    {
        public FrmBibliografie(FrmMain fMain)
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("chrome", "http://www.libris.ro/limbajul-c-pentru-incepatori-notiuni-de-baza-ALB973-650-153-1--p354407.html?gclid=CI-GwPP9o9UCFcUp0wodbQgPCA");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("chrome", "https://www.procarti.ro/carte/c-pentru-liceu-programare-in-visual-c-2008-express-edition--i21954");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("chrome", "http://www.sketchup.com/");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("chrome", "https://pixabay.com/ro/");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Process.Start("chrome", "https://adobe-photoshop-cs6-update.en.softonic.com/");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("chrome", "https://msdn.microsoft.com/en-us/library/dd831853.aspx");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("chrome", "http://www.etranslator.ro/traducere-engleza-romana-online.php");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.microsoft.com/ro-ro/download/details.aspx?id=39358");
        }

        private void LblIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
