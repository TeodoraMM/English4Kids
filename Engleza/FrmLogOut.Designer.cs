namespace Engleza
{
    partial class FrmLogOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogOut));
            this.lblLogOut = new System.Windows.Forms.Label();
            this.lblMotto = new System.Windows.Forms.Label();
            this.lblPA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.BackColor = System.Drawing.Color.Transparent;
            this.lblLogOut.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.Color.Black;
            this.lblLogOut.Location = new System.Drawing.Point(41, 78);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(393, 23);
            this.lblLogOut.TabIndex = 0;
            this.lblLogOut.Text = "Iti multumim ca ai folosit aplicatia English 4 Kids \r\n";
            // 
            // lblMotto
            // 
            this.lblMotto.BackColor = System.Drawing.Color.Transparent;
            this.lblMotto.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotto.ForeColor = System.Drawing.Color.Black;
            this.lblMotto.Location = new System.Drawing.Point(41, 146);
            this.lblMotto.Name = "lblMotto";
            this.lblMotto.Size = new System.Drawing.Size(494, 97);
            this.lblMotto.TabIndex = 1;
            this.lblMotto.Text = "\"Educaţia este paşaportul nostru pentru viitor, căci ziua de mâine aparţine celor" +
    " care se pregătesc pentru ea de astăzi.\"       - Malcolm X\r\n";
            // 
            // lblPA
            // 
            this.lblPA.AutoSize = true;
            this.lblPA.Location = new System.Drawing.Point(429, 467);
            this.lblPA.Name = "lblPA";
            this.lblPA.Size = new System.Drawing.Size(0, 13);
            this.lblPA.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 99);
            this.label1.TabIndex = 4;
            this.label1.Text = " Speram ca aceasta aplicatie te-a ajutat in invatarea limbi engleze si te-a motiv" +
    "at sa-ti doresti mai mult sa cunosti limba engleza intr-un mod interactiv si uso" +
    "r de folosit\r\n";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.BackColor = System.Drawing.Color.Red;
            this.lblX.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.Color.White;
            this.lblX.Location = new System.Drawing.Point(532, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(23, 23);
            this.lblX.TabIndex = 19;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // FrmLogOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(567, 425);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPA);
            this.Controls.Add(this.lblMotto);
            this.Controls.Add(this.lblLogOut);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmLogOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.Label lblMotto;
        private System.Windows.Forms.Label lblPA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblX;
    }
}