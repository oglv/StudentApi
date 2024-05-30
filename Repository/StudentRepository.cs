using Microsoft.EntityFrameworkCore;
using testC__API.Models;

namespace testC__API.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApiContext _context;

        public StudentRepository(ApiContext context)
        {
            _context = context;
        }

        public async Task SaveChangesAsync(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Student>> ToListAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> FindAsync(Guid Id)
        {
            return await _context.Students.FindAsync(Id);
        }
    }
}
