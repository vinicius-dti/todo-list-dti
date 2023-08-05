
namespace DTITodoList.Data.DTO
{
    public class TaskDTO
    {
        public long Id { get; set; }
        public string? Title { get; set; }        
        public string? Description { get; set; }        
        public DateTime LimitDate { get; set; }
        public bool Status { get; set; }
    }
}
