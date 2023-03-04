using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Domain;

namespace WebApplication1.Models.Data
{
    public class MVCDemoDbContext: DbContext
    {
        public MVCDemoDbContext(DbContextOptions<MVCDemoDbContext> options) : base(options) { 
        }

        public DbSet<Employee> Employees {  get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Access> Accesses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(e => e.ToTable("Employee"));
            modelBuilder.Entity<Admin>(e => e.ToTable("Admin"));
            modelBuilder.Entity<Access>(e => e.ToTable("Access"));

            //Admin
            modelBuilder.Entity<Admin>()
                .HasMany(a=>a.Employees)
                

            //Access
            modelBuilder.Entity<Access>()
                    .HasOne(a => a.Admin)
                    .WithMany(b => b.Accesses)
                    .HasForeignKey(a => a.AccessId);

            //Employee
            modelBuilder.Entity<Employee>()
                .
        }

        
    }
}
