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
    public partial class FrmLogOut : Form
    {

        public FrmLogOut(FrmMain fMain)
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }
        private void FrmLogOut_Load(object sender, EventArgs e)
        {
            variabile.utilizator = "";
            (this.MdiParent as FrmMain).Controls["lblutilizator"].Text = "Utilizator: Anonim " + variabile.utilizator;
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
