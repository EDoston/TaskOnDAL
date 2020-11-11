using System.Collections.Generic;
using AutoMapper;
using ParsedData.DAL;
using ParsedData.Dtos;

namespace ParsedData.Services
{
    public class UserService : IUserServiсe
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository _userRepository, IMapper _mapper)
        {
            this._userRepository = _userRepository;
            this._mapper = _mapper;
        }
        public List<UsersDto> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public UsersDto GetById(int Id)
        {
            var user  = _userRepository.GetById(Id);
            return _mapper.Map<UsersDto>(user);
        }

        public bool SetTask(int Id)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(UpdateUserDto user)
        {
            throw new System.NotImplementedException();
        }
    }
}