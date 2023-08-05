using DTITodoList.Data.DTO;
using DTITodoList.Repository;

namespace DTITodoList.Services
{
    public class ServiceTask : IServiceTask
    {
        private ITaskRepository _taskRepository;

        public ServiceTask(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<TaskDTO> GetById(long id)
        {
            TaskDTO task = await _taskRepository.GetById(id);            

            return task;
        }

        public async Task<IEnumerable<TaskDTO>> GetAll()
        {
            IEnumerable<TaskDTO> task = await _taskRepository.GetAll();

            return task;
        }

        public async Task<TaskDTO> Create(TaskDTO task)
        {
            TaskDTO dto = await _taskRepository.Create(task);

            return dto;
        }

        public async Task<TaskDTO> Update(TaskDTO task)
        {
            TaskDTO dto = await _taskRepository.Update(task);

            return dto;
        }

        public async Task<bool> Delete(long id)
        {
            bool status = await _taskRepository.Delete(id);

            return status;
        }
    }
}
