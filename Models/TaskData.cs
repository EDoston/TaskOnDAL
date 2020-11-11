using System;

namespace ParsedData.Models
{
    public class TaskData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set;}

        public int DataStateId { get; set; }
        public StateData DataState { get; set; }

        public int DirectorId {get; set;}
        public int ExecuterId { get; set; }      
        public User Executer { get; set; }   
    }
}