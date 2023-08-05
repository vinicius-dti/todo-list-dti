using AutoMapper;
using DTITodoList.Data.DTO;

namespace DTITodoList.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        {
            return new MapperConfiguration(config =>
            {
                config.CreateMap<TaskDTO, Task>();
                config.CreateMap<Task, TaskDTO>();
            });
        }
    }
}
