using Messenger.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        void Add(TEntity obj);

        void Delete(int id);

        IList<TEntity> Get();

        TEntity GetById(int id);

        void Update(TEntity obj);
    }
}
