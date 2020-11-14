using System;
using System.Collections.Generic;
using System.Linq;
using ParsedData.Models;

namespace ParsedData.DAL
{
    public class TaskRepository : ITaskRepository
    {     
        private readonly DataContext _context;

        public TaskRepository (DataContext _context)
        {
            this._context = _context;
        }

        public bool ChangeExecutor(int id, int stateId)
        {
            var taskData = GetTask(id);
            if(taskData == null)
            {
                return false;
            }

            taskData.DataStateId = stateId;
            _context.SaveChanges();

            return true;
        }
        public TaskData GetTask(int id)
        {
            var taskData = _context.TaskDatas.FirstOrDefault(x => x.Id == id);
            return taskData;
        }
        public List<TaskData> GetTaskDirectors(int page, int size)
        {
             var taskDatas = _context.TaskDatas
                .Skip((page - 1) * size)
                .Take(size).ToList();
                return taskDatas;
        }

        public List<TaskData> GetTaskExecutors(int page, int size)
        {
            var taskDatas = _context.TaskDatas
                .Skip((page - 1) * size)
                .Take(size).ToList();
                return taskDatas;
        }

        public bool Update(TaskData _taskData)
        {
            var taskData = GetTask(_taskData.Id);
            if(taskData == null)
            {
                return false;
            }
            taskData.Name = _taskData.Name;
            taskData.Description = _taskData.Description;
            taskData.LastUpdate = DateTime.Today;

            _context.SaveChanges();

            return true;
        }

        public bool UpdateTaskState(int id, int stateId)
        {
            var taskData = GetTask(id);
            if (taskData == null) {
                return false;
            }

            taskData.DataStateId = stateId;

            _context.SaveChanges();

            return false;
        }
    }
}