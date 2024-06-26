using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM.Models
{
    public class Application
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Introduction { get; set; }
        public string? Resume { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public string? Status { get; set; }

        [ForeignKey("Users")]
        public string UserId { get; set; }
        public virtual ApplicationUser Users { get; set; }



    }
}
