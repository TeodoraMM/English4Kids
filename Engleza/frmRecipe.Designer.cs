namespace Engleza
{
    partial class frmRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipe));
            this.panLista = new System.Windows.Forms.Panel();
            this.btnVerify = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkIngrediente = new System.Windows.Forms.CheckedListBox();
            this.lblScor = new System.Windows.Forms.Label();
            this.lstAlese = new System.Windows.Forms.ListBox();
            this.panImg = new System.Windows.Forms.Panel();
            this.cboRetete = new System.Windows.Forms.ComboBox();
            this.pbFinal = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelInstructiuni = new System.Windows.Forms.Panel();
            this.pictureBoxEN = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.pictureBoxRO = new System.Windows.Forms.PictureBox();
            this.lblIEngleza = new System.Windows.Forms.Label();
            this.lblIRomana = new System.Windows.Forms.Label();
            this.LblIesire = new System.Windows.Forms.Label();
            this.lblBest = new System.Windows.Forms.Label();
            this.panLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelInstructiuni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRO)).BeginInit();
            this.SuspendLayout();
            // 
            // panLista
            // 
            this.panLista.BackColor = System.Drawing.Color.Transparent;
            this.panLista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panLista.BackgroundImage")));
            this.panLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panLista.Controls.Add(this.btnVerify);
            this.panLista.Controls.Add(this.label1);
            this.panLista.Controls.Add(this.chkIngrediente);
            this.panLista.Location = new System.Drawing.Point(38, 84);
            this.panLista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panLista.Name = "panLista";
            this.panLista.Size = new System.Drawing.Size(232, 335);
            this.panLista.TabIndex = 2;
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.Sienna;
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(53, 265);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(96, 28);
            this.btnVerify.TabIndex = 1;
            this.btnVerify.Text = "Verifica";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your score:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkIngrediente
            // 
            this.chkIngrediente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkIngrediente.FormattingEnabled = true;
            this.chkIngrediente.Location = new System.Drawing.Point(15, 37);
            this.chkIngrediente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkIngrediente.Name = "chkIngrediente";
            this.chkIngrediente.Size = new System.Drawing.Size(201, 208);
            this.chkIngrediente.TabIndex = 1;
            this.chkIngrediente.SelectedIndexChanged += new System.EventHandler(this.chkIngrediente_SelectedIndexChanged);
            // 
            // lblScor
            // 
            this.lblScor.AutoSize = true;
            this.lblScor.BackColor = System.Drawing.Color.White;
            this.lblScor.ForeColor = System.Drawing.Color.Black;
            this.lblScor.Location = new System.Drawing.Point(154, 423);
            this.lblScor.Name = "lblScor";
            this.lblScor.Size = new System.Drawing.Size(15, 16);
            this.lblScor.TabIndex = 4;
            this.lblScor.Text = "0";
            this.lblScor.Click += new System.EventHandler(this.lblScor_Click);
            // 
            // lstAlese
            // 
            this.lstAlese.FormattingEnabled = true;
            this.lstAlese.ItemHeight = 16;
            this.lstAlese.Location = new System.Drawing.Point(240, 1);
            this.lstAlese.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstAlese.Name = "lstAlese";
            this.lstAlese.Size = new System.Drawing.Size(91, 36);
            this.lstAlese.TabIndex = 3;
            this.lstAlese.Visible = false;
            // 
            // panImg
            // 
            this.panImg.BackColor = System.Drawing.Color.Transparent;
            this.panImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panImg.Location = new System.Drawing.Point(374, 31);
            this.panImg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panImg.Name = "panImg";
            this.panImg.Size = new System.Drawing.Size(530, 555);
            this.panImg.TabIndex = 2;
            this.panImg.Paint += new System.Windows.Forms.PaintEventHandler(this.panImg_Paint);
            // 
            // cboRetete
            // 
            this.cboRetete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRetete.FormattingEnabled = true;
            this.cboRetete.Location = new System.Drawing.Point(38, 57);
            this.cboRetete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboRetete.Name = "cboRetete";
            this.cboRetete.Size = new System.Drawing.Size(256, 24);
            this.cboRetete.TabIndex = 4;
            this.cboRetete.SelectedIndexChanged += new System.EventHandler(this.cboRetete_SelectedIndexChanged);
            // 
            // pbFinal
            // 
            this.pbFinal.BackColor = System.Drawing.Color.Transparent;
            this.pbFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFinal.Location = new System.Drawing.Point(53, 482);
            this.pbFinal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbFinal.Name = "pbFinal";
            this.pbFinal.Size = new System.Drawing.Size(179, 105);
            this.pbFinal.TabIndex = 5;
            this.pbFinal.TabStop = false;
            this.pbFinal.Click += new System.EventHandler(this.pbFinal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 47);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelInstructiuni
            // 
            this.panelInstructiuni.BackColor = System.Drawing.Color.Transparent;
            this.panelInstructiuni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelInstructiuni.BackgroundImage")));
            this.panelInstructiuni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelInstructiuni.Controls.Add(this.pictureBoxEN);
            this.panelInstructiuni.Controls.Add(this.lblExit);
            this.panelInstructiuni.Controls.Add(this.pictureBoxRO);
            this.panelInstructiuni.Controls.Add(this.lblIEngleza);
            this.panelInstructiuni.Controls.Add(this.lblIRomana);
            this.panelInstructiuni.Location = new System.Drawing.Point(38, 1);
            this.panelInstructiuni.Name = "panelInstructiuni";
            this.panelInstructiuni.Size = new System.Drawing.Size(309, 200);
            this.panelInstructiuni.TabIndex = 7;
            this.panelInstructiuni.Visible = false;
            // 
            // pictureBoxEN
            // 
            this.pictureBoxEN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEN.BackgroundImage")));
            this.pictureBoxEN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxEN.Location = new System.Drawing.Point(48, 116);
            this.pictureBoxEN.Name = "pictureBoxEN";
            this.pictureBoxEN.Size = new System.Drawing.Size(29, 24);
            this.pictureBoxEN.TabIndex = 3;
            this.pictureBoxEN.TabStop = false;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Red;
            this.lblExit.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(291, 8);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(15, 16);
            this.lblExit.TabIndex = 2;
            this.lblExit.Text = "x";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // pictureBoxRO
            // 
            this.pictureBoxRO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRO.BackgroundImage")));
            this.pictureBoxRO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRO.Location = new System.Drawing.Point(48, 16);
            this.pictureBoxRO.Name = "pictureBoxRO";
            this.pictureBoxRO.Size = new System.Drawing.Size(29, 24);
            this.pictureBoxRO.TabIndex = 2;
            this.pictureBoxRO.TabStop = false;
            // 
            // lblIEngleza
            // 
            this.lblIEngleza.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIEngleza.ForeColor = System.Drawing.Color.Black;
            this.lblIEngleza.Location = new System.Drawing.Point(86, 102);
            this.lblIEngleza.Name = "lblIEngleza";
            this.lblIEngleza.Size = new System.Drawing.Size(202, 103);
            this.lblIEngleza.TabIndex = 1;
            this.lblIEngleza.Text = "Select the dish you want and then choose the correct ingredients entering its com" +
    "position, they are mentioned on the shopping list.";
            // 
            // lblIRomana
            // 
            this.lblIRomana.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRomana.ForeColor = System.Drawing.Color.Black;
            this.lblIRomana.Location = new System.Drawing.Point(83, 16);
            this.lblIRomana.Name = "lblIRomana";
            this.lblIRomana.Size = new System.Drawing.Size(202, 104);
            this.lblIRomana.TabIndex = 0;
            this.lblIRomana.Text = "Selecteaza felul de mancare dorit apoi alege alimentele corecte care intra in com" +
    "pozitia acestuia ;ele sunt mentionate pe lista de cumparaturi .";
            // 
            // LblIesire
            // 
            this.LblIesire.AutoSize = true;
            this.LblIesire.BackColor = System.Drawing.Color.Red;
            this.LblIesire.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIesire.ForeColor = System.Drawing.Color.White;
            this.LblIesire.Location = new System.Drawing.Point(879, 0);
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
            this.lblBest.ForeColor = System.Drawing.Color.Black;
            this.lblBest.Location = new System.Drawing.Point(538, 5);
            this.lblBest.Name = "lblBest";
            this.lblBest.Size = new System.Drawing.Size(81, 16);
            this.lblBest.TabIndex = 4;
            this.lblBest.Text = "Your score:";
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelInstructiuni);
            this.Controls.Add(this.lblScor);
            this.Controls.Add(this.pbFinal);
            this.Controls.Add(this.panImg);
            this.Controls.Add(this.lblBest);
            this.Controls.Add(this.LblIesire);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panLista);
            this.Controls.Add(this.cboRetete);
            this.Controls.Add(this.lstAlese);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panLista.ResumeLayout(false);
            this.panLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelInstructiuni.ResumeLayout(false);
            this.panelInstructiuni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panLista;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.CheckedListBox chkIngrediente;
        private System.Windows.Forms.ListBox lstAlese;
        private System.Windows.Forms.Panel panImg;
        private System.Windows.Forms.Label lblScor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboRetete;
        private System.Windows.Forms.PictureBox pbFinal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelInstructiuni;
        private System.Windows.Forms.PictureBox pictureBoxEN;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.PictureBox pictureBoxRO;
        private System.Windows.Forms.Label lblIEngleza;
        private System.Windows.Forms.Label lblIRomana;
        private System.Windows.Forms.Label LblIesire;
        private System.Windows.Forms.Label lblBest;
    }
}

