using Cinema.BLL;
using Cinema.DTO;
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
    public partial class FormTheaterUpdate : Form
    {
        TheaterDTO _dto;
        TheaterController _tc;
        public FormTheaterUpdate(TheaterDTO dto)
        {
            InitializeComponent();
            _dto = dto;
            _tc = new TheaterController();
        }

        private void FormTheaterUpdate_Load(object sender, EventArgs e)
        {
            txtTheaterName.Text = _dto.TheaterName;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _dto.TheaterName = txtTheaterName.Text;
            bool result = _tc.UpdateTheater(_dto);
            if (result)
            {
                MessageBox.Show("Salon başarıyla güncellendi");
            }
        }
    }
}
