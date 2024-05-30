using testC__API.Domains.Dtos;

namespace testC__API.Domains
{
    public interface IStudentInteractor
    {
        Task<CreateStudentResponse> CreateStudentInfoAsync(CreateStudentRequest request);

        Task<IEnumerable<GetStudentResponse>> GetStudentListAsync();

        Task<GetStudentResponse> GetStudentAsync(Guid Id);
    }
}
