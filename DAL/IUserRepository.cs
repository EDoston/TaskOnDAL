using System.Collections.Generic;
using ParsedData.Dtos;
using ParsedData.Models;

namespace ParsedData.DAL
{
    public interface IUserRepository
    {
        List<User> GetAll(int page, int size);
        User GetById(int Id);
        bool Update(User user);
        bool SetTaskExcutor(int TaskManagerId, int TaskExcutorId);
    }
}