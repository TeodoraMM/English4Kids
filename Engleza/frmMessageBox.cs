﻿using System;
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
    public partial class frmMessageBoxYesNo : Form
    {
        public frmMessageBoxYesNo(string mesaj)
        {
            InitializeComponent();
            lblMesaj.Text = mesaj;
        }

        private void frmMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void LblIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}