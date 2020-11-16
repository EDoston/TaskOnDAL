using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParsedData.Models
{
    public class TaskData
    {
         [Key]
        public int TaskId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set;}
        public User Executer { get; set; }

        
        public int TaskStateId { get; set; }
        public TaskState TaskState { get; set; }

        public int? TaskManagerUserId { get; set; }
        public int? ExecutorUserId { get; set; }

        [ForeignKey("TaskManagerUserId")]
        public virtual User TaskManagerUser { get; set; }
        [ForeignKey("ExecutorUserId")]
        public virtual User ExecutorUser { get; set; }   
    }
}