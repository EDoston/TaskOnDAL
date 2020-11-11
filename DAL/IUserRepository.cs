using System.Collections.Generic;
using ParsedData.Models;

namespace ParsedData.DAL
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User GetById(int Id);
        bool Update(User user);
        bool SetTask(int Id);
    }
}