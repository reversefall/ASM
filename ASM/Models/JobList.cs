using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM.Models
{
    public class JobList
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Location { get; set; }
        public string? Company { get; set; }
        public string? ImageUrl { get; set; }
        [NotMapped]
        public IFormFile? Image { get; set; }
        public string? Description { get; set; }
        public string? RequieredSkill { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
}
}
