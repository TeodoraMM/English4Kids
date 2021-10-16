namespace Engleza
{
    partial class frmMessageboxOk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageboxOk));
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.LblIesire = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMesaj
            // 
            this.lblMesaj.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaj.Location = new System.Drawing.Point(48, 61);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(224, 93);
            this.lblMesaj.TabIndex = 48;
            this.lblMesaj.Text = "label1";
            this.lblMesaj.Click += new System.EventHandler(this.lblMesaj_Click);
            // 
            // btnYes
            // 
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(92, 189);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 47;
            this.btnYes.Text = "Ok";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // LblIesire
            // 
            this.LblIesire.AutoSize = true;
            this.LblIesire.BackColor = System.Drawing.Color.Red;
            this.LblIesire.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIesire.ForeColor = System.Drawing.Color.White;
            this.LblIesire.Location = new System.Drawing.Point(262, 0);
            this.LblIesire.Name = "LblIesire";
            this.LblIesire.Size = new System.Drawing.Size(22, 22);
            this.LblIesire.TabIndex = 45;
            this.LblIesire.Text = "X";
            this.LblIesire.Click += new System.EventHandler(this.LblIesire_Click);
            // 
            // frmMessageboxOk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.LblIesire);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMessageboxOk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMessageboxOk";
            this.Load += new System.EventHandler(this.frmMessageboxOk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label LblIesire;
    }
}