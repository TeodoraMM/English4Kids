namespace Engleza
{
    partial class frmCautare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCautare));
            this.rbRo = new System.Windows.Forms.RadioButton();
            this.rbFr = new System.Windows.Forms.RadioButton();
            this.txtCaut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFr = new System.Windows.Forms.Label();
            this.picM = new System.Windows.Forms.PictureBox();
            this.lblImag = new System.Windows.Forms.Label();
            this.lstCod = new System.Windows.Forms.ListBox();
            this.lstCuvinte = new System.Windows.Forms.ListBox();
            this.lblRo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grdi = new System.Windows.Forms.GroupBox();
            this.f10 = new System.Windows.Forms.Label();
            this.f9 = new System.Windows.Forms.Label();
            this.f8 = new System.Windows.Forms.Label();
            this.f7 = new System.Windows.Forms.Label();
            this.f6 = new System.Windows.Forms.Label();
            this.r2 = new System.Windows.Forms.Label();
            this.r5 = new System.Windows.Forms.Label();
            this.r4 = new System.Windows.Forms.Label();
            this.f4 = new System.Windows.Forms.Label();
            this.f3 = new System.Windows.Forms.Label();
            this.f5 = new System.Windows.Forms.Label();
            this.f2 = new System.Windows.Forms.Label();
            this.lblCaracter2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCaracter = new System.Windows.Forms.Label();
            this.r3 = new System.Windows.Forms.Label();
            this.r1 = new System.Windows.Forms.Label();
            this.f1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.pbFr = new System.Windows.Forms.PictureBox();
            this.pbRo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picM)).BeginInit();
            this.grdi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRo)).BeginInit();
            this.SuspendLayout();
            // 
            // rbRo
            // 
            this.rbRo.AutoSize = true;
            this.rbRo.BackColor = System.Drawing.Color.Transparent;
            this.rbRo.Checked = true;
            this.rbRo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbRo.Location = new System.Drawing.Point(270, 187);
            this.rbRo.Name = "rbRo";
            this.rbRo.Size = new System.Drawing.Size(42, 19);
            this.rbRo.TabIndex = 0;
            this.rbRo.TabStop = true;
            this.rbRo.Text = "RO";
            this.rbRo.UseVisualStyleBackColor = false;
            this.rbRo.CheckedChanged += new System.EventHandler(this.rbRo_CheckedChanged);
            // 
            // rbFr
            // 
            this.rbFr.AutoSize = true;
            this.rbFr.BackColor = System.Drawing.Color.Transparent;
            this.rbFr.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbFr.Location = new System.Drawing.Point(331, 185);
            this.rbFr.Name = "rbFr";
            this.rbFr.Size = new System.Drawing.Size(40, 19);
            this.rbFr.TabIndex = 1;
            this.rbFr.Text = "EN";
            this.rbFr.UseVisualStyleBackColor = false;
            this.rbFr.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txtCaut
            // 
            this.txtCaut.Location = new System.Drawing.Point(-3, 0);
            this.txtCaut.Name = "txtCaut";
            this.txtCaut.Size = new System.Drawing.Size(121, 20);
            this.txtCaut.TabIndex = 2;
            this.txtCaut.TextChanged += new System.EventHandler(this.txtCaut_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(255, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cuvânt:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblFr
            // 
            this.lblFr.AutoSize = true;
            this.lblFr.BackColor = System.Drawing.Color.Transparent;
            this.lblFr.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFr.Location = new System.Drawing.Point(463, 189);
            this.lblFr.Name = "lblFr";
            this.lblFr.Size = new System.Drawing.Size(65, 15);
            this.lblFr.TabIndex = 50;
            this.lblFr.Text = "Traducere";
            // 
            // picM
            // 
            this.picM.BackColor = System.Drawing.Color.Transparent;
            this.picM.Location = new System.Drawing.Point(453, 305);
            this.picM.Name = "picM";
            this.picM.Size = new System.Drawing.Size(220, 136);
            this.picM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picM.TabIndex = 54;
            this.picM.TabStop = false;
            this.picM.Click += new System.EventHandler(this.picM_Click);
            // 
            // lblImag
            // 
            this.lblImag.AutoSize = true;
            this.lblImag.BackColor = System.Drawing.Color.Transparent;
            this.lblImag.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImag.Location = new System.Drawing.Point(410, 274);
            this.lblImag.Name = "lblImag";
            this.lblImag.Size = new System.Drawing.Size(55, 15);
            this.lblImag.TabIndex = 55;
            this.lblImag.Text = "Imagine:";
            // 
            // lstCod
            // 
            this.lstCod.FormattingEnabled = true;
            this.lstCod.Location = new System.Drawing.Point(-3, 214);
            this.lstCod.Name = "lstCod";
            this.lstCod.Size = new System.Drawing.Size(121, 4);
            this.lstCod.TabIndex = 57;
            this.lstCod.Visible = false;
            // 
            // lstCuvinte
            // 
            this.lstCuvinte.FormattingEnabled = true;
            this.lstCuvinte.Location = new System.Drawing.Point(12, 109);
            this.lstCuvinte.Name = "lstCuvinte";
            this.lstCuvinte.Size = new System.Drawing.Size(98, 95);
            this.lstCuvinte.TabIndex = 56;
            this.lstCuvinte.SelectedIndexChanged += new System.EventHandler(this.lstCuvinte_SelectedIndexChanged);
            // 
            // lblRo
            // 
            this.lblRo.AutoSize = true;
            this.lblRo.BackColor = System.Drawing.Color.Transparent;
            this.lblRo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRo.Location = new System.Drawing.Point(463, 136);
            this.lblRo.Name = "lblRo";
            this.lblRo.Size = new System.Drawing.Size(65, 15);
            this.lblRo.TabIndex = 50;
            this.lblRo.Text = "Traducere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 14);
            this.label2.TabIndex = 50;
            this.label2.Text = "(RO)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(410, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 50;
            this.label4.Text = "(EN)";
            // 
            // grdi
            // 
            this.grdi.AutoSize = true;
            this.grdi.BackColor = System.Drawing.Color.Transparent;
            this.grdi.Controls.Add(this.lstCuvinte);
            this.grdi.Controls.Add(this.f10);
            this.grdi.Controls.Add(this.f9);
            this.grdi.Controls.Add(this.f8);
            this.grdi.Controls.Add(this.lstCod);
            this.grdi.Controls.Add(this.f7);
            this.grdi.Controls.Add(this.f6);
            this.grdi.Controls.Add(this.r2);
            this.grdi.Controls.Add(this.r5);
            this.grdi.Controls.Add(this.r4);
            this.grdi.Controls.Add(this.f4);
            this.grdi.Controls.Add(this.f3);
            this.grdi.Controls.Add(this.txtCaut);
            this.grdi.Controls.Add(this.f5);
            this.grdi.Controls.Add(this.f2);
            this.grdi.Controls.Add(this.lblCaracter2);
            this.grdi.Controls.Add(this.label5);
            this.grdi.Controls.Add(this.label6);
            this.grdi.Controls.Add(this.lblCaracter);
            this.grdi.Controls.Add(this.r3);
            this.grdi.Controls.Add(this.r1);
            this.grdi.Controls.Add(this.f1);
            this.grdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grdi.Location = new System.Drawing.Point(261, 226);
            this.grdi.Name = "grdi";
            this.grdi.Size = new System.Drawing.Size(124, 237);
            this.grdi.TabIndex = 58;
            this.grdi.TabStop = false;
            // 
            // f10
            // 
            this.f10.AutoSize = true;
            this.f10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f10.Location = new System.Drawing.Point(50, 195);
            this.f10.Name = "f10";
            this.f10.Size = new System.Drawing.Size(16, 16);
            this.f10.TabIndex = 40;
            this.f10.Text = "ù";
            this.f10.Visible = false;
            this.f10.Click += new System.EventHandler(this.f10_Click);
            // 
            // f9
            // 
            this.f9.AutoSize = true;
            this.f9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f9.Location = new System.Drawing.Point(33, 195);
            this.f9.Name = "f9";
            this.f9.Size = new System.Drawing.Size(16, 16);
            this.f9.TabIndex = 39;
            this.f9.Text = "û";
            this.f9.Visible = false;
            this.f9.Click += new System.EventHandler(this.f9_Click);
            // 
            // f8
            // 
            this.f8.AutoSize = true;
            this.f8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f8.Location = new System.Drawing.Point(50, 175);
            this.f8.Name = "f8";
            this.f8.Size = new System.Drawing.Size(17, 16);
            this.f8.TabIndex = 38;
            this.f8.Text = "ô";
            this.f8.Visible = false;
            this.f8.Click += new System.EventHandler(this.f8_Click);
            // 
            // f7
            // 
            this.f7.AutoSize = true;
            this.f7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f7.Location = new System.Drawing.Point(33, 174);
            this.f7.Name = "f7";
            this.f7.Size = new System.Drawing.Size(16, 16);
            this.f7.TabIndex = 37;
            this.f7.Text = "ç";
            this.f7.Visible = false;
            this.f7.Click += new System.EventHandler(this.f7_Click);
            // 
            // f6
            // 
            this.f6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f6.Location = new System.Drawing.Point(51, 157);
            this.f6.Name = "f6";
            this.f6.Size = new System.Drawing.Size(18, 16);
            this.f6.TabIndex = 36;
            this.f6.Text = "ê";
            this.f6.Visible = false;
            this.f6.Click += new System.EventHandler(this.f6_Click);
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.r2.Location = new System.Drawing.Point(32, 49);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(17, 16);
            this.r2.TabIndex = 35;
            this.r2.Text = "â";
            this.r2.Click += new System.EventHandler(this.r2_Click);
            // 
            // r5
            // 
            this.r5.AutoSize = true;
            this.r5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.r5.Location = new System.Drawing.Point(90, 48);
            this.r5.Name = "r5";
            this.r5.Size = new System.Drawing.Size(12, 16);
            this.r5.TabIndex = 34;
            this.r5.Text = "ț";
            this.r5.Click += new System.EventHandler(this.r5_Click);
            // 
            // r4
            // 
            this.r4.AutoSize = true;
            this.r4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.r4.Location = new System.Drawing.Point(72, 48);
            this.r4.Name = "r4";
            this.r4.Size = new System.Drawing.Size(16, 16);
            this.r4.TabIndex = 33;
            this.r4.Text = "ș";
            this.r4.Click += new System.EventHandler(this.r4_Click);
            // 
            // f4
            // 
            this.f4.AutoSize = true;
            this.f4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f4.Location = new System.Drawing.Point(51, 139);
            this.f4.Name = "f4";
            this.f4.Size = new System.Drawing.Size(17, 16);
            this.f4.TabIndex = 32;
            this.f4.Text = "é";
            this.f4.Visible = false;
            this.f4.Click += new System.EventHandler(this.f4_Click_1);
            // 
            // f3
            // 
            this.f3.AutoSize = true;
            this.f3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f3.Location = new System.Drawing.Point(32, 157);
            this.f3.Name = "f3";
            this.f3.Size = new System.Drawing.Size(17, 16);
            this.f3.TabIndex = 31;
            this.f3.Text = "è";
            this.f3.Visible = false;
            this.f3.Click += new System.EventHandler(this.f3_Click_1);
            // 
            // f5
            // 
            this.f5.AutoSize = true;
            this.f5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f5.Location = new System.Drawing.Point(33, 139);
            this.f5.Name = "f5";
            this.f5.Size = new System.Drawing.Size(17, 16);
            this.f5.TabIndex = 30;
            this.f5.Text = "â";
            this.f5.Visible = false;
            this.f5.Click += new System.EventHandler(this.f5_Click_1);
            // 
            // f2
            // 
            this.f2.AutoSize = true;
            this.f2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f2.Location = new System.Drawing.Point(51, 118);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(17, 16);
            this.f2.TabIndex = 29;
            this.f2.Text = "á";
            this.f2.Visible = false;
            this.f2.Click += new System.EventHandler(this.f2_Click_1);
            // 
            // lblCaracter2
            // 
            this.lblCaracter2.AutoSize = true;
            this.lblCaracter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCaracter2.Location = new System.Drawing.Point(17, 93);
            this.lblCaracter2.Name = "lblCaracter2";
            this.lblCaracter2.Size = new System.Drawing.Size(90, 13);
            this.lblCaracter2.TabIndex = 28;
            this.lblCaracter2.Text = "Caractere(FR):";
            this.lblCaracter2.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(2, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 2);
            this.label5.TabIndex = 27;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 2);
            this.label6.TabIndex = 26;
            this.label6.Text = "label6";
            // 
            // lblCaracter
            // 
            this.lblCaracter.AutoSize = true;
            this.lblCaracter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCaracter.Location = new System.Drawing.Point(15, 27);
            this.lblCaracter.Name = "lblCaracter";
            this.lblCaracter.Size = new System.Drawing.Size(92, 13);
            this.lblCaracter.TabIndex = 25;
            this.lblCaracter.Text = "Caractere(RO):";
            // 
            // r3
            // 
            this.r3.AutoSize = true;
            this.r3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.r3.Location = new System.Drawing.Point(54, 48);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(12, 17);
            this.r3.TabIndex = 24;
            this.r3.Text = "î";
            this.r3.Click += new System.EventHandler(this.r3_Click);
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.r1.Location = new System.Drawing.Point(9, 48);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(17, 17);
            this.r1.TabIndex = 24;
            this.r1.Text = "ă";
            this.r1.Click += new System.EventHandler(this.r1_Click);
            // 
            // f1
            // 
            this.f1.AutoSize = true;
            this.f1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f1.Location = new System.Drawing.Point(33, 117);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(17, 17);
            this.f1.TabIndex = 24;
            this.f1.Text = "à";
            this.f1.Visible = false;
            this.f1.Click += new System.EventHandler(this.f1_Click_1);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(854, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 22);
            this.button5.TabIndex = 59;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // pbFr
            // 
            this.pbFr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbFr.BackgroundImage")));
            this.pbFr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFr.Location = new System.Drawing.Point(324, 110);
            this.pbFr.Name = "pbFr";
            this.pbFr.Size = new System.Drawing.Size(39, 23);
            this.pbFr.TabIndex = 60;
            this.pbFr.TabStop = false;
            this.pbFr.Click += new System.EventHandler(this.pbFr_Click);
            // 
            // pbRo
            // 
            this.pbRo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbRo.BackgroundImage")));
            this.pbRo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRo.Location = new System.Drawing.Point(261, 110);
            this.pbRo.Name = "pbRo";
            this.pbRo.Size = new System.Drawing.Size(39, 23);
            this.pbRo.TabIndex = 61;
            this.pbRo.TabStop = false;
            this.pbRo.Click += new System.EventHandler(this.pbRo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(255, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Detalii căutare:";
            // 
            // frmCautare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(879, 499);
            this.Controls.Add(this.pbRo);
            this.Controls.Add(this.pbFr);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.grdi);
            this.Controls.Add(this.lblImag);
            this.Controls.Add(this.picM);
            this.Controls.Add(this.lblRo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbFr);
            this.Controls.Add(this.rbRo);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCautare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCautare";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCautare_FormClosed);
            this.Load += new System.EventHandler(this.frmCautare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picM)).EndInit();
            this.grdi.ResumeLayout(false);
            this.grdi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbRo;
        private System.Windows.Forms.RadioButton rbFr;
        private System.Windows.Forms.TextBox txtCaut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFr;
        private System.Windows.Forms.PictureBox picM;
        private System.Windows.Forms.Label lblImag;
        private System.Windows.Forms.ListBox lstCod;
        private System.Windows.Forms.ListBox lstCuvinte;
        private System.Windows.Forms.Label lblRo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grdi;
        private System.Windows.Forms.Label f10;
        private System.Windows.Forms.Label f9;
        private System.Windows.Forms.Label f8;
        private System.Windows.Forms.Label f7;
        private System.Windows.Forms.Label f6;
        private System.Windows.Forms.Label r2;
        private System.Windows.Forms.Label r5;
        private System.Windows.Forms.Label r4;
        private System.Windows.Forms.Label f4;
        private System.Windows.Forms.Label f3;
        private System.Windows.Forms.Label f5;
        private System.Windows.Forms.Label f2;
        private System.Windows.Forms.Label lblCaracter2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCaracter;
        private System.Windows.Forms.Label r3;
        private System.Windows.Forms.Label r1;
        private System.Windows.Forms.Label f1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pbFr;
        private System.Windows.Forms.PictureBox pbRo;
        private System.Windows.Forms.Label label1;
    }
}