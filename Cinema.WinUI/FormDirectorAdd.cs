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

namespace CinemaSeans.UI
{
    public partial class FormDirectorAdd : Form
    {
        DirectorController _dc;
        public FormDirectorAdd()
        {
            InitializeComponent();
            _dc = new DirectorController();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Validation
            if (!TextBoxExtension.NotNullOrWhiteSpace(txtFirstName, "Yönetmen ad bilgisi boş geçilemez!"))
            {
                return;
            }
            if (!TextBoxExtension.NotNullOrWhiteSpace(txtLastName, "Yönetmen soyad bilgisi boş geçilemez!"))
            {
                return;
            }
            #endregion

            var dto = new DirectorDTO
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text
            };

            //BLL Process

            var result = _dc.DirectorAdd(dto);

            result.NotificationShow();

            if (result.State == ResultState.Success)
            {
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = string.Empty;
                    }
                    if (item is ComboBox)
                    {
                        item.Text = string.Empty;
                    }
                }
            }
        }
    }
}
