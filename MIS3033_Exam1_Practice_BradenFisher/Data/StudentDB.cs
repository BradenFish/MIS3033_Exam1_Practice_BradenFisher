using Microsoft.EntityFrameworkCore;

namespace a
{
    public class StudentDB:DbContext
    {
        //define database tables here
        public DbSet<Student> stuTbl { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlite("Data Source= stu0925.DB");
        }


    }
}