using DTITodoList.Data.DTO;
using DTITodoList.Repository;
using DTITodoList.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DTITodoList.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private IServiceTask _taskService;

        public TaskController(IServiceTask taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskDTO>>> GetAll()
        {
            IEnumerable<TaskDTO> data_task = await _taskService.GetAll();

            if (data_task == null)
            {
                return NotFound("Dado não encontrado!");
            }

            return Ok(data_task);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TaskDTO>> Get(long id)
        {
            TaskDTO data_task = await _taskService.GetById(id);

            if (data_task == null) {
                return NotFound("Dado não encontrado!");
            }

            return Ok(data_task);
        }

        [HttpPost]
        public async Task<ActionResult<TaskDTO>> Create(TaskDTO dto)
        {
            if (dto == null)
            {
                return BadRequest("Sem dado para criação ou dado no formato errado!");
            }

            TaskDTO data_task = await _taskService.Create(dto);

            if (data_task == null)
            {
                return NotFound("Dado não criado!");
            }

            return Ok(data_task);
        }

        [HttpPut]
        public async Task<ActionResult<TaskDTO>> Update(TaskDTO dto)
        {
            if (dto == null)
            {
                return BadRequest("Sem dado ou dado no formato errado!");
            }

            TaskDTO data_task = await _taskService.Update(dto);

            if (data_task == null)
            {
                return NotFound("Dado não encontrado!");
            }

            return Ok(data_task);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            bool status = await _taskService.Delete(id);

            if (status == false)
            {
                return BadRequest("Dado não encontrado!");
            }

            return Ok("Dado deletado!");
        }
    }
}
