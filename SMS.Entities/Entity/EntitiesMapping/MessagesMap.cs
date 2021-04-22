using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.Entity.EntitiesMapping
{
    public class MessagesMap: EntityTypeConfiguration<Messages>
    {
        public MessagesMap()
        {
            this.HasKey(m => m.Id);

            this.Property(m => m.Title)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(m => m.Text)
                .IsRequired()
                .HasMaxLength(500);

            this.HasRequired(m => m.Staffs)
                .WithMany(m => m.Messages)
                .HasForeignKey(m => m.StaffId);
            this.HasRequired(m => m.Classes)
                .WithMany(m => m.Messages)
                .HasForeignKey(m => m.ClassId);

            this.ToTable("Messages");
        }
    }
}
