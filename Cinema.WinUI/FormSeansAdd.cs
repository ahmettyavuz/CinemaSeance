using Framework.Core;
using Cinema.BLL;
using Cinema.DTO;
using Cinema.Entity.Concrete;
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
    public partial class FormSeansAdd : Form
    {
        SeanceController _sc;
        public FormSeansAdd()
        {
            InitializeComponent();
            _sc = new SeanceController();
        }
        private void FormSeansMovieAdd_Load(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int movieTime = 75;//movietime'dan alınacak
            int movieHour = movieTime / 60;
            int movieMinute = movieTime % 60;
            TimeSpan movieTimeSpan = new TimeSpan(movieHour, movieMinute, 0);
            string message = "";
            var dto = new SeanceDTO();
            #region Validation
            if (cmbFinishHour.SelectedIndex != -1 && cmbStartHour.SelectedIndex != -1 && cmbFinishMinute.SelectedIndex != -1 && cmbStartMinute.SelectedIndex != -1)
            {
                TimeSpan startTime = new TimeSpan(int.Parse(cmbStartHour.SelectedItem.ToString()),
                    int.Parse(cmbStartMinute.SelectedItem.ToString()), 0);
                TimeSpan finishTime = new TimeSpan(int.Parse(cmbFinishHour.SelectedItem.ToString()),
                    int.Parse(cmbFinishMinute.SelectedItem.ToString()), 0);

                TimeSpan kalan = movieTimeSpan - (finishTime - startTime);
                if (finishTime - startTime < movieTimeSpan)
                {
                    message += ("Film " + movieHour + " saat, " + movieMinute + "dakikadır.\n" + "Lütfen " + kalan.Hours + " saat, " + kalan.Minutes + " dk daha ekleyiniz.");

                }
                TimeSpan seansTime = (finishTime - startTime) - movieTimeSpan;
                if (finishTime - startTime > movieTimeSpan)
                {
                    message += ("Film " + movieHour + " saat, " + movieMinute + "dakikadır.\n" + seansTime.Hours + " saat, " + seansTime.Minutes + " dk çıkartınız.");
                }
                dto.StartTime = startTime;
                dto.FinishTime = finishTime;
            }
            else
            {
                if (cmbStartHour.SelectedIndex == -1)
                {
                    message += "Başlangıç Saati boş geçilemez \n";
                }
                if (cmbFinishHour.SelectedIndex == -1)
                {
                    message += "Bitiş Saati boş geçilemez \n";
                }
                if (cmbStartMinute.SelectedIndex == -1)
                {
                    message += "Başlangıç Dakikası boş geçilemez \n";
                }
                if (cmbFinishMinute.SelectedIndex == -1)
                {
                    message += "Bitiş Dakikası boş geçilemez \n";
                }
            }
            #endregion
            if (message != "")
            {
                MessageBox.Show(message);
                return;
            }
            var result = _sc.SeansEkle(dto);
            result.NotificationShow();
        }
    }
}
