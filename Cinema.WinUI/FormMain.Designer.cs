namespace CinemaSeans.UI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletKesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmListesiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oyuncuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oyuncuEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oyuncuListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yönetmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yönetmenEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yönetmenListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seansListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seansEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tsbQuit = new System.Windows.Forms.ToolStripButton();
            this.tsbChangeUser = new System.Windows.Forms.ToolStripButton();
            this.salonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonlarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem,
            this.biletToolStripMenuItem,
            this.filmEkleToolStripMenuItem,
            this.oyuncuToolStripMenuItem,
            this.yönetmenToolStripMenuItem,
            this.seansToolStripMenuItem,
            this.salonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(668, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıEkleToolStripMenuItem,
            this.kullanıcıListeleToolStripMenuItem,
            this.şifreDeğiştirToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // kullanıcıEkleToolStripMenuItem
            // 
            this.kullanıcıEkleToolStripMenuItem.Name = "kullanıcıEkleToolStripMenuItem";
            this.kullanıcıEkleToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.kullanıcıEkleToolStripMenuItem.Text = "Kullanıcı Ekle";
            this.kullanıcıEkleToolStripMenuItem.Click += new System.EventHandler(this.KullanıcıEkleToolStripMenuItem_Click);
            // 
            // kullanıcıListeleToolStripMenuItem
            // 
            this.kullanıcıListeleToolStripMenuItem.Name = "kullanıcıListeleToolStripMenuItem";
            this.kullanıcıListeleToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.kullanıcıListeleToolStripMenuItem.Text = "Kullanıcı Listele";
            this.kullanıcıListeleToolStripMenuItem.Click += new System.EventHandler(this.KullanıcıListeleToolStripMenuItem_Click);
            // 
            // şifreDeğiştirToolStripMenuItem
            // 
            this.şifreDeğiştirToolStripMenuItem.Name = "şifreDeğiştirToolStripMenuItem";
            this.şifreDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.şifreDeğiştirToolStripMenuItem.Text = "Şifre Değiştir";
            this.şifreDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.ŞifreDeğiştirToolStripMenuItem_Click);
            // 
            // biletToolStripMenuItem
            // 
            this.biletToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biletKesToolStripMenuItem,
            this.biletListesiToolStripMenuItem});
            this.biletToolStripMenuItem.Name = "biletToolStripMenuItem";
            this.biletToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.biletToolStripMenuItem.Text = "Bilet";
            // 
            // biletKesToolStripMenuItem
            // 
            this.biletKesToolStripMenuItem.Name = "biletKesToolStripMenuItem";
            this.biletKesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.biletKesToolStripMenuItem.Text = "Bilet Kes";
            this.biletKesToolStripMenuItem.Click += new System.EventHandler(this.biletKesToolStripMenuItem_Click);
            // 
            // biletListesiToolStripMenuItem
            // 
            this.biletListesiToolStripMenuItem.Name = "biletListesiToolStripMenuItem";
            this.biletListesiToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.biletListesiToolStripMenuItem.Text = "Bilet Listesi";
            // 
            // filmEkleToolStripMenuItem
            // 
            this.filmEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmListesiToolStripMenuItem,
            this.filmListesiToolStripMenuItem1});
            this.filmEkleToolStripMenuItem.Name = "filmEkleToolStripMenuItem";
            this.filmEkleToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filmEkleToolStripMenuItem.Text = "Film";
            // 
            // filmListesiToolStripMenuItem
            // 
            this.filmListesiToolStripMenuItem.Name = "filmListesiToolStripMenuItem";
            this.filmListesiToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.filmListesiToolStripMenuItem.Text = "Film Ekle";
            this.filmListesiToolStripMenuItem.Click += new System.EventHandler(this.filmListesiToolStripMenuItem_Click);
            // 
            // filmListesiToolStripMenuItem1
            // 
            this.filmListesiToolStripMenuItem1.Name = "filmListesiToolStripMenuItem1";
            this.filmListesiToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.filmListesiToolStripMenuItem1.Text = "Film Listesi";
            this.filmListesiToolStripMenuItem1.Click += new System.EventHandler(this.filmListesiToolStripMenuItem1_Click);
            // 
            // oyuncuToolStripMenuItem
            // 
            this.oyuncuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oyuncuEkleToolStripMenuItem,
            this.oyuncuListesiToolStripMenuItem});
            this.oyuncuToolStripMenuItem.Name = "oyuncuToolStripMenuItem";
            this.oyuncuToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.oyuncuToolStripMenuItem.Text = "Oyuncu";
            // 
            // oyuncuEkleToolStripMenuItem
            // 
            this.oyuncuEkleToolStripMenuItem.Name = "oyuncuEkleToolStripMenuItem";
            this.oyuncuEkleToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.oyuncuEkleToolStripMenuItem.Text = "Oyuncu Ekle";
            this.oyuncuEkleToolStripMenuItem.Click += new System.EventHandler(this.oyuncuEkleToolStripMenuItem_Click);
            // 
            // oyuncuListesiToolStripMenuItem
            // 
            this.oyuncuListesiToolStripMenuItem.Name = "oyuncuListesiToolStripMenuItem";
            this.oyuncuListesiToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.oyuncuListesiToolStripMenuItem.Text = "Oyuncu Listesi";
            this.oyuncuListesiToolStripMenuItem.Click += new System.EventHandler(this.oyuncuListesiToolStripMenuItem_Click);
            // 
            // yönetmenToolStripMenuItem
            // 
            this.yönetmenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yönetmenEkleToolStripMenuItem,
            this.yönetmenListesiToolStripMenuItem});
            this.yönetmenToolStripMenuItem.Name = "yönetmenToolStripMenuItem";
            this.yönetmenToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.yönetmenToolStripMenuItem.Text = "Yönetmen";
            // 
            // yönetmenEkleToolStripMenuItem
            // 
            this.yönetmenEkleToolStripMenuItem.Name = "yönetmenEkleToolStripMenuItem";
            this.yönetmenEkleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.yönetmenEkleToolStripMenuItem.Text = "Yönetmen Ekle";
            this.yönetmenEkleToolStripMenuItem.Click += new System.EventHandler(this.yönetmenEkleToolStripMenuItem_Click);
            // 
            // yönetmenListesiToolStripMenuItem
            // 
            this.yönetmenListesiToolStripMenuItem.Name = "yönetmenListesiToolStripMenuItem";
            this.yönetmenListesiToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.yönetmenListesiToolStripMenuItem.Text = "Yönetmen Listesi";
            this.yönetmenListesiToolStripMenuItem.Click += new System.EventHandler(this.yönetmenListesiToolStripMenuItem_Click);
            // 
            // seansToolStripMenuItem
            // 
            this.seansToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seansListesiToolStripMenuItem,
            this.seansEkleToolStripMenuItem});
            this.seansToolStripMenuItem.Name = "seansToolStripMenuItem";
            this.seansToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.seansToolStripMenuItem.Text = "Seans";
            // 
            // seansListesiToolStripMenuItem
            // 
            this.seansListesiToolStripMenuItem.Name = "seansListesiToolStripMenuItem";
            this.seansListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seansListesiToolStripMenuItem.Text = "Seans Listesi";
            this.seansListesiToolStripMenuItem.Click += new System.EventHandler(this.seansListesiToolStripMenuItem_Click);
            // 
            // seansEkleToolStripMenuItem
            // 
            this.seansEkleToolStripMenuItem.Name = "seansEkleToolStripMenuItem";
            this.seansEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seansEkleToolStripMenuItem.Text = "Seans Ekle";
            this.seansEkleToolStripMenuItem.Click += new System.EventHandler(this.seansEkleToolStripMenuItem_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbQuit,
            this.tsbChangeUser});
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMain.Size = new System.Drawing.Size(668, 27);
            this.toolStripMain.TabIndex = 3;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // tsbQuit
            // 
            this.tsbQuit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbQuit.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuit.Image")));
            this.tsbQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuit.Name = "tsbQuit";
            this.tsbQuit.Size = new System.Drawing.Size(24, 24);
            this.tsbQuit.Text = "Çıkış";
            this.tsbQuit.Click += new System.EventHandler(this.TsbQuit_Click);
            // 
            // tsbChangeUser
            // 
            this.tsbChangeUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbChangeUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbChangeUser.Image = ((System.Drawing.Image)(resources.GetObject("tsbChangeUser.Image")));
            this.tsbChangeUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChangeUser.Name = "tsbChangeUser";
            this.tsbChangeUser.Size = new System.Drawing.Size(24, 24);
            this.tsbChangeUser.Text = "Kullanıcı Değiştir";
            this.tsbChangeUser.Click += new System.EventHandler(this.TsbChangeUser_Click);
            // 
            // salonToolStripMenuItem
            // 
            this.salonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salonEkleToolStripMenuItem,
            this.salonlarıListeleToolStripMenuItem});
            this.salonToolStripMenuItem.Name = "salonToolStripMenuItem";
            this.salonToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.salonToolStripMenuItem.Text = "Salon";
            // 
            // salonEkleToolStripMenuItem
            // 
            this.salonEkleToolStripMenuItem.Name = "salonEkleToolStripMenuItem";
            this.salonEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salonEkleToolStripMenuItem.Text = "Salon Ekle";
            this.salonEkleToolStripMenuItem.Click += new System.EventHandler(this.SalonEkleToolStripMenuItem_Click);
            // 
            // salonlarıListeleToolStripMenuItem
            // 
            this.salonlarıListeleToolStripMenuItem.Name = "salonlarıListeleToolStripMenuItem";
            this.salonlarıListeleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salonlarıListeleToolStripMenuItem.Text = "Salonları Listele";
            this.salonlarıListeleToolStripMenuItem.Click += new System.EventHandler(this.SalonlarıListeleToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 405);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Ana Ekran";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filmEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmListesiToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletKesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbQuit;
        private System.Windows.Forms.ToolStripButton tsbChangeUser;
        private System.Windows.Forms.ToolStripMenuItem oyuncuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oyuncuEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oyuncuListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yönetmenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yönetmenEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yönetmenListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seansListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seansEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salonEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salonlarıListeleToolStripMenuItem;
    }
}