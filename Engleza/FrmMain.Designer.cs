namespace Engleza
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dictionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cautăCuvântToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cautăCuvântToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letsLearnAboutColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letsCookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dressUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hangmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bibliografieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bibliographyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblutilizator = new System.Windows.Forms.Label();
            this.pbSound = new System.Windows.Forms.PictureBox();
            this.loginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSound)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.dictionarToolStripMenuItem,
            this.colorsToolStripMenuItem,
            this.bibliografieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1258, 37);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuPrincipal";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signInToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.loginToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(120, 33);
            this.loginToolStripMenuItem.Text = "Account";
            // 
            // signInToolStripMenuItem
            // 
            this.signInToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.signInToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.signInToolStripMenuItem.Name = "signInToolStripMenuItem";
            this.signInToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.signInToolStripMenuItem.Text = "Sign in";
            this.signInToolStripMenuItem.Click += new System.EventHandler(this.signInToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.signOutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.signOutToolStripMenuItem.Text = "Sign out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(85, 33);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // dictionarToolStripMenuItem
            // 
            this.dictionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrareToolStripMenuItem,
            this.cautăCuvântToolStripMenuItem,
            this.cautăCuvântToolStripMenuItem1});
            this.dictionarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dictionarToolStripMenuItem.Name = "dictionarToolStripMenuItem";
            this.dictionarToolStripMenuItem.Size = new System.Drawing.Size(135, 33);
            this.dictionarToolStripMenuItem.Text = "Dictionary";
            this.dictionarToolStripMenuItem.Click += new System.EventHandler(this.dictionarToolStripMenuItem_Click_1);
            // 
            // administrareToolStripMenuItem
            // 
            this.administrareToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.administrareToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.administrareToolStripMenuItem.Name = "administrareToolStripMenuItem";
            this.administrareToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.administrareToolStripMenuItem.Text = "Administration";
            this.administrareToolStripMenuItem.Click += new System.EventHandler(this.administrareToolStripMenuItem_Click);
            // 
            // cautăCuvântToolStripMenuItem
            // 
            this.cautăCuvântToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.cautăCuvântToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cautăCuvântToolStripMenuItem.Name = "cautăCuvântToolStripMenuItem";
            this.cautăCuvântToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.cautăCuvântToolStripMenuItem.Text = "Illustatrated Dictionary";
            this.cautăCuvântToolStripMenuItem.Click += new System.EventHandler(this.cautăCuvântToolStripMenuItem_Click);
            // 
            // cautăCuvântToolStripMenuItem1
            // 
            this.cautăCuvântToolStripMenuItem1.BackColor = System.Drawing.Color.DimGray;
            this.cautăCuvântToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.cautăCuvântToolStripMenuItem1.Name = "cautăCuvântToolStripMenuItem1";
            this.cautăCuvântToolStripMenuItem1.Size = new System.Drawing.Size(335, 34);
            this.cautăCuvântToolStripMenuItem1.Text = "Search Word";
            this.cautăCuvântToolStripMenuItem1.Click += new System.EventHandler(this.cautăCuvântToolStripMenuItem1_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.letsLearnAboutColorsToolStripMenuItem,
            this.letsCookToolStripMenuItem,
            this.dressUpToolStripMenuItem,
            this.numbersToolStripMenuItem,
            this.clockToolStripMenuItem,
            this.hangmanToolStripMenuItem});
            this.colorsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(94, 33);
            this.colorsToolStripMenuItem.Text = "Games";
            this.colorsToolStripMenuItem.Click += new System.EventHandler(this.colorsToolStripMenuItem_Click);
            // 
            // letsLearnAboutColorsToolStripMenuItem
            // 
            this.letsLearnAboutColorsToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.letsLearnAboutColorsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.letsLearnAboutColorsToolStripMenuItem.Name = "letsLearnAboutColorsToolStripMenuItem";
            this.letsLearnAboutColorsToolStripMenuItem.Size = new System.Drawing.Size(339, 34);
            this.letsLearnAboutColorsToolStripMenuItem.Text = "Let\'s learn about colors!";
            this.letsLearnAboutColorsToolStripMenuItem.Click += new System.EventHandler(this.letsLearnAboutColorsToolStripMenuItem_Click);
            // 
            // letsCookToolStripMenuItem
            // 
            this.letsCookToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.letsCookToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.letsCookToolStripMenuItem.Name = "letsCookToolStripMenuItem";
            this.letsCookToolStripMenuItem.Size = new System.Drawing.Size(339, 34);
            this.letsCookToolStripMenuItem.Text = "Let\'s cook!";
            this.letsCookToolStripMenuItem.Click += new System.EventHandler(this.letsCookToolStripMenuItem_Click);
            // 
            // dressUpToolStripMenuItem
            // 
            this.dressUpToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.dressUpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girlToolStripMenuItem,
            this.boyToolStripMenuItem});
            this.dressUpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dressUpToolStripMenuItem.Name = "dressUpToolStripMenuItem";
            this.dressUpToolStripMenuItem.Size = new System.Drawing.Size(339, 34);
            this.dressUpToolStripMenuItem.Text = "Dress up ";
            // 
            // girlToolStripMenuItem
            // 
            this.girlToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.girlToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.girlToolStripMenuItem.Name = "girlToolStripMenuItem";
            this.girlToolStripMenuItem.Size = new System.Drawing.Size(125, 34);
            this.girlToolStripMenuItem.Text = "Girl";
            this.girlToolStripMenuItem.Click += new System.EventHandler(this.girlToolStripMenuItem_Click_1);
            // 
            // boyToolStripMenuItem
            // 
            this.boyToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.boyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.boyToolStripMenuItem.Name = "boyToolStripMenuItem";
            this.boyToolStripMenuItem.Size = new System.Drawing.Size(125, 34);
            this.boyToolStripMenuItem.Text = "Boy";
            this.boyToolStripMenuItem.Click += new System.EventHandler(this.boyToolStripMenuItem_Click_1);
            // 
            // numbersToolStripMenuItem
            // 
            this.numbersToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.numbersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.numbersToolStripMenuItem.Name = "numbersToolStripMenuItem";
            this.numbersToolStripMenuItem.Size = new System.Drawing.Size(339, 34);
            this.numbersToolStripMenuItem.Text = "Numbers";
            this.numbersToolStripMenuItem.Click += new System.EventHandler(this.numbersToolStripMenuItem_Click);
            // 
            // clockToolStripMenuItem
            // 
            this.clockToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.clockToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.clockToolStripMenuItem.Name = "clockToolStripMenuItem";
            this.clockToolStripMenuItem.Size = new System.Drawing.Size(339, 34);
            this.clockToolStripMenuItem.Text = "Clock";
            this.clockToolStripMenuItem.Click += new System.EventHandler(this.clockToolStripMenuItem_Click);
            // 
            // hangmanToolStripMenuItem
            // 
            this.hangmanToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.hangmanToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.hangmanToolStripMenuItem.Name = "hangmanToolStripMenuItem";
            this.hangmanToolStripMenuItem.Size = new System.Drawing.Size(339, 34);
            this.hangmanToolStripMenuItem.Text = "Hangman";
            this.hangmanToolStripMenuItem.Click += new System.EventHandler(this.hangmanToolStripMenuItem_Click);
            // 
            // bibliografieToolStripMenuItem
            // 
            this.bibliografieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.questionsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.bibliographyToolStripMenuItem});
            this.bibliografieToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bibliografieToolStripMenuItem.Name = "bibliografieToolStripMenuItem";
            this.bibliografieToolStripMenuItem.Size = new System.Drawing.Size(94, 33);
            this.bibliografieToolStripMenuItem.Text = "About";
            this.bibliografieToolStripMenuItem.Click += new System.EventHandler(this.bibliografieToolStripMenuItem_Click);
            // 
            // questionsToolStripMenuItem
            // 
            this.questionsToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.questionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.questionsToolStripMenuItem.Name = "questionsToolStripMenuItem";
            this.questionsToolStripMenuItem.Size = new System.Drawing.Size(211, 34);
            this.questionsToolStripMenuItem.Text = "Questions";
            this.questionsToolStripMenuItem.Click += new System.EventHandler(this.questionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(211, 34);
            this.aboutToolStripMenuItem.Text = "About us";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // bibliographyToolStripMenuItem
            // 
            this.bibliographyToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.bibliographyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bibliographyToolStripMenuItem.Name = "bibliographyToolStripMenuItem";
            this.bibliographyToolStripMenuItem.Size = new System.Drawing.Size(211, 34);
            this.bibliographyToolStripMenuItem.Text = "Bibliography";
            this.bibliographyToolStripMenuItem.Click += new System.EventHandler(this.bibliographyToolStripMenuItem_Click);
            // 
            // lblutilizator
            // 
            this.lblutilizator.AutoSize = true;
            this.lblutilizator.Location = new System.Drawing.Point(879, 17);
            this.lblutilizator.Name = "lblutilizator";
            this.lblutilizator.Size = new System.Drawing.Size(106, 15);
            this.lblutilizator.TabIndex = 16;
            this.lblutilizator.Text = "Utilizator: Anonim";
            this.lblutilizator.Visible = false;
            this.lblutilizator.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // pbSound
            // 
            this.pbSound.Image = ((System.Drawing.Image)(resources.GetObject("pbSound.Image")));
            this.pbSound.Location = new System.Drawing.Point(547, 0);
            this.pbSound.Name = "pbSound";
            this.pbSound.Size = new System.Drawing.Size(34, 37);
            this.pbSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSound.TabIndex = 18;
            this.pbSound.TabStop = false;
            this.pbSound.Click += new System.EventHandler(this.pbSound_Click);
            // 
            // loginToolStripMenuItem1
            // 
            this.loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            this.loginToolStripMenuItem1.Size = new System.Drawing.Size(172, 34);
            this.loginToolStripMenuItem1.Text = "Sign in";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.logoutToolStripMenuItem.Text = "Sign out";
            // 
            // signUpToolStripMenuItem
            // 
            this.signUpToolStripMenuItem.Name = "signUpToolStripMenuItem";
            this.signUpToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.signUpToolStripMenuItem.Text = "Sign up";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 746);
            this.Controls.Add(this.pbSound);
            this.Controls.Add(this.lblutilizator);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        public System.Windows.Forms.Label lblutilizator;
        private System.Windows.Forms.ToolStripMenuItem dictionarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbSound;
        private System.Windows.Forms.ToolStripMenuItem administrareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cautăCuvântToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cautăCuvântToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bibliografieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letsLearnAboutColorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letsCookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hangmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dressUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bibliographyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clockToolStripMenuItem;
    }
}

