using SMS.Entities.Entity;
using SMS.Entities.Entity.EntitiesMapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.Context
{
    public class SMSContext:DbContext
    {
        public SMSContext():base("name=SMSContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Attendances> Attendances { get; set; }
        public DbSet<Classes> Classes { get; set; }
        public DbSet<ExamResult> ExamResults { get; set; }
        public DbSet<ExamTypes> ExamTypes { get; set; }
        public DbSet<Logging> Logging { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Staffs> Staffs { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<StudentsMessage> StudentsMessages { get; set; }
        public DbSet<Subjects> Subjects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AttendanceMap());
            modelBuilder.Configurations.Add(new ClassesMap());
            modelBuilder.Configurations.Add(new ExamResultsMap());
            modelBuilder.Configurations.Add(new ExamTypesMap());
            modelBuilder.Configurations.Add(new LoggingMap());
            modelBuilder.Configurations.Add(new MessagesMap());
            modelBuilder.Configurations.Add(new RolesMap());
            modelBuilder.Configurations.Add(new StaffsMap());
            modelBuilder.Configurations.Add(new StudentsMap());
            modelBuilder.Configurations.Add(new StudentsMessageMap());
            modelBuilder.Configurations.Add(new SubjectsMap());
        }
    }
}
