using BE_S7_l1.Data;
using BE_S7_l1.DTOs.Student;
using BE_S7_l1.Models;
using Microsoft.EntityFrameworkCore;

namespace BE_S7_l1.Services
{
    public class StudentService
    {
        private readonly ApplicationDbContext _context;

        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> TrySaveAsync()
        {
            try
            {
                return await _context.SaveChangesAsync() > 0;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<StudentDto>?> GetAllStudentsAsyc()
        {
            try
            {
                var studentsList = await _context.Students.ToListAsync();

                var result = new List<StudentDto>();

                foreach (var student in studentsList)
                {
                    result.Add(
                        new StudentDto()
                        {
                            StudentId = student.StudentId,
                            Name = student.Name,
                            Surname = student.Surname,
                            EmailAddress = student.EmailAddress,
                        }
                    );
                }

                return result;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> CreateStudentAsync(Student student)
        {
            try
            {
                _context.Students.Add(student);

                return await TrySaveAsync();
            }
            catch
            {
                return false;
            }
        }

        public async Task<StudentDto?> GetStudentbyEmailAsync(string email)
        {
            try
            {
                var student = await _context.Students.FirstOrDefaultAsync(s =>
                    s.EmailAddress == email
                );

                if (student == null)
                {
                    return null;
                }

                var foundStudent = new StudentDto()
                {
                    StudentId = student.StudentId,
                    Name = student.Name,
                    Surname = student.Surname,
                    EmailAddress = student.EmailAddress,
                };

                return foundStudent;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> EditStudentAsync(Guid id, EditStudentRequestDto editStudent)
        {
            try
            {
                var student = await _context.Students.FirstOrDefaultAsync(s => s.StudentId == id);

                if (student == null)
                {
                    return false;
                }

                student.Name = editStudent.Name;
                student.Surname = editStudent.Surname;
                student.EmailAddress = editStudent.EmailAddress;

                return await TrySaveAsync();
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteStudentByIdAsync(Guid id)
        {
            try
            {
                var student = await _context.Students.FindAsync(id);

                if (student == null)
                {
                    return false;
                }

                _context.Students.Remove(student);

                return await TrySaveAsync();
            }
            catch
            {
                return false;
            }
        }
    }
}
