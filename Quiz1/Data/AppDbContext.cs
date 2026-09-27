using Microsoft.EntityFrameworkCore;
using Quiz1.Model;

namespace Quiz1.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) { }
       
        public DbSet<Department> Department { get; set; }
        public DbSet<Teachear>Teachears { get; set; }
        public DbSet<Subject> SubjectSet { get; set; }
        public DbSet<ClassRoom> Classrooms { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teachear>().HasOne(x => x.Department).WithMany(x => x.Teachear).HasForeignKey(x => x.DepartmentId);
            modelBuilder.Entity<Subject>().HasOne(x => x.Teachear).WithMany(x => x.Subjects).HasForeignKey(x => x.TeachearId);
            modelBuilder.Entity<Student>().HasOne(x => x.ClassRoom).WithMany(x => x.Students).HasForeignKey(x => x.ClassRoomId);
            modelBuilder.Entity<Enrollment>().HasOne(x => x.Student).WithMany(x => x.Enrollments).HasForeignKey(x => x.StudentId);
            modelBuilder.Entity<Enrollment>().HasOne(x => x.Subject).WithMany(x => x.Enrollments).HasForeignKey(x => x.SubjectId);


            modelBuilder.Entity<Department>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Student>().HasIndex(x => x.Email).IsUnique();
            modelBuilder.Entity<Teachear>().HasIndex(x => x.Email).IsUnique();

            modelBuilder.Entity<Enrollment>().HasIndex(x => new { x.StudentId, x.SubjectId }).IsUnique();


            ;




            modelBuilder.Entity<Department>().HasData(
             new Department
             {
                 DepartmentId = 1,
                 Name = "Computer Science",
                 Description = "Software and programming department"
             },
             new Department
             {
                 DepartmentId = 2,
                 Name = "Electronics",
                 Description = "Electronics and embedded systems department"
             }
          );


            modelBuilder.Entity<Teachear>().HasData(
                new Teachear
                {
                    TeachearId = 1,
                    FirstName = "Ahmed",
                    LastName = "Hassan",
                    Email = "ahmed@school.com",
                    PhoneNumber = "01012345678",
                    Salary = 15000,
                    DepartmentId = 1
                },
                new Teachear
                {
                    TeachearId = 2,
                    FirstName = "Mona",
                    LastName = "Ali",
                    Email = "mona@school.com",
                    PhoneNumber = "01123456789",
                    Salary = 14000,
                    DepartmentId = 1
                },
                new Teachear
                {
                    TeachearId = 3,
                    FirstName = "Omar",
                    LastName = "Mahmoud",
                    Email = "omar@school.com",
                    PhoneNumber = "01234567890",
                    Salary = 15500,
                    DepartmentId = 2
                }
            );



            modelBuilder.Entity<Subject>().HasData(
                new Subject
                {
                    SubjectId = 1,
                    Name = "C++ Programming",
                    Description = "Programming fundamentals and OOP",
                    Grade = 100,
                    TeachearId = 1
                },
                new Subject
                {
                    SubjectId = 2,
                    Name = "Database Systems",
                    Description = "Database and SQL",
                    Grade = 100,
                    TeachearId = 2
                },
                new Subject
                {
                    SubjectId = 3,
                    Name = "Web Development",
                    Description = "Web development fundamentals",
                    Grade = 100,
                    TeachearId = 1
                },
                new Subject
                {
                    SubjectId = 4,
                    Name = "Embedded Systems",
                    Description = "Microcontrollers and embedded programming",
                    Grade = 100,
                    TeachearId = 3
                }
            );



            modelBuilder.Entity<ClassRoom>().HasData(
                new ClassRoom
                {
                    ClassRoomId = 1,
                    Name = "Software 1A",
                    GradeLevel = 10,
                    Capacity = 30
                },
                new ClassRoom
                {
                    ClassRoomId = 2,
                    Name = "Electronics 1A",
                    GradeLevel = 10,
                    Capacity = 25
                }
            );


            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1,
                    FirstName = "Ali",
                    LastName = "Mohamed",
                    Email = "ali@student.com",
                    PhoneNumber = "01011111111",
                    DateofBirth = new DateTime(2010, 5, 12),
                    ClassRoomId = 1
                },
                new Student
                {
                    StudentId = 2,
                    FirstName = "Omar",
                    LastName = "Ahmed",
                    Email = "omar@student.com",
                    PhoneNumber = "01022222222",
                    DateofBirth = new DateTime(2010, 8, 20),
                    ClassRoomId = 1
                },
                new Student
                {
                    StudentId = 3,
                    FirstName = "Youssef",
                    LastName = "Hany",
                    Email = "youssef@student.com",
                    PhoneNumber = "01033333333",
                    DateofBirth = new DateTime(2010, 3, 15),
                    ClassRoomId = 1
                },
                new Student
                {
                    StudentId = 4,
                    FirstName = "Mariam",
                    LastName = "Ali",
                    Email = "mariam@student.com",
                    PhoneNumber = "01044444444",
                    DateofBirth = new DateTime(2010, 7, 10),
                    ClassRoomId = 2
                },
                new Student
                {
                    StudentId = 5,
                    FirstName = "Salma",
                    LastName = "Mostafa",
                    Email = "salma@student.com",
                    PhoneNumber = "01055555555",
                    DateofBirth = new DateTime(2009, 12, 22),
                    ClassRoomId = 2
                },
                new Student
                {
                    StudentId = 6,
                    FirstName = "Karim",
                    LastName = "Tarek",
                    Email = "karim@student.com",
                    PhoneNumber = "01066666666",
                    DateofBirth = new DateTime(2010, 11, 5),
                    ClassRoomId = 2
                }
            );


            modelBuilder.Entity<Enrollment>().HasData(
                new Enrollment
                {
                    EnrollmentId = 1,
                    StudentId = 1,
                    SubjectId = 1,
                    EnrollmentDate = new DateTime(2026, 9, 1),
                    Grade = 90
                },
                new Enrollment
                {
                    EnrollmentId = 2,
                    StudentId = 1,
                    SubjectId = 2,
                    EnrollmentDate = new DateTime(2026, 9, 1),
                    Grade = 85
                },
                new Enrollment
                {
                    EnrollmentId = 3,
                    StudentId = 2,
                    SubjectId = 1,
                    EnrollmentDate = new DateTime(2026, 9, 1),
                    Grade = 78
                },
                new Enrollment
                {
                    EnrollmentId = 4,
                    StudentId = 2,
                    SubjectId = 3,
                    EnrollmentDate = new DateTime(2026, 9, 1),
                    Grade = 88
                },
                new Enrollment
                {
                    EnrollmentId = 5,
                    StudentId = 3,
                    SubjectId = 1,
                    EnrollmentDate = new DateTime(2026, 9, 1),
                    Grade = 95
                },
                new Enrollment
                {
                    EnrollmentId = 6,
                    StudentId = 4,
                    SubjectId = 4,
                    EnrollmentDate = new DateTime(2026, 9, 1),
                    Grade = 82
                },
                new Enrollment
                {
                    EnrollmentId = 7,
                    StudentId = 5,
                    SubjectId = 4,
                    EnrollmentDate = new DateTime(2026, 9, 1),
                    Grade = 91
                },
                new Enrollment
                {
                    EnrollmentId = 8,
                    StudentId = 6,
                    SubjectId = 2,
                    EnrollmentDate = new DateTime(2026, 9, 1),
                    Grade = 76
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
