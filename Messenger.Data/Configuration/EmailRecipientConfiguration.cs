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
    public class EmailRecipientConfiguration : IEntityTypeConfiguration<EmailRecipient>
    {
        public void Configure(EntityTypeBuilder<EmailRecipient> builder)
        {
            builder.ToTable("EmailRecipient");

            builder.HasKey(e => e.Id).HasName("EmailRecipientId");
            
            builder.Property(e => e.EmailAddress).IsRequired().HasMaxLength(100);

        }
    }
}
