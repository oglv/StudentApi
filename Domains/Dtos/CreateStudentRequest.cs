using testC__API.Enum;

namespace testC__API.Domains.Dtos
{
    public class CreateStudentRequest
    {
        public string Name { get; set; }

        public DateOnly Birthday { get; set; }

        public Gender Gender { get; set; }
    }
}
