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
    public partial class FrmTabel : Form
    {
        
        public FrmTabel(FrmMain fMain)
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }

        private void FrmTabel_Load(object sender, EventArgs e)
        {

        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void lblBathroom_Click(object sender, EventArgs e)
        {
            (this.MdiParent as FrmMain).fbath = new FrmBath(this.MdiParent as FrmMain);
            (this.MdiParent as FrmMain).fbath.Show();
        }

        private void lblBedRoom_Click(object sender, EventArgs e)
        {
            (this.MdiParent as FrmMain).fBed = new FrmBed(this.MdiParent as FrmMain);
            (this.MdiParent as FrmMain).fBed.Show();
        }

        private void lblGirlBedroom_Click(object sender, EventArgs e)
        {
            (this.MdiParent as FrmMain).fGirl = new FrmBedroomGirl(this.MdiParent as FrmMain);
            (this.MdiParent as FrmMain).fGirl.Show();
        }

        private void lblBoyBedroom_Click(object sender, EventArgs e)
        {
            (this.MdiParent as FrmMain).frmybed = new FrmBoyBedroom(this.MdiParent as FrmMain);
            (this.MdiParent as FrmMain).frmybed.Show();
        }

        private void lblDinning_Click(object sender, EventArgs e)
        {
            (this.MdiParent as FrmMain).fdining = new FrmDining(this.MdiParent as FrmMain);
            (this.MdiParent as FrmMain).fdining.Show();
        }

        private void lblHall_Click(object sender, EventArgs e)
        {
            (this.MdiParent as FrmMain).fhall = new FrmHall(this.MdiParent as FrmMain);
            (this.MdiParent as FrmMain).fhall.Show();
        }

        private void lblKitchen_Click(object sender, EventArgs e)
        {
            (this.MdiParent as FrmMain).fkitchen = new FrmKitchen(this.MdiParent as FrmMain);
            (this.MdiParent as FrmMain).fkitchen.Show();
        }

        private void lblLiving_Click(object sender, EventArgs e)
        {
            (this.MdiParent as FrmMain).fliving = new FrmLiving(this.MdiParent as FrmMain);
            (this.MdiParent as FrmMain).fliving.Show();
        }

        private void lblYard_Click(object sender, EventArgs e)
        {
            (this.MdiParent as FrmMain).fyard = new FrmYard(this.MdiParent as FrmMain);
            (this.MdiParent as FrmMain).fyard.Show();
        }
    }
}
