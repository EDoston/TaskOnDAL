using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ParsedData.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Sername { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set; }
        
        public int UserStateId { get; set; }
        public UserState UserState { get; set; }   
        
        public virtual ICollection<TaskData> ManagerTaskDatas { get; set; }
        public virtual ICollection<TaskData> ExecutorTaskDatas { get; set; }
    }
}