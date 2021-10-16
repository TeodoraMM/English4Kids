namespace Engleza
{
    partial class FrmLog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLog));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtparola = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblStare = new System.Windows.Forms.Label();
            this.pictureBoxEN = new System.Windows.Forms.PictureBox();
            this.pictureBoxRO = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 4;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 51);
            this.label4.TabIndex = 7;
            this.label4.Text = "Te rog introdu-ti numele :\r\n\r\nPlease enter your name:";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtname.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(72, 125);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(131, 33);
            this.txtname.TabIndex = 8;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(94, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 54);
            this.button3.TabIndex = 12;
            this.button3.Text = "Go";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Kristen ITC", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(923, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 51);
            this.label6.TabIndex = 13;
            this.label6.Text = "English 4 Kids";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtparola
            // 
            this.txtparola.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtparola.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtparola.Location = new System.Drawing.Point(72, 244);
            this.txtparola.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtparola.Name = "txtparola";
            this.txtparola.PasswordChar = '*';
            this.txtparola.Size = new System.Drawing.Size(131, 33);
            this.txtparola.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 51);
            this.label7.TabIndex = 17;
            this.label7.Text = "Te rog introdu-ti parola :\r\n\r\nPlease enter your password:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.BackColor = System.Drawing.Color.Red;
            this.lblX.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.Color.White;
            this.lblX.Location = new System.Drawing.Point(244, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(23, 23);
            this.lblX.TabIndex = 18;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // lblStare
            // 
            this.lblStare.BackColor = System.Drawing.Color.Transparent;
            this.lblStare.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStare.Location = new System.Drawing.Point(12, 341);
            this.lblStare.Name = "lblStare";
            this.lblStare.Size = new System.Drawing.Size(244, 65);
            this.lblStare.TabIndex = 17;
            this.lblStare.Text = "Disconected";
            this.lblStare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxEN
            // 
            this.pictureBoxEN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEN.BackgroundImage")));
            this.pictureBoxEN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxEN.Location = new System.Drawing.Point(12, 89);
            this.pictureBoxEN.Name = "pictureBoxEN";
            this.pictureBoxEN.Size = new System.Drawing.Size(29, 24);
            this.pictureBoxEN.TabIndex = 20;
            this.pictureBoxEN.TabStop = false;
            // 
            // pictureBoxRO
            // 
            this.pictureBoxRO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRO.BackgroundImage")));
            this.pictureBoxRO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRO.Location = new System.Drawing.Point(12, 59);
            this.pictureBoxRO.Name = "pictureBoxRO";
            this.pictureBoxRO.Size = new System.Drawing.Size(29, 24);
            this.pictureBoxRO.TabIndex = 19;
            this.pictureBoxRO.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 24);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 172);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 24);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(270, 415);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxEN);
            this.Controls.Add(this.pictureBoxRO);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblStare);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtparola);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogincs";
            this.Load += new System.EventHandler(this.FrmLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtparola;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblStare;
        private System.Windows.Forms.PictureBox pictureBoxEN;
        private System.Windows.Forms.PictureBox pictureBoxRO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}