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
    public class EmailRecipientTypeConfiguration : IEntityTypeConfiguration<EmailRecipientType>
    {
        public void Configure(EntityTypeBuilder<EmailRecipientType> builder)
        {
            builder.ToTable("EmailRecipientType");

            builder.HasKey(e => e.Id).HasName("EmailRecipientTypeId");

            builder.Property(e => e.EmailRecipientTypeCode).IsRequired().HasMaxLength(50);
        }
    }
}
