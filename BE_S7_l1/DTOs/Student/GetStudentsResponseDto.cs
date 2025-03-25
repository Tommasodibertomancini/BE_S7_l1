using System.ComponentModel.DataAnnotations;

namespace BE_S7_l1.DTOs.Student
{
    public class GetStudentsResponseDto
    {
        [Required]
        public required string Message { get; set; }

        [Required]
        public required List<StudentDto>? Students { get; set; }
    }
}
