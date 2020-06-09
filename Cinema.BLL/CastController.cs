using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.DAL;
using Cinema.DAL.Abstract;
using Cinema.DAL.Abstract.IRepositoryBases;
using Cinema.DTO;
using Cinema.Entity.Concrete;
using Framework.Core;

namespace Cinema.BLL
{
    public class CastController
    {
        IUnitOfWork _uow;
        IRepository<Cast> _cr;

        public CastController()
        {
            _uow = Singleton.Uow;
            _cr = _uow.GetRepository<Cast>();
        }

        public ServiceResult CastAdd(CastDTO dto)
        {
            Cast cast = new Cast();

            cast.Id = Guid.NewGuid();
            cast.FirstName = dto.FirstName;
            cast.LastName = dto.LastName;

            ServiceResult result;

            try
            {
                cast = _uow.GetRepository<Cast>().Add(cast);

                if (cast != null)
                {
                    result = new ServiceResult("Oyuncu başarılı bir şekilde eklendi", ResultState.Success);
                }
                else
                {
                    result = new ServiceResult("Oyuncuyu eklerken bir hata oluştu", ResultState.Warning);
                }
            }
            catch (Exception)
            {
                result = new ServiceResult("Hata - 404", ResultState.Error);
            }

            return result;
        }

        public ServiceResult CastUpdate(CastDTO dto)
        {
            ServiceResult result;
            var guncellenecekCast = _uow.GetRepository<Cast>().Get(dto.Id);

            try
            {
                guncellenecekCast = _uow.GetRepository<Cast>().Update(guncellenecekCast);

                if (guncellenecekCast != null)
                {
                    result = new ServiceResult("Oyuncu bilgileri güncellendi.", ResultState.Success);
                }
                else
                {
                    result = new ServiceResult("Güncelleme esnasında bir hata oluştu.", ResultState.Warning);
                }
            }
            catch (Exception)
            {
                result = new ServiceResult("Hata - 404", ResultState.Error);
            }

            return result;
        }

        public ServiceResult CastDelete(CastDTO dto)
        {
            ServiceResult result;
            var silinecekCast = _uow.GetRepository<Cast>().Get(dto.Id);
            silinecekCast.IsDeleted = true;

            try
            {
                silinecekCast = _uow.GetRepository<Cast>().Update(silinecekCast);

                if (silinecekCast != null)
                {
                    result = new ServiceResult("Oyuncu silindi", ResultState.Success);
                }
                else
                {
                    result = new ServiceResult("Oyuncu silinirken bir hata meydana geldi.", ResultState.Warning);
                }
            }
            catch (Exception)
            {
                result = new ServiceResult("Hata - 404", ResultState.Error);
            }

            return result;
        }

        public List<CastDTO> GetAllCasts()
        {
            var CastList = _uow.GetRepository<Cast>().Get(c => c.IsDeleted == false);
            return CastToDto(CastList);
        }

        private void CastToDto(Cast cast, CastDTO dto)
        {
            dto.Id = cast.Id;
            dto.FirstName = cast.FirstName;
            dto.LastName = cast.LastName;
        }
        private List<CastDTO> CastToDto(IEnumerable<Cast> casts)
        {
            List<CastDTO> result = new List<CastDTO>();
            foreach (var cast in casts)
            {
                CastDTO dto = new CastDTO();
                CastToDto(cast, dto);
                result.Add(dto);
            }
            return result;
        }
    }
}
