using HR_.Models;
using Microsoft.EntityFrameworkCore;

namespace HR_.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
         public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Hr> Hr { get; set; }
        public DbSet<Skill> Skills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure many-to-many relationship between Employee and Skill
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Skills)
                .WithMany(s => s.Employees)
                .UsingEntity(j => j.ToTable("EmployeeSkills"));

            base.OnModelCreating(modelBuilder);
        }
    }
}
