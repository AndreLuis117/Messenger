using Messenger.Data.Context;
using Messenger.Domain.Entities;
using Messenger.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Data.Repository
{
    public class EmailRepository : BaseRepository<Email>, IEmailRepository
    {
        public EmailRepository(MessengerContext context) : base(context)
        {
        }

        public IEnumerable<Email> FindAllEmailsToSend()
        {
            var result = Find(x => x.Status.Id == 1);

            return result;
        }
    }
}
