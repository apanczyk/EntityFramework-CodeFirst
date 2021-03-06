using System.ComponentModel.DataAnnotations;

namespace Cw11.DTOs
{
    public class DoctorAddDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
    }
}