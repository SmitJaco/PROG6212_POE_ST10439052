using System.ComponentModel.DataAnnotations;

namespace PROG6212_POE_ST10439052.Models
{
    // Prototype model for Lecturer (no logic yet)
    public class Lecturer
    {
        [Key]
        public int LecturerID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}


