using System.ComponentModel.DataAnnotations;

namespace PROG6212_POE_ST10439052.Models
{
    // Prototype model for Claim (no logic yet)
    public class Claim
    {
        [Key]
        public int ClaimID { get; set; }

        [Required]
        public int LecturerID { get; set; }

        [Range(0, double.MaxValue)]
        public double HoursWorked { get; set; }

        [Range(0, double.MaxValue)]
        public decimal HourlyRate { get; set; }

        [Range(0, double.MaxValue)]
        public decimal TotalAmount { get; set; }

        [StringLength(50)]
        public string Status { get; set; } = "Draft";
    }
}


