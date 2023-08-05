using AutoMapper;
using DTITodoList.Data.DTO;
using DTITodoList.Model;

namespace DTITodoList.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        {
            return new MapperConfiguration(config =>
            {
                config.CreateMap<TaskDTO, TaskModel>();
                config.CreateMap<TaskModel, TaskDTO>();
            });
        }
    }
}
