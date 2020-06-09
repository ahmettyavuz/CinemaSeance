using Cinema.DAL;
using Cinema.DAL.Abstract;
using Cinema.DAL.Abstract.IRepositoryBases;
using Cinema.DTO;
using Cinema.DTO.SessionHelper;
using Cinema.Entity.Concrete;
using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BLL
{
    public class SeanceController
    {
        IUnitOfWork _uow;
        IRepository<Movie> _mr;
        public SeanceController()
        {
            _uow = Singleton.Uow;
            _mr = _uow.GetRepository<Movie>();
        }

        public List<SeanceDTO> TumSeanslariVer()
        {
            ICollection<Seance> seances = _uow.GetRepository<Seance>().Get(s => s.IsDeleted == false);
            return SeanceToDto(seances);
        }

        public ServiceResult SeansEkle(SeanceDTO dto)
        {
            DateTime cd = DateTime.Now;
            Seance seance = new Seance()
            {
                FinishTime = dto.FinishTime,
                StartTime = dto.StartTime,
                IsActive = true,
                IsDeleted = false,
                CreatedDate = cd.Date,
                UserId=SessionHelper.CurrentUser.Id,
                Id = Guid.NewGuid()
            };
            ServiceResult result;
            try
            {
                Seance islemYapildiMi = _uow.GetRepository<Seance>().Add(seance);
                if (islemYapildiMi!=null)
                {
                    result = new ServiceResult("İşlem başarılı", ResultState.Success);
                }
                else
                {
                    result = new ServiceResult("Yapılacak bir işlem kaydına rastlanmadı.", ResultState.Warning);
                }
            }
            catch (Exception ex)
            {
                result = new ServiceResult("Hata", ResultState.Error);
            }
            return result;
        }
        public ServiceResult SeansSil(SeanceDTO dto)
        {
            var seance = _uow.GetRepository<Seance>().Get(dto.Id);
            seance.IsDeleted = true;
            seance.UserId = SessionHelper.CurrentUser.Id;
            ServiceResult result;
            try
            {
                Seance islemYapildiMi = _uow.GetRepository<Seance>().Update(seance);
                if (islemYapildiMi!=null)
                {
                    result = new ServiceResult("İşlem Başarılıdır.", ResultState.Success);
                }
                else
                {
                    result = new ServiceResult("Yapılacak bir işlem kaydına rastlanamadı", ResultState.Warning);
                }
            }
            catch (Exception ex)
            {
                result = new ServiceResult("Hata", ResultState.Error);
            }
            return result;
        }
        public ServiceResult SeansGuncelle(SeanceDTO dto)
        {
            var seance = _uow.GetRepository<Seance>().Get(dto.Id);
            DtotoSeance(dto, seance);
            ServiceResult result;
            try
            {
                Seance islemYapildiMi = _uow.GetRepository<Seance>().Update(seance);
                if (islemYapildiMi != null)
                {
                    result = new ServiceResult("İşlem Başarılıdır.", ResultState.Success);
                }
                else
                {
                    result = new ServiceResult("Yapılacak bir işlem kaydına rastlanamadı", ResultState.Warning);
                }
            }
            catch (Exception ex)
            {
                result = new ServiceResult("Hata", ResultState.Error);
            }
            return result;
        }
        private void DtotoSeance(SeanceDTO dto,Seance seance)
        {
            seance.Id = dto.Id;
            seance.StartTime = dto.StartTime;
            seance.FinishTime = dto.FinishTime;
        }
        private void SeanceToDto(Seance seance, SeanceDTO dto)
        {
            dto.Id = seance.Id;
            dto.StartTime = seance.StartTime;
            dto.FinishTime = seance.FinishTime;
            
        }
        private List<SeanceDTO> SeanceToDto(IEnumerable<Seance> seances)
        {
            List<SeanceDTO> result = new List<SeanceDTO>();

            foreach (var seance in seances)
            {
                SeanceDTO dto = new SeanceDTO();
                SeanceToDto(seance,dto);
                result.Add(dto);
            }
            return result;
        }
    }
}
