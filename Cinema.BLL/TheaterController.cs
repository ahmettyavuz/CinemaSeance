using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.DAL;
using Cinema.DAL.Abstract;
using Cinema.DTO;
using Cinema.DTO.SessionHelper;
using Cinema.Entity.Concrete;

namespace Cinema.BLL
{
    public class TheaterController
    {
        IUnitOfWork _uow;
        public TheaterController()
        {
            _uow = Singleton.Uow;
        }
        public bool AddTheater(TheaterDTO dto)
        {
            Theater theater = new Theater()
            {
                Id = Guid.NewGuid(),
                TheaterName = dto.TheaterName,
                IsActive = true,
                CreatedDate = DateTime.Now,
                UserId = SessionHelper.CurrentUser.Id,
                
            };
            Theater addedTheater = _uow.GetRepository<Theater>().Add(theater);
            if (addedTheater != null)
            {
                return true;
            }
            return false;
        }

        public bool UpdateTheater(TheaterDTO dto)
        {
            Theater theater = _uow.GetRepository<Theater>().Get(dto.Id);
            DtoToTheater(dto, theater);
            theater.UpdatedDate = DateTime.Now;
            Theater updatedTheater = _uow.GetRepository<Theater>().Update(theater);
            if (updatedTheater != null)
            {
                return true;
            }
            return false;
        }

        public bool DeleteTheater(TheaterDTO dto)
        {
            Theater theater = _uow.GetRepository<Theater>().Get(dto.Id);
            DtoToTheater(dto, theater);
            theater.IsDeleted = true;
            Theater deletedTheater = _uow.GetRepository<Theater>().Update(theater);
            if (deletedTheater != null)
            {
                return true;
            }
            return false;
        }

        private void DtoToTheater(TheaterDTO dto, Theater theater)
        {
            theater.Id = dto.Id;
            theater.TheaterName = dto.TheaterName;

        }

        public List<TheaterDTO> GetAllTheaters()
        {
            ICollection<Theater> theaters = _uow.GetRepository<Theater>().Get(t => t.IsDeleted == false);
            return TheaterToDto(theaters);
        }
        private void TheaterToDto(Theater theater, TheaterDTO dto)
        {
            dto.Id = theater.Id;
            dto.TheaterName = theater.TheaterName;


        }
        private List<TheaterDTO> TheaterToDto(IEnumerable<Theater> theaters)
        {
            List<TheaterDTO> result = new List<TheaterDTO>();
            foreach (var theater in theaters)
            {
                TheaterDTO dto = new TheaterDTO();
                TheaterToDto(theater, dto);
                result.Add(dto);
            }
            return result;
        }
    }
}
