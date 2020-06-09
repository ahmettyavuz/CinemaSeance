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
    public partial class FormSeansUpdate : Form
    {
        SeanceController _sc;
        SeanceDTO _seance; 
        public FormSeansUpdate(SeanceDTO seance)
        {
            InitializeComponent();
            _seance = seance;
            _sc = new SeanceController();
        }

        private void FormSeansUpdate_Load(object sender, EventArgs e)
        {
            if (_seance.StartTime.Hours.ToString() == "0")
            {
                cmbStartHour.SelectedItem = "00";
            }
            if (_seance.FinishTime.Hours.ToString() == "0")
            {
                cmbFinishHour.SelectedItem = "00";
            }
            cmbStartHour.SelectedItem = _seance.StartTime.Hours.ToString();
            cmbStartMinute.SelectedItem = _seance.StartTime.Minutes.ToString();
            cmbFinishHour.SelectedItem = _seance.FinishTime.Hours.ToString();
            cmbFinishMinute.SelectedItem = _seance.FinishTime.Minutes.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int movieTime = 75;//movietime'dan alınacak
            int movieHour = movieTime / 60;
            int movieMinute = movieTime % 60;
            TimeSpan movieTimeSpan = new TimeSpan(movieHour, movieMinute, 0);
            string message = "";
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
            _seance.StartTime = startTime;
            _seance.FinishTime = finishTime;

            var result = _sc.SeansGuncelle(_seance);
            result.NotificationShow();
        }
    }
}
