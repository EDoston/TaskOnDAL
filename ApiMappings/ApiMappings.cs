using AutoMapper;
using ParsedData.Dtos;
using ParsedData.Models;

namespace ParsedData
{
    public class ApiMappings : Profile
    {
        public ApiMappings()
        {
            this.CreateMap<User, UsersDto>();
            this.CreateMap<UpdateUserDto, User>();
            this.CreateMap<User,UpdateUserDto>();
            this.CreateMap<UsersDto, User>();

            this.CreateMap<TaskData, TaskDto>();
        }
    }
}