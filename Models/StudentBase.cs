using System.ComponentModel.DataAnnotations;

namespace Lab6.Models
{
    public class StudentBase
    {
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Program { get; set; }
    }
}
