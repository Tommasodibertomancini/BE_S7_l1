using BE_S7_l1.Data;
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

        public async Task<List<Student>?> GetAllStudentsAsyc()
        {
            try
            {
                return await _context.Students.ToListAsync();
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
    }
}
