using AutoMapper;
using DTITodoList.Data.DTO;
using DTITodoList.Model;
using DTITodoList.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace DTITodoList.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly MySqlContext _context;
        private IMapper _mapper;

        public TaskRepository(MySqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<TaskDTO>> GetAll()
        {
            List<TaskModel> tasks = await _context.Tasks.ToListAsync();

            return _mapper.Map<List<TaskDTO>>(tasks);
        }

        public async Task<TaskDTO> GetById(long id)
        {
            TaskModel task = await _context.Tasks.Where(x => x.Id == id).FirstOrDefaultAsync();

            return _mapper.Map<TaskDTO>(task);
        }

        public async Task<TaskDTO> Update(TaskDTO task)
        {
            TaskModel return_task = _mapper.Map<TaskModel>(task);
            _context.Tasks.Update(return_task);
            await _context.SaveChangesAsync();

            TaskDTO updated_task = await GetById(return_task.Id);

            return_task = _mapper.Map<TaskModel>(updated_task);

            return _mapper.Map<TaskDTO>(return_task);
        }

        public async Task<TaskDTO> Create(TaskDTO task)
        {
            TaskModel return_task = _mapper.Map<TaskModel>(task);
            _context.Tasks.Add(return_task);
            await _context.SaveChangesAsync();

            TaskDTO created_task = await GetById(return_task.Id);

            return_task = _mapper.Map<TaskModel>(created_task);

            return _mapper.Map<TaskDTO>(return_task);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                TaskModel task = await _context.Tasks.Where(x => x.Id == id).FirstOrDefaultAsync();
                if (task == null) {
                    return false;
                }
                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }
    }
}
