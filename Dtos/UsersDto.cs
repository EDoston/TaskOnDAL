using System;
using ParsedData.Models;

namespace ParsedData.Dtos
{
    public class UsersDto
    {
        public int Id { get; set; }
        public string Sername { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public int UserStateId { get; set; }
        public UserState UserState { get; set; }    
    }
    
}
