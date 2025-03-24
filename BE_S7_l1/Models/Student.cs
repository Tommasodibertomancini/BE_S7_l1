using System.ComponentModel.DataAnnotations;

namespace BE_S7_l1.Models
{
    public class Student
    {
        [Key]
        public Guid StudentId { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Surname { get; set; }

        [Required]
        public required string EmailAddress { get; set; }
    }
}
