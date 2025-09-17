using System.ComponentModel.DataAnnotations;

namespace PROG6212_POE_ST10439052.Models
{
    // Prototype model for AcademicManager (no logic yet)
    public class AcademicManager
    {
        [Key]
        public int ManagerID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}


