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

namespace CinemaSeans.UI
{
    public partial class FormUserAdd : Form
    {
        UserController _uc;
        public FormUserAdd()
        {
            InitializeComponent();
            _uc = new UserController();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            UserDTO dto = new UserDTO()
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text
            };
            bool result = _uc.UserAdd(dto, cmbRole.SelectedItem as RoleDTO);
            if (result)
            {
                MessageBox.Show("Yeni Kullanıcı Eklendi.");
            }
        }

        private void FormUserAdd_Load(object sender, EventArgs e)
        {
            LoadComboboxRoles();
        }
        private void LoadComboboxRoles()
        {
            List<RoleDTO> dtos = _uc.GetAllRoles();
            cmbRole.DataSource = null;
            cmbRole.DisplayMember = "RoleName";
            cmbRole.ValueMember = "Id";
            cmbRole.DataSource = dtos;
        }
    }
}
