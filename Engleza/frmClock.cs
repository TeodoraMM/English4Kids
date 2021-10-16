using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engleza
{
    public partial class frmClock : Form
    {
        public frmClock(FrmMain fMain)
        {
            this.MdiParent = fMain;
            InitializeComponent();
        }
        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        string[] cerinta=new string[100];
        string[] corect = new string[100];
        int nr = 0,crt=0,scor=0;
        bool posibil = true;

        private void frmClock_Load(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string text = "select * from ceas order by rnd(id)";
            OleDbCommand com = new OleDbCommand(text, con);
        
            OleDbDataReader r = com.ExecuteReader();

            while (r.Read())
            {
                cerinta[nr]=r["cerinta"].ToString();
                corect[nr]=r["corect"].ToString();
                nr++;
            }
            con.Close();
            lblCerinta.Text = cerinta[crt];

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (crt <nr-1)
                crt++;
            lblCerinta.Text = cerinta[crt];
        }
        
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (crt > 0)
                crt--;
            lblCerinta.Text = cerinta[crt];

        }

        

        private void txtH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&e.KeyChar!=8) 
            {
                e.Handled = true;
            }
                   
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelInstructiuni.Visible = true;
        }

        private void panelInstructiuni_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panelInstructiuni.Visible = false;
        }

        private void btnJocNou_Click(object sender, EventArgs e)
        {
            btnVerif.Enabled = true;
            crt++;
            if (crt == nr)
            {
                frmMessageboxOk msgOk = new frmMessageboxOk("No more moves!");
                msgOk.ShowDialog();
                return;
            }
            crt = new Random().Next(0, nr);
            lblCerinta.Text = cerinta[crt];
        }
        private void btnVerif_Click(object sender, EventArgs e)
        {
            string rez = "";
            if (txtH.Text.Length == 1)
                rez += "0";
            rez += txtH.Text+":";

            if (txtM.Text.Length == 1)
                rez += "0";
            rez += txtM.Text;
            if (rez == corect[crt])
                scor++;
            else
                if (scor > 0)
                scor--;
            lblScor.Text = scor.ToString();
            btnVerif.Enabled = false;
            

        }
    }
}
