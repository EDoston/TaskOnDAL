using System.Collections.Generic;
using ParsedData.Dtos;

namespace ParsedData.Services
{
    public interface IUserServiсe
    {
         List<UsersDto> GetAll(int page, int size);
         UsersDto GetById(int Id);
         bool Update(UpdateUserDto user);
         bool SetTaskExcutor(int TaskManagerId, int TaskExcutorId);
    }
}