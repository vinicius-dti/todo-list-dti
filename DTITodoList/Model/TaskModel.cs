using DTITodoList.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTITodoList.Model
{
    [Table("Tasks")]
    public class TaskModel : BaseEntity
    {
        [Column("Title")]
        [Required]
        public string ?Title { get; set; }

        [Column("Description")]
        [Required]
        public string ?Description { get; set; }

        [Column("Date")]
        [Required]
        public DateTime LimitDate { get; set; }

        [Column("Status")]        
        public bool Status { get; set; }
        
    }
}
