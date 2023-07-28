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
    public class EmailStatusConfiguration : IEntityTypeConfiguration<EmailStatus>
    {
        public void Configure(EntityTypeBuilder<EmailStatus> builder)
        {
            builder.ToTable("EmailStatus");

            builder.HasKey(e => e.Id).HasName("EmailStatusId");

            builder.Property(e => e.StatusName).IsRequired().HasMaxLength(50);
        }
    }
}
