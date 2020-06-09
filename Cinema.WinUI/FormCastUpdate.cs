using Cinema.BLL;
using Cinema.DTO;
using Framework.Core;
using Framework.WinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.WinUI
{
    public partial class FormCastUpdate : Form
    {
        CastDTO _cast;
        CastController _cc;
        //public static event Event1 CastUpdated;
        public FormCastUpdate(CastDTO cast)
        {
            InitializeComponent();
            _cast = cast;
            _cc = new CastController();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region Validation
            if (!TextBoxExtension.NotNullOrWhiteSpace(txtFirstName, "Oyuncu ad bilgisi boş geçilemez!"))
            {
                return;
            }

            if (!TextBoxExtension.NotNullOrWhiteSpace(txtLastName, "Oyuncu soyad bilgisi boş geçilemez!"))
            {
                return;
            }
            #endregion

            _cast.FirstName = txtFirstName.Text;
            _cast.LastName = txtLastName.Text;

            var result = _cc.CastUpdate(_cast);

            result.NotificationShow();

            if (result.State == ResultState.Success)
            {
                //CastUpdated.Raise();
                this.Close();
            }
        }

        private void FormCastUpdate_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = _cast.FirstName;
            txtLastName.Text = _cast.LastName;
        }
    }
}
