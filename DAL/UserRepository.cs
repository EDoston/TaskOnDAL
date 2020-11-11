using System.Collections.Generic;
using System.Linq;
using ParsedData.Models;

namespace ParsedData.DAL
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext _context)
        {
            this._context = _context;
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(int Id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == Id);
        }

        public bool SetTask(int Id)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}