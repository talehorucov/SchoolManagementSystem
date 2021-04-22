using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.Entity.EntitiesMapping
{
    public class StudentsMap : EntityTypeConfiguration<Students>
    {
        public StudentsMap()
        {
            this.HasKey(s => s.Id);

            this.Property(s => s.Firstname)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(s => s.Lastname)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(s => s.FatherName)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(s => s.Username)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(s => s.Password)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(s => s.BornDate)
                .IsRequired();

            this.Property(s => s.ContactNo)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnType("char");

            this.Property(s => s.Address)
                .HasMaxLength(250);

            this.Property(s => s.RegDate)
                .IsRequired(); 
            
            this.HasRequired(e => e.Classes)
                 .WithMany(e => e.Students)
                 .HasForeignKey(s => s.ClassId);

            this.ToTable("Students");

        }
    }
}
