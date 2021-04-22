using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.Entity.EntitiesMapping
{
    public class StaffsMap : EntityTypeConfiguration<Staffs>
    {
        public StaffsMap()
        {
            this.HasKey(s => s.Id);

            this.Property(s => s.Firstname)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(s => s.Lastname)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(s => s.IdentityNo)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnType("char");

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

            this.HasRequired(s => s.Roles)
                .WithMany(s => s.Staffs)
                .HasForeignKey(r => r.RoleId);
            this.HasRequired(s => s.Subjects)
                .WithMany(s => s.Staffs)
                .HasForeignKey(r => r.SubjectId);

            this.HasMany(c => c.Classes)
                .WithMany(s => s.Staffs)
                .Map(cs =>
                {
                    cs.MapLeftKey("StaffId");
                    cs.MapRightKey("ClassId");
                    cs.ToTable("StaffClasses");
                });

            this.ToTable("Staffs");
        }
    }
}
