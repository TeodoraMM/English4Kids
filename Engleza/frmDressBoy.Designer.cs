namespace Engleza
{
    partial class FrmDressUpBoy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDressUpBoy));
            this.panLista = new System.Windows.Forms.Panel();
            this.lblScor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSarcini = new System.Windows.Forms.CheckedListBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.lstImg = new System.Windows.Forms.ListBox();
            this.lstAlese = new System.Windows.Forms.ListBox();
            this.panImg = new System.Windows.Forms.Panel();
            this.pb = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblIesire = new System.Windows.Forms.Label();
            this.lblBest = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelInstructiuni = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.pictureBoxRO = new System.Windows.Forms.PictureBox();
            this.rbNoptiera = new System.Windows.Forms.PictureBox();
            this.lblIEngleza = new System.Windows.Forms.Label();
            this.lblIRomana = new System.Windows.Forms.Label();
            this.panLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelInstructiuni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbNoptiera)).BeginInit();
            this.SuspendLayout();
            // 
            // panLista
            // 
            this.panLista.BackColor = System.Drawing.Color.Transparent;
            this.panLista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panLista.BackgroundImage")));
            this.panLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panLista.Controls.Add(this.lblScor);
            this.panLista.Controls.Add(this.label1);
            this.panLista.Controls.Add(this.chkSarcini);
            this.panLista.Location = new System.Drawing.Point(367, 62);
            this.panLista.Name = "panLista";
            this.panLista.Size = new System.Drawing.Size(159, 138);
            this.panLista.TabIndex = 2;
            this.panLista.Paint += new System.Windows.Forms.PaintEventHandler(this.panLista_Paint);
            // 
            // lblScor
            // 
            this.lblScor.AutoSize = true;
            this.lblScor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblScor.Location = new System.Drawing.Point(129, 119);
            this.lblScor.Name = "lblScor";
            this.lblScor.Size = new System.Drawing.Size(13, 13);
            this.lblScor.TabIndex = 4;
            this.lblScor.Text = "0";
            this.lblScor.Click += new System.EventHandler(this.lblScor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(62, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your score:";
            // 
            // chkSarcini
            // 
            this.chkSarcini.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkSarcini.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkSarcini.ForeColor = System.Drawing.Color.Black;
            this.chkSarcini.FormattingEnabled = true;
            this.chkSarcini.Location = new System.Drawing.Point(12, 33);
            this.chkSarcini.Name = "chkSarcini";
            this.chkSarcini.Size = new System.Drawing.Size(145, 105);
            this.chkSarcini.TabIndex = 1;
            this.chkSarcini.SelectedIndexChanged += new System.EventHandler(this.chkSarcini_SelectedIndexChanged);
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(726, 410);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 23);
            this.btnVerify.TabIndex = 1;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(654, 410);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEmpty
            // 
            this.btnEmpty.Location = new System.Drawing.Point(588, 410);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(75, 23);
            this.btnEmpty.TabIndex = 1;
            this.btnEmpty.Text = "Empty";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // lstImg
            // 
            this.lstImg.FormattingEnabled = true;
            this.lstImg.Location = new System.Drawing.Point(293, 489);
            this.lstImg.Name = "lstImg";
            this.lstImg.Size = new System.Drawing.Size(79, 30);
            this.lstImg.TabIndex = 3;
            this.lstImg.Visible = false;
            // 
            // lstAlese
            // 
            this.lstAlese.FormattingEnabled = true;
            this.lstAlese.Location = new System.Drawing.Point(392, 489);
            this.lstAlese.Name = "lstAlese";
            this.lstAlese.Size = new System.Drawing.Size(79, 30);
            this.lstAlese.TabIndex = 3;
            this.lstAlese.Visible = false;
            // 
            // panImg
            // 
            this.panImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panImg.Location = new System.Drawing.Point(588, 49);
            this.panImg.Name = "panImg";
            this.panImg.Size = new System.Drawing.Size(216, 367);
            this.panImg.TabIndex = 2;
            this.panImg.Paint += new System.Windows.Forms.PaintEventHandler(this.panImg_Paint);
            // 
            // pb
            // 
            this.pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb.BackgroundImage")));
            this.pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pb.ErrorImage")));
            this.pb.Image = ((System.Drawing.Image)(resources.GetObject("pb.Image")));
            this.pb.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb.InitialImage")));
            this.pb.Location = new System.Drawing.Point(96, 181);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(200, 258);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            this.pb.Click += new System.EventHandler(this.pb_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(96, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 110);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LblIesire
            // 
            this.LblIesire.AutoSize = true;
            this.LblIesire.BackColor = System.Drawing.Color.Red;
            this.LblIesire.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIesire.ForeColor = System.Drawing.Color.White;
            this.LblIesire.Location = new System.Drawing.Point(920, 2);
            this.LblIesire.Name = "LblIesire";
            this.LblIesire.Size = new System.Drawing.Size(22, 22);
            this.LblIesire.TabIndex = 41;
            this.LblIesire.Text = "X";
            this.LblIesire.Click += new System.EventHandler(this.LblIesire_Click);
            // 
            // lblBest
            // 
            this.lblBest.AutoSize = true;
            this.lblBest.BackColor = System.Drawing.Color.Transparent;
            this.lblBest.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBest.ForeColor = System.Drawing.Color.White;
            this.lblBest.Location = new System.Drawing.Point(335, 9);
            this.lblBest.Name = "lblBest";
            this.lblBest.Size = new System.Drawing.Size(81, 16);
            this.lblBest.TabIndex = 42;
            this.lblBest.Text = "Your score:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 49);
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panelInstructiuni
            // 
            this.panelInstructiuni.BackColor = System.Drawing.Color.Transparent;
            this.panelInstructiuni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelInstructiuni.BackgroundImage")));
            this.panelInstructiuni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelInstructiuni.Controls.Add(this.lblExit);
            this.panelInstructiuni.Controls.Add(this.pictureBoxRO);
            this.panelInstructiuni.Controls.Add(this.rbNoptiera);
            this.panelInstructiuni.Controls.Add(this.lblIEngleza);
            this.panelInstructiuni.Controls.Add(this.lblIRomana);
            this.panelInstructiuni.Location = new System.Drawing.Point(37, 2);
            this.panelInstructiuni.Name = "panelInstructiuni";
            this.panelInstructiuni.Size = new System.Drawing.Size(259, 138);
            this.panelInstructiuni.TabIndex = 44;
            this.panelInstructiuni.Visible = false;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Red;
            this.lblExit.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(210, 7);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(18, 17);
            this.lblExit.TabIndex = 2;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // pictureBoxRO
            // 
            this.pictureBoxRO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRO.BackgroundImage")));
            this.pictureBoxRO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRO.Location = new System.Drawing.Point(44, 25);
            this.pictureBoxRO.Name = "pictureBoxRO";
            this.pictureBoxRO.Size = new System.Drawing.Size(29, 24);
            this.pictureBoxRO.TabIndex = 2;
            this.pictureBoxRO.TabStop = false;
            // 
            // rbNoptiera
            // 
            this.rbNoptiera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbNoptiera.BackgroundImage")));
            this.rbNoptiera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbNoptiera.Location = new System.Drawing.Point(44, 73);
            this.rbNoptiera.Name = "rbNoptiera";
            this.rbNoptiera.Size = new System.Drawing.Size(29, 24);
            this.rbNoptiera.TabIndex = 3;
            this.rbNoptiera.TabStop = false;
            // 
            // lblIEngleza
            // 
            this.lblIEngleza.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIEngleza.ForeColor = System.Drawing.Color.Black;
            this.lblIEngleza.Location = new System.Drawing.Point(78, 73);
            this.lblIEngleza.Name = "lblIEngleza";
            this.lblIEngleza.Size = new System.Drawing.Size(178, 51);
            this.lblIEngleza.TabIndex = 1;
            this.lblIEngleza.Text = "Dress up using style list and \r\ncheck out.";
            // 
            // lblIRomana
            // 
            this.lblIRomana.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRomana.ForeColor = System.Drawing.Color.Black;
            this.lblIRomana.Location = new System.Drawing.Point(79, 25);
            this.lblIRomana.Name = "lblIRomana";
            this.lblIRomana.Size = new System.Drawing.Size(167, 51);
            this.lblIRomana.TabIndex = 0;
            this.lblIRomana.Text = "Imbraca folosind lista de\r\n stil si verifica.";
            // 
            // FrmDressUpBoy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 602);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelInstructiuni);
            this.Controls.Add(this.lblBest);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.LblIesire);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panLista);
            this.Controls.Add(this.lstAlese);
            this.Controls.Add(this.lstImg);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.panImg);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDressUpBoy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dress Up Boy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panLista.ResumeLayout(false);
            this.panLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelInstructiuni.ResumeLayout(false);
            this.panelInstructiuni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbNoptiera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panLista;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.CheckedListBox chkSarcini;
        private System.Windows.Forms.ListBox lstImg;
        private System.Windows.Forms.ListBox lstAlese;
        private System.Windows.Forms.Panel panImg;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Label lblScor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblIesire;
        private System.Windows.Forms.Label lblBest;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelInstructiuni;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.PictureBox pictureBoxRO;
        private System.Windows.Forms.PictureBox rbNoptiera;
        private System.Windows.Forms.Label lblIEngleza;
        private System.Windows.Forms.Label lblIRomana;
    }
}

