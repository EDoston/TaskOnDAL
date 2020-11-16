using System.Collections.Generic;
using AutoMapper;
using ParsedData.DAL;
using ParsedData.Dtos;
using ParsedData.Models;

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
        public List<UsersDto> GetAll(int page, int size)
        {
           var users = _userRepository.GetAll(page, size);
           return _mapper.Map<List<UsersDto>>(users);
        }
        public UsersDto GetById(int Id)
        {
            var user  = _userRepository.GetById(Id);
            return _mapper.Map<UsersDto>(user);
        }
        public bool SetTaskExcutor(int TaskManagerId, int TaskExcutorId)
        {
            return _userRepository.SetTaskExcutor(TaskManagerId, TaskExcutorId);  
        }
        public bool Update(UpdateUserDto user)
        {
            var result = _mapper.Map<User>(user);
            return _userRepository.Update(result);
        }
    }
}