using Cinema.BLL;
using Cinema.DTO;
using Cinema.Enums;
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
    public partial class FormMovieAdd : Form
    {
        MovieController _mc;
        CastController _cc;
        DirectorController _dc;
        public FormMovieAdd()
        {
            InitializeComponent();
            _mc = new MovieController();
            _cc = new CastController();
            _dc = new DirectorController();
        }

        private void FormMovieAdd_Load(object sender, EventArgs e)
        {
            cmbMovieType.FillComboBox<MovieTypeEnum>();
            cmbMovieType.SelectedIndex = 0;
            List<CastDTO> dtoCasts = _cc.GetAllCasts();
            lstCasts.DataSourceMember<List<CastDTO>>("FullName", "Id", dtoCasts);
            List<DirectorDTO> dtoDirectors = _dc.SelectAllDirectors();
            lstDirectors.DataSourceMember<List<DirectorDTO>>("FullName", "Id", dtoDirectors);

            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            MovieDTO dto = new MovieDTO();
            dto.MovieName = txtMovieName.Text;
            dto.MovieTime = int.Parse(nudMovieTime.Value.ToString());
            dto.MovieTypeNo = (MovieTypeEnum)cmbMovieType.SelectedItem;
            dto.Year = int.Parse(txtMovieYear.Text);
            dto.TD = chb3D.Checked;
            foreach (var item in lstCasts.SelectedItems)
            {
                dto.Casts.Add((CastDTO)item);
            }
            foreach (var item in lstDirectors.SelectedItems)
            {
                dto.Directors.Add((DirectorDTO)item);
            }
            bool result = _mc.MovieAdd(dto);
            if (result)
            {
                MessageBox.Show("Film Eklendi");
            }
        }
    }
}
