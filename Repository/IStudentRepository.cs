using testC__API.Models;

namespace testC__API.Repository
{
    public interface IStudentRepository
    {
        Task SaveChangesAsync(Student student);

        Task<IEnumerable<Student>> ToListAsync();

        Task<Student> FindAsync(Guid id);
    }
}
