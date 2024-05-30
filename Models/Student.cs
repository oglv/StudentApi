using testC__API.Enum;

namespace testC__API.Models
{
    public class Student
    {
        /// <summary>
        /// 生徒ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 生徒名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 生徒誕生日
        /// </summary>
        public DateOnly Birthday { get; set; }

        /// <summary>
        /// 生徒性別
        /// </summary>
        public Gender Gender { get; set; }
    }
}
