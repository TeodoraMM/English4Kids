namespace Engleza
{
    partial class Ilustratfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ilustratfrm));
            this.lblCategorie = new System.Windows.Forms.Label();
            this.cbAlege = new System.Windows.Forms.ComboBox();
            this.lstCod = new System.Windows.Forms.ListBox();
            this.lstCuvinte = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRo = new System.Windows.Forms.TextBox();
            this.txtFr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.picM = new System.Windows.Forms.PictureBox();
            this.lblImag = new System.Windows.Forms.Label();
            this.cboPv = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.pbFr = new System.Windows.Forms.PictureBox();
            this.pbRo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.BackColor = System.Drawing.Color.Transparent;
            this.lblCategorie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCategorie.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCategorie.Location = new System.Drawing.Point(219, 165);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(89, 19);
            this.lblCategorie.TabIndex = 0;
            this.lblCategorie.Text = "Categorie:";
            // 
            // cbAlege
            // 
            this.cbAlege.FormattingEnabled = true;
            this.cbAlege.Location = new System.Drawing.Point(223, 187);
            this.cbAlege.Name = "cbAlege";
            this.cbAlege.Size = new System.Drawing.Size(124, 21);
            this.cbAlege.TabIndex = 1;
            this.cbAlege.SelectedIndexChanged += new System.EventHandler(this.cbAlege_SelectedIndexChanged);
            // 
            // lstCod
            // 
            this.lstCod.FormattingEnabled = true;
            this.lstCod.Location = new System.Drawing.Point(223, 348);
            this.lstCod.Name = "lstCod";
            this.lstCod.Size = new System.Drawing.Size(124, 95);
            this.lstCod.TabIndex = 37;
            this.lstCod.Visible = false;
            // 
            // lstCuvinte
            // 
            this.lstCuvinte.FormattingEnabled = true;
            this.lstCuvinte.Location = new System.Drawing.Point(223, 235);
            this.lstCuvinte.Name = "lstCuvinte";
            this.lstCuvinte.Size = new System.Drawing.Size(124, 95);
            this.lstCuvinte.TabIndex = 36;
            this.lstCuvinte.SelectedIndexChanged += new System.EventHandler(this.lstCuvinte_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(408, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 45;
            this.label6.Text = "Parte vorbire:";
            // 
            // txtRo
            // 
            this.txtRo.Location = new System.Drawing.Point(411, 146);
            this.txtRo.Name = "txtRo";
            this.txtRo.Size = new System.Drawing.Size(145, 20);
            this.txtRo.TabIndex = 38;
            this.txtRo.TextChanged += new System.EventHandler(this.txtRo_TextChanged);
            // 
            // txtFr
            // 
            this.txtFr.Location = new System.Drawing.Point(411, 187);
            this.txtFr.Name = "txtFr";
            this.txtFr.Size = new System.Drawing.Size(145, 20);
            this.txtFr.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(408, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "Cuvânt(EN):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(408, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "Cuvânt(RO):";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // picM
            // 
            this.picM.BackColor = System.Drawing.Color.Transparent;
            this.picM.Location = new System.Drawing.Point(411, 322);
            this.picM.Name = "picM";
            this.picM.Size = new System.Drawing.Size(191, 144);
            this.picM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picM.TabIndex = 41;
            this.picM.TabStop = false;
            this.picM.Click += new System.EventHandler(this.picM_Click);
            // 
            // lblImag
            // 
            this.lblImag.AutoSize = true;
            this.lblImag.BackColor = System.Drawing.Color.Transparent;
            this.lblImag.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImag.Location = new System.Drawing.Point(408, 291);
            this.lblImag.Name = "lblImag";
            this.lblImag.Size = new System.Drawing.Size(55, 15);
            this.lblImag.TabIndex = 46;
            this.lblImag.Text = "Imagine:";
            // 
            // cboPv
            // 
            this.cboPv.Location = new System.Drawing.Point(411, 250);
            this.cboPv.Name = "cboPv";
            this.cboPv.Size = new System.Drawing.Size(147, 20);
            this.cboPv.TabIndex = 47;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(727, -1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 22);
            this.button5.TabIndex = 48;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pbFr
            // 
            this.pbFr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbFr.BackgroundImage")));
            this.pbFr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFr.ErrorImage = null;
            this.pbFr.Location = new System.Drawing.Point(308, 118);
            this.pbFr.Name = "pbFr";
            this.pbFr.Size = new System.Drawing.Size(39, 23);
            this.pbFr.TabIndex = 49;
            this.pbFr.TabStop = false;
            this.pbFr.Click += new System.EventHandler(this.pbFr_Click);
            // 
            // pbRo
            // 
            this.pbRo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbRo.BackgroundImage")));
            this.pbRo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRo.Location = new System.Drawing.Point(223, 118);
            this.pbRo.Name = "pbRo";
            this.pbRo.Size = new System.Drawing.Size(39, 23);
            this.pbRo.TabIndex = 50;
            this.pbRo.TabStop = false;
            this.pbRo.Click += new System.EventHandler(this.pbRo_Click);
            // 
            // Ilustratfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(748, 502);
            this.Controls.Add(this.pbRo);
            this.Controls.Add(this.pbFr);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cboPv);
            this.Controls.Add(this.lblImag);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRo);
            this.Controls.Add(this.txtFr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.picM);
            this.Controls.Add(this.lstCod);
            this.Controls.Add(this.lstCuvinte);
            this.Controls.Add(this.cbAlege);
            this.Controls.Add(this.lblCategorie);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ilustratfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ilustratfrm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ilustratfrm_FormClosed);
            this.Load += new System.EventHandler(this.Ilustratfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.ComboBox cbAlege;
        private System.Windows.Forms.ListBox lstCod;
        private System.Windows.Forms.ListBox lstCuvinte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRo;
        private System.Windows.Forms.TextBox txtFr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picM;
        private System.Windows.Forms.Label lblImag;
        private System.Windows.Forms.TextBox cboPv;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pbFr;
        private System.Windows.Forms.PictureBox pbRo;
    }
}