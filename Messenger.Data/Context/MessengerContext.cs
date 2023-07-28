using Messenger.Data.Configuration;
using Messenger.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Data.Context
{
    public class MessengerContext : DbContext
    {
        public MessengerContext(DbContextOptions<MessengerContext> options) : base(options)
        {
                
        }

        public DbSet<Email> Emails { get; set; }
        public DbSet<EmailAttachment> EmailAttachments { get; set; }
        public DbSet<EmailRecipient> EmailRecipients { get; set; }
        public DbSet<EmailRecipientType> EmailRecipientTypes { get; set; }
        public DbSet<EmailStatus> EmailStatuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Email>(new EmailConfiguration().Configure);
            modelBuilder.Entity<EmailAttachment>(new EmailAttachmentConfiguration().Configure);
            modelBuilder.Entity<EmailRecipient>(new EmailRecipientConfiguration().Configure);
            modelBuilder.Entity<EmailStatus>(new EmailStatusConfiguration().Configure);
            modelBuilder.Entity<EmailRecipientType>(new EmailRecipientTypeConfiguration().Configure);
        }
    }
}
