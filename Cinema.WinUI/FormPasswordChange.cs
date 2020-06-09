using Cinema.BLL;
using Cinema.DTO.SessionHelper;
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
    public partial class FormPasswordChange : Form
    {
        UserController _uc;
        public FormPasswordChange()
        {
            InitializeComponent();
            _uc = new UserController();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            #region Validation
            if (txtOldPass.Text != SessionHelper.CurrentUser.Password.ToString())
            {
                MessageBox.Show("Eski şifre hatalı..");
                return;
            }
            else if (txtNewPass.Text != txtNewPass2.Text)
            {
                MessageBox.Show("Yeni şifreler uyuşmuyor.");
            }

            #endregion
            SessionHelper.CurrentUser.Password = txtNewPass.Text;
            bool result = _uc.UpdatePassword(SessionHelper.CurrentUser);

        }
    }
}
