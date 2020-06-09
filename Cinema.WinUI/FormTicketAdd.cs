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
    public partial class FormTicketAdd : Form
    {
        public FormTicketAdd()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            FormSales frm = new FormSales();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
