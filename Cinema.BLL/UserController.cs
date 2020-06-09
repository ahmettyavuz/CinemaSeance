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

namespace Cinema.BLL
{
    public class UserController
    {
        IUnitOfWork _uow;
    
        public UserController()
        {
            _uow = Singleton.Uow;
          
        }
        public UserDTO SearchUser(UserDTO dto)
        {
            var user = _uow.GetRepository<User>().GetSpesific(u => u.UserName == dto.UserName && u.Password == dto.Password);
            dto.Id = user.Id;
            dto.UserName = user.UserName;
            dto.Password = user.Password;
            if (dto != null)
            {
                return dto;
            }
            return null;
        }

        public List<UserDTO> GetAllUsers()
        {
            ICollection<User> users = _uow.GetRepository<User>().Get(u => u.IsDeleted == false);
            return UserToDto(users);
        }

        public bool UserAdd(UserDTO dto, RoleDTO roleDTO)
        {
            User user = new User();
            user.Id = Guid.NewGuid();
            user.UserName = dto.UserName;
            user.Password = dto.Password;
            Role role = _uow.GetRepository<Role>().Get(roleDTO.Id);           
            user.Roles.Add(role);
            User result = _uow.GetRepository<User>().Add(user);
            if (result != null)
            {
                return true;
            }
            return false;
        }

        public bool UpdatedUser(UserDTO dto)
        {
            var user = _uow.GetRepository<User>().Get(dto.Id);
            DtoToUser(dto, user);
            User UpdatedUser = _uow.GetRepository<User>().Update(user);
            if (UpdatedUser != null)
            {
                return true;
            }
            return false;
        }

        public bool DeleteUser(UserDTO dto)
        {
            var user = _uow.GetRepository<User>().Get(dto.Id);
            DtoToUser(dto, user);
            user.IsDeleted = true;
            User DeletedUser = _uow.GetRepository<User>().Update(user);
            if (DeletedUser != null)
            {
                return true;
            }
            return false;
        }

        public bool UpdatePassword(UserDTO currentUser)
        {
            var user = _uow.GetRepository<User>().Get(currentUser.Id);
            DtoToUser(currentUser, user);
            User UpdatedUser = _uow.GetRepository<User>().Update(user);
            if (UpdatedUser != null)
            {
                return true;
            }
            return false;
        }

        public List<RoleDTO> GetAllRoles()
        {
            ICollection<Role> roles = _uow.GetRepository<Role>().Get(r => r.IsDeleted == false);
            return RoleToDto(roles);
        }

        private void DtoToUser(UserDTO dto, User user)
        {
            user.Id = dto.Id;
            user.UserName = dto.UserName;
            user.Password = dto.Password;

        }
        private void RoleToDto(Role role, RoleDTO dto)
        {
            dto.Id = role.Id;
            dto.RoleName = role.RoleName;

        }
        private List<RoleDTO> RoleToDto(IEnumerable<Role> roles)
        {
            List<RoleDTO> result = new List<RoleDTO>();
            foreach (var role in roles)
            {
                RoleDTO dto = new RoleDTO();
                RoleToDto(role, dto);
                result.Add(dto);
            }
            return result;
        }

        private void UserToDto(User user, UserDTO dto)
        {
            dto.Id = user.Id;
            dto.UserName = user.UserName;
            dto.Password = user.Password;
            Role role = user.Roles.SingleOrDefault();
            RoleDTO roleDto = new RoleDTO();
            RoleToDto(role, roleDto);
            dto.Roles.Add(roleDto);
            
            
        }
        private List<UserDTO> UserToDto(IEnumerable<User> users)
        {
            List<UserDTO> result = new List<UserDTO>();
            foreach (var user in users)
            {
                UserDTO dto = new UserDTO();
                UserToDto(user, dto);
                result.Add(dto);
            }
            return result;
        }

    }
}
