using Cinema.BLL;
using Cinema.DTO;
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
    public partial class FormLogin : Form
    {
        UserController _uc;
        public FormLogin()
        {
            InitializeComponent();
            _uc = new UserController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserDTO dto = new UserDTO()
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text
            };
            UserDTO result = _uc.SearchUser(dto);
            if (result!=null)
            {
                SessionHelper.CurrentUser = dto;
                FormMain frm = new FormMain();
                frm.Show();
                this.Hide();
            }
        }
    }
}
