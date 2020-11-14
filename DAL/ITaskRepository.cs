using System.Collections.Generic;
using System.Threading.Tasks;
using ParsedData.Models;

namespace ParsedData.DAL
{
    public interface ITaskRepository
    {
        List<TaskData> GetTaskDirectors(int page, int size);
        List<TaskData> GetTaskExecutors(int page, int size);
        TaskData GetTask(int id);
        bool Update(TaskData taskData);
        bool UpdateTaskState (int id, int stateId);
        bool ChangeExecutor(int id, int stateId);
    }
}