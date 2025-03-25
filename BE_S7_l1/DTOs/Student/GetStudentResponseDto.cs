using System.ComponentModel.DataAnnotations;

namespace BE_S7_l1.DTOs.Student
{
    public class GetStudentResponseDto
    {
        [Required]
        public required string Message { get; set; }

        [Required]
        public StudentDto? Student { get; set; }
    }
}
