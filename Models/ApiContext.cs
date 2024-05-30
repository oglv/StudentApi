using Microsoft.EntityFrameworkCore;
using testC__API.Domains.Dtos;

namespace testC__API.Models
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) 
        {
        }
        public DbSet<Student> Students { get; set; }
    }

}
