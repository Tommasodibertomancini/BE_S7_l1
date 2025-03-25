using System.ComponentModel.DataAnnotations;

namespace BE_S7_l1.DTOs.Student
{
    public class EditStudentResponseDto
    {
        [Required]
        public required string Message { get; set; }
    }
}
