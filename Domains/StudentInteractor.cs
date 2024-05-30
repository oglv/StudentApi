using testC__API.Domains.Dtos;
using testC__API.Models;
using testC__API.Repository;

namespace testC__API.Domains
{
    public class StudentInteractor : IStudentInteractor
    {
        private readonly IStudentRepository _studentRepository;

        public StudentInteractor(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<CreateStudentResponse> CreateStudentInfoAsync(CreateStudentRequest request)
        {
            if(request == null) throw new ArgumentNullException(nameof(request));
            var student = new Student
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Birthday = request.Birthday,
                Gender = request.Gender,
            };
            await _studentRepository.SaveChangesAsync(student);

            return new CreateStudentResponse
            {
                Student = student,
            };
        }

        public async Task<IEnumerable<GetStudentResponse>> GetStudentListAsync()
        {
            var studentList = await _studentRepository.ToListAsync();
            if(studentList == null)
            {
                return null;
            }
            var StudentList = studentList.Select(student => new GetStudentResponse
            {
                Id = student.Id,
                Name = student.Name,
                Birthday = student.Birthday,
                Gender = student.Gender,
            });
            return StudentList;
        }

        public async Task<GetStudentResponse> GetStudentAsync(Guid Id)
        {
            var studentItem = await _studentRepository.FindAsync(Id);
            if(studentItem == null)
            {
                return null;
            }

            return new GetStudentResponse
            {
                Id = studentItem.Id,
                Name = studentItem.Name,
                Birthday = studentItem.Birthday,
                Gender = studentItem.Gender,
            };
        }
    }
}
