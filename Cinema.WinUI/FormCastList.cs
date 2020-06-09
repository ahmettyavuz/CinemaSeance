using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema.BLL;
using Cinema.DTO;
using CinemaSeans.UI;
using Framework.Core;
using Framework.WinForm;

namespace Cinema.WinUI
{
    public partial class FormCastList : Form
    {
        CastController _cc;
        public FormCastList()
        {
            InitializeComponent();
            _cc = new CastController();
            this.Load += OyuncuListesi;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region Validation
            if (lstCasts.SelectedIndex < 0)
            {
                MessageBox.Show("Güncellemek için listeden oyuncu seçiniz");
            }
            #endregion

            var dto = (CastDTO)lstCasts.SelectedItem;

            FormCastUpdate frm = new FormCastUpdate(dto);

            frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.MdiBroShow<FormCastAdd>();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            #region Validation
            if (lstCasts.SelectedIndex < 0)
            {
                MessageBox.Show("Silmek için listeden oyuncu seçiniz");
            }
            #endregion

            var dto = (CastDTO)lstCasts.SelectedItem;

            var result = _cc.CastDelete(dto);

            result.NotificationShow();

            if (result.State == ResultState.Success)
            {
                this.Load += OyuncuListesi;
            }
        }

        private void OyuncuListesi(object sender , EventArgs e)
        {
            
        }

        private void FormCastList_Load(object sender, EventArgs e)
        {
            List<CastDTO> dtos = _cc.GetAllCasts();
            lstCasts.DataSourceMember<List<CastDTO>>("FullName", "Id", dtos);
        }

    }
}
