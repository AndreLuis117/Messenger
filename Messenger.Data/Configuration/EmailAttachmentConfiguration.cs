using Messenger.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Data.Configuration
{
    public class EmailAttachmentConfiguration : IEntityTypeConfiguration<EmailAttachment>
    {
        public void Configure(EntityTypeBuilder<EmailAttachment> builder)
        {
            builder.ToTable("EmailAttachment");

            builder.HasKey(e => e.Id).HasName("EmailAttachmentId");

            builder.Property(e => e.FileName).IsRequired().HasMaxLength(200);
            builder.Property(e => e.ContentType).IsRequired().HasMaxLength(50);
            builder.Property(e => e.FileData).IsRequired();

        }
    }
}
