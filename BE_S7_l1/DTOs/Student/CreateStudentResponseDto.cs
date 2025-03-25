using System.ComponentModel.DataAnnotations;

namespace BE_S7_l1.DTOs.Student
{
    public class CreateStudentResponseDto
    {
        [Required]
        public required string Message { get; set; }
    }
}
