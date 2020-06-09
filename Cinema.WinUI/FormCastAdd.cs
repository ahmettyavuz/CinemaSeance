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
    public partial class FormCastAdd : Form
    {
        CastController _cc;
        public FormCastAdd()
        {
            InitializeComponent();
            _cc = new CastController();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Validation
            string message = "";
            if (String.IsNullOrWhiteSpace(txtFirstName.Text) || String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                message += "İsim ve Soyisim girilmelidir\n";
            }

            if (message != "")
            {
                MessageBox.Show(message);
                return;
            }
            #endregion

            var dto = new CastDTO();

            dto.FirstName = txtFirstName.Text;
            dto.LastName = txtLastName.Text;

            var result = _cc.CastAdd(dto);

            result.NotificationShow();

            if (result.State == ResultState.Success)
            {
                txtFirstName.Text = "";
                txtLastName.Text = "";
            }
        }
    }
}
