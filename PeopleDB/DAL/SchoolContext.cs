using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using PeopleDB.Models;

namespace PeopleDB.DAL
{
    public class SchoolContext : DbContext
    {
       
        //public DbSet<Course> Courses { get; set; }
        //public DbSet<Department> Departments { get; set; }
        //public DbSet<Enrollment> Enrollments { get; set; }
        //public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
      //  public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<FilePath> FilePaths { get; set; }
        static SchoolContext()
        {
            Database.SetInitializer<SchoolContext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

         
        }
    }
}