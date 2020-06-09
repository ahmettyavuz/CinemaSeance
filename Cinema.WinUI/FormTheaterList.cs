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
    public partial class FormTheaterList : Form
    {
        TheaterController _tc;
        public FormTheaterList()
        {
            InitializeComponent();
            _tc = new TheaterController();
        }

        private void FormTheaterList_Load(object sender, EventArgs e)
        {
            List<TheaterDTO> dtos = _tc.GetAllTheaters();
            lstTheaters.DataSourceMember<List<TheaterDTO>>("TheaterName", "Id", dtos);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.MdiBroShow<FormTheaterAdd>();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            TheaterDTO dto = lstTheaters.SelectedItem as TheaterDTO;
            this.MdiBroShow<FormTheaterUpdate,TheaterDTO>(dto);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            TheaterDTO dto = lstTheaters.SelectedItem as TheaterDTO;
            bool result = _tc.DeleteTheater(dto);
            if (result)
            {
                MessageBox.Show("Salon başarıyla silindi.");
            }
        }
    }
}
