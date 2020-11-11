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
            this.CreateMap<UsersDto, User>();
        }
    }
}