using System.Collections.Generic;
using ParsedData.Dtos;
using ParsedData.Models;

namespace ParsedData.Services
{
    public interface ITaskService
    {
        List<TaskDto> GetTaskDirectors(int page, int size);
        List<TaskDto> GetTaskExecutors(int page, int size);
        TaskDto GetTask(int id);
        bool Update(TaskData _taskData);
        bool UpdateTaskState(int id, int stateId);
    }
}