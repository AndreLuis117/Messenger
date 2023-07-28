using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messenger.Domain.Entities;


namespace Messenger.Data.Configuration
{
    public class EmailConfiguration : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.ToTable("Email");

            builder.HasKey(e => e.Id).HasName("EmailId");

            builder.Property(e => e.Subject).IsRequired().HasMaxLength(200);
            builder.Property(e => e.Body).IsRequired().HasMaxLength(4000);
            builder.Property(e => e.SentDate).IsRequired(false);
            builder.Property(e => e.CreateDate).IsRequired();
            builder.Property(e => e.StatusId).IsRequired();

            builder.HasOne(e => e.Status)
                   .WithMany()
                   .HasForeignKey(e => e.StatusId);
        }
    }
}
