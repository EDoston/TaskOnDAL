using System;
using ParsedData.Models;

namespace ParsedData.Dtos
{
    public class UpdateUserDto
    {
        public int Id { get; set; }
        public string Sername { get; set; }
        public string Name { get; set; }
        public DateTime LastUpdate { get; set; }   
    }
}