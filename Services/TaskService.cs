using System.Collections.Generic;
using AutoMapper;
using ParsedData.DAL;
using ParsedData.Dtos;
using ParsedData.Models;

namespace ParsedData.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IMapper _mapper;
        public TaskService(ITaskRepository _taskRepository, IMapper _mapper)
        {
            this._taskRepository = _taskRepository;
            this._mapper = _mapper;          
        }

        public TaskDto GetTask(int id)
        {
            var result = _taskRepository.GetTask(id);
            return _mapper.Map<TaskDto>(result);
        }

        public List<TaskDto> GetTaskDirectors(int page, int size)
        {
           var result = _taskRepository.GetTaskDirectors(page, size);
            return _mapper.Map<List<TaskDto>>(result);
        }

        public List<TaskDto> GetTaskExecutors(int page, int size)
        {
            var result = _taskRepository.GetTaskExecutors(page, size);
            return _mapper.Map<List<TaskDto>>(result);
        }

        public bool Update(TaskData _taskData)
        {
            return  _taskRepository.Update(_taskData);
        }

        public bool UpdateTaskState(int id, int stateId)
        {
            return _taskRepository.UpdateTaskState(id, stateId);
        }
    }
}