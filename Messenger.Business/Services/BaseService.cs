using Messenger.Domain.Entities;
using Messenger.Domain.Interfaces.Repositories;
using Messenger.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Business.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        private readonly IBaseRepository<TEntity> _baseRepository;

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public void Add(TEntity obj)
        {
            _baseRepository.Insert(obj);
        }

        public void Delete(int id) => _baseRepository.Delete(id);

        public IList<TEntity> Get() => _baseRepository.Find();

        public TEntity GetById(int id) => _baseRepository.Find(id);

        public void Update(TEntity obj)
        {
            _baseRepository.Update(obj);
        }

    }
}
