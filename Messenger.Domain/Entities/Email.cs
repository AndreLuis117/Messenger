using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Domain.Entities
{
    public class Email : BaseEntity
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime? SentDate { get; set; }
        public DateTime CreateDate { get; set; }
        public int StatusId { get; set; }

        // Propriedade de navegação para o status do e-mail
        public EmailStatus Status { get; set; }
    }
}
