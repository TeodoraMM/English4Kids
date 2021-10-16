using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Engleza
{
    public partial class frmMainS : Form
    {
        public frmMainS()
        {
          
            InitializeComponent();
        }

        public Administrare fadm = null;

        private void label1_Click(object sender, EventArgs e)
        {
            if (fadm == null)
            {
               //  fadm= new Administrare(this);
                fadm.Show();
               
            }

        }
       
        public Ilustratfrm filust = null;


        private void label2_Click(object sender, EventArgs e)
        {
            if (filust == null)
            {
                //filust = new Ilustratfrm(this);
                filust.Show();
               
            }
        }
    
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        public frmCautare fcaut = null;

        private void label3_Click(object sender, EventArgs e)
        {
            if (fcaut == null)
            {
                // fcaut= new frmCautare(this);
                 fcaut.Show();
        }
        }
        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void frmMain_MouseClick(object sender, MouseEventArgs e)
        {
        MessageBox.Show(e.X + " " + e.Y);
        }

        public FrmAjutor aj = null;
        private void button1_Click(object sender, EventArgs e)
        {
         if (aj == null)
            {
                 //aj= new Ajutorfrm(this);
                 aj.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }
    }
}
