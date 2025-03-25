using System.ComponentModel.DataAnnotations;

namespace BE_S7_l1.DTOs.Student
{
    public class EditStudentRequestDto
    {
        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Surname { get; set; }

        [Required]
        public required string EmailAddress { get; set; }
    }
}
