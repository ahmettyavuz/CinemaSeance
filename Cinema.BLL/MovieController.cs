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
    public class MovieController
    {
        IUnitOfWork _uow;
        DirectorController _dc;
        public MovieController()
        {
            _uow = Singleton.Uow;
            _dc = new DirectorController();
        }

        public bool MovieAdd(MovieDTO dto)
        {
            Movie movie = new Movie()
            {
                Id = Guid.NewGuid(),
                MovieName = dto.MovieName,
                MovieTypeNo = dto.MovieTypeNo,
                MovieTime = dto.MovieTime,
                Year = dto.Year,
                CreatedDate = DateTime.Now,
                IsActive = true,
                TD = dto.TD,
                UserId = SessionHelper.CurrentUser.Id,
            };
            foreach (var item in dto.Casts)
            {
                Cast cast = _uow.GetRepository<Cast>().Get(item.Id);
                movie.Casts.Add(cast);
            }
            foreach (var item in dto.Directors)
            {
                Director director = _uow.GetRepository<Director>().Get(item.Id);
                movie.Directors.Add(director);
            }
            var result = _uow.GetRepository<Movie>().Add(movie);
            if (result != null)
            {
                return true;
            }
            return false;
        }

        public List<MovieDTO> GetAllMovies()
        {
            ICollection<Movie> movies = _uow.GetRepository<Movie>().Get(m => m.IsDeleted == false);
            return MovieToDto(movies);
        }

        private void MovieToDto(Movie movie, MovieDTO dto)
        {
            dto.Id = movie.Id;
            dto.MovieName = movie.MovieName;
            dto.MovieTime = movie.MovieTime;
            dto.MovieTypeNo = movie.MovieTypeNo;
            dto.TD = movie.TD;
            dto.Year = movie.Year;
            foreach (var item in movie.Directors)
            {
                DirectorDTO dtoDirector = new DirectorDTO()
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,

                };
                dto.Directors.Add(dtoDirector);
            }
            foreach (var item in movie.Casts)
            {
                CastDTO dtoCast = new CastDTO()
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,

                };
                dto.Casts.Add(dtoCast);
            }

        }
        private List<MovieDTO> MovieToDto(IEnumerable<Movie> movies)
        {
            List<MovieDTO> result = new List<MovieDTO>();
            foreach (var movie in movies)
            {
                MovieDTO dto = new MovieDTO();
                MovieToDto(movie, dto);
                result.Add(dto);
            }
            return result;
        }
    }
}
