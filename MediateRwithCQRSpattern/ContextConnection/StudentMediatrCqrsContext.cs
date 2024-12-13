using MediateRwithCQRSpattern.Models;
using Microsoft.EntityFrameworkCore;
namespace MediateRwithCQRSpattern.ContextConnection
{
    public class StudentMediatrCqrsContext:DbContext
    {
        private readonly IConfiguration Configuration;

        public StudentMediatrCqrsContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<StudentDetails>students { get; set; }
    }
}
