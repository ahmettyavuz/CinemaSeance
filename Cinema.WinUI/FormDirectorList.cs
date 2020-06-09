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

namespace Cinema.WinUI
{
    public partial class FormDirectorList : Form
    {
        DirectorController _dc;
        public FormDirectorList()
        {
            InitializeComponent();
            _dc = new DirectorController();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region Validation
            ListBoxExtension.SelectedControl(lstDirectorList);
            #endregion
            var director = (DirectorDTO)lstDirectorList.SelectedItem;
            FormExtension.MdiBroShow<FormDirectorUpdate, DirectorDTO>(this, director);
        }

        private void ListLoad()
        {
            List<DirectorDTO> directors = _dc.SelectAllDirectors();
            ListBoxExtension.DataSourceMember<List<DirectorDTO>>(lstDirectorList, "FullName", "Id", directors);
        }

        private void FormDirectorList_Load(object sender, EventArgs e)
        {
            ListLoad();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            #region Validation
            ListBoxExtension.SelectedControl(lstDirectorList);
            #endregion

            var director = (DirectorDTO)lstDirectorList.SelectedItem;

            ServiceResult result = _dc.DirectorDelete(director);
            result.NotificationShow();
            if (result.State == ResultState.Success)
            {
                ListLoad();
            }
        }
    }
}
