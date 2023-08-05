using DTITodoList.Data.DTO;
using DTITodoList.Repository;

namespace DTITodoList.Services
{
    public interface IServiceTask
    {
        Task<IEnumerable<TaskDTO>> GetAll();
        Task<TaskDTO> GetById(long id);
        Task<TaskDTO> Create(TaskDTO task);
        Task<TaskDTO> Update(TaskDTO task);
        Task<bool> Delete(long id);
    }
}
