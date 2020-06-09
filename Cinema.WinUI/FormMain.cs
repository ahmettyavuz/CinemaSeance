using Cinema.WinUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSeans.UI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        
        private void biletKesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormTicketAdd>();
        }

        private void filmListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormMovieAdd>();
        }

        private void filmListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormMovieList>();
        }

        private void oyuncuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormCastAdd>();
        }

        private void oyuncuListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormCastList>();
        }

        private void yönetmenEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormDirectorAdd>();
        }

        private void seansEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormSeansAdd>();
        }

        private void TsbChangeUser_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Hide();
        }

        private void TsbQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormUserAdd>();
        }

        private void KullanıcıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormUserList>();
        }

        private void ŞifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormPasswordChange>();
        }

        private void seansListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormSeanceList>();
        }

        private void yönetmenListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormDirectorList>();
        }

        private void SalonEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormTheaterAdd>();
        }

        private void SalonlarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormTheaterList>();
        }
    }
}
