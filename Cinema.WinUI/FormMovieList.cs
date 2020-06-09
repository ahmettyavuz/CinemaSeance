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
    public partial class FormMovieList : Form
    {
        MovieController _mc;
        public FormMovieList()
        {
            InitializeComponent();
            _mc = new MovieController();
        }

        private void FormMovieList_Load(object sender, EventArgs e)
        {
            List<MovieDTO> dtos = _mc.GetAllMovies();
            lstMovies.DataSourceMember<List<MovieDTO>>("MovieName", "Id", dtos);
        }
    }
}
