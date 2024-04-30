using Microsoft.EntityFrameworkCore;
using SharedLibrary.Models;

namespace CaseManagementFile.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
    }
}

