using Cinema.BLL;
using Cinema.DTO;
using Cinema.WinUI;
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
    public partial class FormUserList : Form
    {
        UserController _uc;
        public FormUserList()
        {
            InitializeComponent();
            _uc = new UserController();
        }

        private void FormUserList_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void LoadUsers()
        {
            List<UserDTO> dtos = _uc.GetAllUsers();
            lstUsers.DataSource = null;
            lstUsers.DataSource = dtos;
            lstUsers.DisplayMember = "UserName";
            lstUsers.ValueMember = "Id";
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UserDTO dto = lstUsers.SelectedItem as UserDTO;
            this.MdiBroShow<FormUserUpdate, UserDTO>(dto);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.MdiBroShow<FormUserAdd>();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            UserDTO dto = lstUsers.SelectedItem as UserDTO;
            bool result = _uc.DeleteUser(dto);
            if (result)
            {
                MessageBox.Show("Kullanıcı kaydı silindi.");
            }
        }
    }
}
