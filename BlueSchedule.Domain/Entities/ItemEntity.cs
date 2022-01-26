using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlueSchedule.Domain.Entities
{
    public class ItemEntity
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(150)]
        public string Title { get; set; }

        [Required]
        [MinLength(15)]
        [MaxLength(300)]
        public string Description { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string Responsible { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
