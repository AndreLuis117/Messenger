using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Domain.Entities
{
    public class EmailRecipient : BaseEntity
    {
        public int EmailId { get; set; }
        public int EmailRecipientTypeId { get; set; }
        public string EmailAddress { get; set; }
    }
}
