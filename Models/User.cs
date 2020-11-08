using System;

namespace ParsedData.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Sername { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }       
    }
}