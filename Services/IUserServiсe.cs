using System.Collections.Generic;
using ParsedData.Dtos;

namespace ParsedData.Services
{
    public interface IUserServiсe
    {
         List<UsersDto> GetAll();
         UsersDto GetById(int Id);
         bool Update(UpdateUserDto user);
         bool SetTask(int Id);
    }
}