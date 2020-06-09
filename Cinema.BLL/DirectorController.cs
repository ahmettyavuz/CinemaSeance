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
    public class DirectorController
    {
        IUnitOfWork _uow;
        IRepository<Director> _pr;
        public DirectorController()
        {
            _uow = Singleton.Uow;
            _pr = _uow.GetRepository<Director>();
        }

        public ServiceResult DirectorAdd(DirectorDTO dto)
        {
            Director director = new Director()
            {
                Id = Guid.NewGuid(),
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                IsActive = true,
                CreatedDate = DateTime.Now,
                IsDeleted =false,
                UserId = SessionHelper.CurrentUser.Id
            };
            ServiceResult result;
            try
            {
                Director islemYapildiMi = _uow.GetRepository<Director>().Add(director);
                if (islemYapildiMi != null)
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
                result = new ServiceResult("Hata: 4-34", ResultState.Error);
            }

            return result;
        }
        public List<DirectorDTO> SelectAllDirectors()
        {
            IEnumerable<Director> directors = _uow.GetRepository<Director>().Get(d => d.IsDeleted == false);
            return DirectorToDto(directors);
        }

        private void DtoToDirector(DirectorDTO dto, Director director)
        {
            director.Id = dto.Id;
            director.FirstName = dto.FirstName;
            director.LastName = dto.LastName;
        }

        private void DirectorToDto(Director director, DirectorDTO dto)
        {
            dto.Id = director.Id;
            dto.FirstName = director.FirstName;
            dto.LastName = director.LastName;
        }

        private List<DirectorDTO> DirectorToDto(IEnumerable<Director> directors)
        {
            List<DirectorDTO> result = new List<DirectorDTO>();

            foreach (var product in directors)
            {
                DirectorDTO dto = new DirectorDTO();
                DirectorToDto(product, dto);
                result.Add(dto);
            }
            return result;
        }

        public ServiceResult DirectorUpdate(DirectorDTO dto)
        {
            var director = _uow.GetRepository<Director>().Get(dto.Id);
            DtoToDirector(dto, director);
            try
            {
                Director islemYapildiMi = _uow.GetRepository<Director>().Update(director);
                if(islemYapildiMi != null)
                {
                    return new ServiceResult("İşlem başarılı.", ResultState.Success);
                }
                else
                {
                    return new ServiceResult("Yapılacak bir işlem kaydına rastlanmadı.", ResultState.Warning);
                }
            }
            catch (Exception ex)
            {
                return new ServiceResult("Hata", ResultState.Error);
            }
        }

        public ServiceResult DirectorDelete(DirectorDTO dto)
        {
            var director = _uow.GetRepository<Director>().Get(dto.Id);
            director.IsDeleted = true;
            try
            {
                Director islemYapildiMi = _uow.GetRepository<Director>().Update(director);
                if (islemYapildiMi != null)
                {
                    return new ServiceResult("İşlem başarılı.", ResultState.Success);
                }
                else
                {
                    return new ServiceResult("Yapılacak bir işlem kaydına rastlanmadı.", ResultState.Warning);
                }
            }
            catch (Exception)
            {
                return new ServiceResult("Hata", ResultState.Error);
            }
        }
    }
}
