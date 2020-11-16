using System;
using ParsedData.Models;

namespace ParsedData.Dtos
{
    public class TaskDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set;}

        public int TaskStateId { get; set; }
        public TaskState TaskState { get; set; }

        public int DirectorId {get; set;}
        public int ExecuterId { get; set; }      
        public User Executer { get; set; }  
    }
}