using System.ComponentModel.DataAnnotations;

namespace PROG6212_POE_ST10439052.Models
{
    // Prototype model for SupportingDocument (no logic yet)
    public class SupportingDocument
    {
        [Key]
        public int DocumentID { get; set; }

        [Required]
        public int ClaimID { get; set; }

        [Required]
        [StringLength(255)]
        public string FilePath { get; set; } = string.Empty;
    }
}


