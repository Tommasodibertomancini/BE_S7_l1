using System.ComponentModel.DataAnnotations;

namespace BE_S7_l1.DTOs.Student
{
    public class DeleteStudentResponseDto
    {
        [Required]
        public required string Message { get; set; }
    }
}
