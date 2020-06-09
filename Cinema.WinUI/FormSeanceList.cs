using Cinema.BLL;
using Cinema.DTO;
using Framework.Core;
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
    public partial class FormSeanceList : Form
    {
        SeanceController _sc;
        public FormSeanceList()
        {
            InitializeComponent();
            _sc = new SeanceController();
        }

        private void FormSeanceList_Load(object sender, EventArgs e)
        {
            ListLoad();
        }
        private void ListLoad()
        {
            List<SeanceDTO> seances = _sc.TumSeanslariVer();
            lstSeance.DataSource = null;
            lstSeance.DisplayMember = "SeanceInformation";
            lstSeance.ValueMember = "Id";
            lstSeance.DataSource = seances;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstSeance.SelectedIndex == -1)
            {
                MessageBox.Show("Bir seans seçmelisiniz.");
                return;
            }
            var seance = (SeanceDTO)lstSeance.SelectedItem;
            FormExtension.MdiBroShow<FormSeansUpdate, SeanceDTO>(this, seance);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var seance = (SeanceDTO)lstSeance.SelectedItem;

            var result = _sc.SeansSil(seance);
            result.NotificationShow();
            if (result.State == ResultState.Success)
            {
                ListLoad();
            }
        }
    }
}
