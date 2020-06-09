using Cinema.BLL;
using Cinema.DTO;
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
    public partial class FormTheaterAdd : Form
    {
        TheaterController _tc;
        public FormTheaterAdd()
        {
            InitializeComponent();
            _tc =new TheaterController();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            #region Validation
            if(string.IsNullOrWhiteSpace(txtTheaterName.Text))
            {
                MessageBox.Show("Salon adı alanı boş bırakılamaz.");
            }
            #endregion
            TheaterDTO dto = new TheaterDTO()
            {
                TheaterName = txtTheaterName.Text
            };
            bool result = _tc.AddTheater(dto);
            if (result)
            {
                MessageBox.Show("Salon başarıyla eklendi.");
            }
        }
    }
}
