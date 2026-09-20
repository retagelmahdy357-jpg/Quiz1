using Microsoft.EntityFrameworkCore;
using Quiz1.Model;

namespace Quiz1.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Department> Department { get; set; }
        public DbSet<Teachear>Teachears { get; set; }
        public DbSet<Subject> SubjectSet { get; set; }
        public DbSet<ClassRoom> Classrooms { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Quiz1;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False ");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teachear>().HasOne(x=>x.Department).WithMany(x=>x.Teachear).HasForeignKey(x=>x.DepartmentId);
            modelBuilder.Entity<Subject>().HasOne(x => x.Teachear).WithMany(x => x.Subjects).HasForeignKey(x => x.TeachearId);
            modelBuilder.Entity<Student>().HasOne(x => x.ClassRoom).WithMany(x => x.Students).HasForeignKey(x => x.ClassRoomId);
            modelBuilder.Entity<Enrollment>().HasOne(x=>x.Student).WithMany(x=>x.Enrollments).HasForeignKey(x=>x.StudentId);
            modelBuilder.Entity<Enrollment>().HasOne(x => x.Subject).WithMany(x => x.Enrollments).HasForeignKey(x => x.SubjectId);
            

            modelBuilder.Entity<Department>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Student>().HasIndex(x => x.Email).IsUnique();
            modelBuilder.Entity<Teachear>().HasIndex(x => x.Email).IsUnique();

            modelBuilder.Entity<Enrollment>().HasIndex(x => new {x.StudentId,x.SubjectId}).IsUnique();


            ;



            base.OnModelCreating(modelBuilder);
        }
    }
}
