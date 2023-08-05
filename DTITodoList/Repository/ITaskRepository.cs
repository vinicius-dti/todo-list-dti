using DTITodoList.Data.DTO;

namespace DTITodoList.Repository
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskDTO>> GetAll();
        Task<TaskDTO> GetById(long id);
        Task<TaskDTO> Create(TaskDTO task);
        Task<TaskDTO> Update(TaskDTO task);
        Task<bool> Delete(long id);
    }
}
