namespace Engleza
{
    partial class frmClock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClock));
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCerinta = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnJocNou = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Label();
            this.btnVerif = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelInstructiuni = new System.Windows.Forms.Panel();
            this.pictureBoxEN = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxRO = new System.Windows.Forms.PictureBox();
            this.lblIEngleza = new System.Windows.Forms.Label();
            this.lblIRomana = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelInstructiuni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRO)).BeginInit();
            this.SuspendLayout();
            // 
            // txtM
            // 
            this.txtM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtM.Location = new System.Drawing.Point(125, 35);
            this.txtM.MaxLength = 2;
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(46, 29);
            this.txtM.TabIndex = 1;
            this.txtM.Text = "00";
            this.txtM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtH
            // 
            this.txtH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtH.Location = new System.Drawing.Point(43, 35);
            this.txtH.MaxLength = 2;
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(46, 29);
            this.txtH.TabIndex = 1;
            this.txtH.Text = "00";
            this.txtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtH_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.txtM);
            this.panel1.Controls.Add(this.txtH);
            this.panel1.Location = new System.Drawing.Point(333, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 102);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Set the clock to: ";
            // 
            // lblCerinta
            // 
            this.lblCerinta.AutoSize = true;
            this.lblCerinta.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerinta.Location = new System.Drawing.Point(126, 198);
            this.lblCerinta.Name = "lblCerinta";
            this.lblCerinta.Size = new System.Drawing.Size(23, 36);
            this.lblCerinta.TabIndex = 3;
            this.lblCerinta.Text = ".";
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(77, 188);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(27, 23);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Visible = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(79, 159);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(27, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your score:";
            // 
            // lblScor
            // 
            this.lblScor.AutoSize = true;
            this.lblScor.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScor.Location = new System.Drawing.Point(258, 322);
            this.lblScor.Name = "lblScor";
            this.lblScor.Size = new System.Drawing.Size(31, 36);
            this.lblScor.TabIndex = 3;
            this.lblScor.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(303, 38);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(2, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtH_KeyPress);
            // 
            // btnJocNou
            // 
            this.btnJocNou.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJocNou.BackgroundImage")));
            this.btnJocNou.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJocNou.Location = new System.Drawing.Point(352, 278);
            this.btnJocNou.Name = "btnJocNou";
            this.btnJocNou.Size = new System.Drawing.Size(192, 33);
            this.btnJocNou.TabIndex = 4;
            this.btnJocNou.Text = "New game";
            this.btnJocNou.UseVisualStyleBackColor = true;
            this.btnJocNou.Click += new System.EventHandler(this.btnJocNou_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Red;
            this.lblExit.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(641, -1);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(23, 23);
            this.lblExit.TabIndex = 6;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // btnVerif
            // 
            this.btnVerif.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerif.BackgroundImage")));
            this.btnVerif.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerif.Location = new System.Drawing.Point(352, 240);
            this.btnVerif.Name = "btnVerif";
            this.btnVerif.Size = new System.Drawing.Size(194, 32);
            this.btnVerif.TabIndex = 4;
            this.btnVerif.Text = "Verify";
            this.btnVerif.UseVisualStyleBackColor = true;
            this.btnVerif.Click += new System.EventHandler(this.btnVerif_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 47);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelInstructiuni
            // 
            this.panelInstructiuni.BackColor = System.Drawing.Color.Transparent;
            this.panelInstructiuni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelInstructiuni.BackgroundImage")));
            this.panelInstructiuni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelInstructiuni.Controls.Add(this.pictureBoxEN);
            this.panelInstructiuni.Controls.Add(this.label3);
            this.panelInstructiuni.Controls.Add(this.pictureBoxRO);
            this.panelInstructiuni.Controls.Add(this.lblIEngleza);
            this.panelInstructiuni.Controls.Add(this.lblIRomana);
            this.panelInstructiuni.Location = new System.Drawing.Point(40, -1);
            this.panelInstructiuni.Name = "panelInstructiuni";
            this.panelInstructiuni.Size = new System.Drawing.Size(257, 145);
            this.panelInstructiuni.TabIndex = 10;
            this.panelInstructiuni.Visible = false;
            this.panelInstructiuni.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInstructiuni_Paint);
            // 
            // pictureBoxEN
            // 
            this.pictureBoxEN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEN.BackgroundImage")));
            this.pictureBoxEN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxEN.Location = new System.Drawing.Point(43, 81);
            this.pictureBoxEN.Name = "pictureBoxEN";
            this.pictureBoxEN.Size = new System.Drawing.Size(29, 24);
            this.pictureBoxEN.TabIndex = 3;
            this.pictureBoxEN.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(221, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "x";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBoxRO
            // 
            this.pictureBoxRO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRO.BackgroundImage")));
            this.pictureBoxRO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRO.Location = new System.Drawing.Point(37, 13);
            this.pictureBoxRO.Name = "pictureBoxRO";
            this.pictureBoxRO.Size = new System.Drawing.Size(29, 24);
            this.pictureBoxRO.TabIndex = 2;
            this.pictureBoxRO.TabStop = false;
            // 
            // lblIEngleza
            // 
            this.lblIEngleza.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIEngleza.ForeColor = System.Drawing.Color.Black;
            this.lblIEngleza.Location = new System.Drawing.Point(75, 79);
            this.lblIEngleza.Name = "lblIEngleza";
            this.lblIEngleza.Size = new System.Drawing.Size(161, 88);
            this.lblIEngleza.TabIndex = 1;
            this.lblIEngleza.Text = "Write the hour numbers to learn The English clock.";
            // 
            // lblIRomana
            // 
            this.lblIRomana.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRomana.ForeColor = System.Drawing.Color.Black;
            this.lblIRomana.Location = new System.Drawing.Point(72, 10);
            this.lblIRomana.Name = "lblIRomana";
            this.lblIRomana.Size = new System.Drawing.Size(154, 72);
            this.lblIRomana.TabIndex = 0;
            this.lblIRomana.Text = "Scrie cifrele  corespuzatoare orei  pentru a invata ceasul limbii engleze";
            // 
            // frmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(664, 477);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelInstructiuni);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnJocNou);
            this.Controls.Add(this.btnVerif);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.lblCerinta);
            this.Controls.Add(this.lblScor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClock";
            this.Load += new System.EventHandler(this.frmClock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelInstructiuni.ResumeLayout(false);
            this.panelInstructiuni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCerinta;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnJocNou;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button btnVerif;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelInstructiuni;
        private System.Windows.Forms.PictureBox pictureBoxEN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxRO;
        private System.Windows.Forms.Label lblIEngleza;
        private System.Windows.Forms.Label lblIRomana;
    }
}