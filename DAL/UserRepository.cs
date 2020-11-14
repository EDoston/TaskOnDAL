using System;
using System.Collections.Generic;
using System.Linq;
using ParsedData.Dtos;
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
        
        public List<User> GetAll(int page, int size)
        {
             var users = _context.Users
                .Skip((page - 1) * size)
                .Take(size).ToList();
                return users;
        }
        public User GetById(int Id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == Id);
        }
        public bool SetTaskExcutor(int DirectorId, int ExcutorId)
        {
            var user = _context.TaskDatas.FirstOrDefault(x => x.DirectorId == DirectorId);
            
            if(user == null)
            {
                return false;
            }

            user.ExecuterId = ExcutorId;

            return true;
        }
        public bool Update(User user)
        {
            var foundUser = GetById(user.Id);
            if(foundUser == null)
            {
                return false;
            }

            foundUser.Sername = user.Sername;
            foundUser.Name = user.Name;
            foundUser.LastUpdate = DateTime.Today;

            _context.SaveChanges();

            return false;
        }
    }
}