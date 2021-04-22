using SMS.BLL.Abstracts;
using SMS.DAL.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        private readonly IEntityRepository<T> entityRepository;

        public GenericManager(IEntityRepository<T> entityRepository)
        {
            this.entityRepository = entityRepository;
        }

        public T Add(T entity)
        {
            return entityRepository.Add(entity);
        }

        public T Get(int id)
        {
            return entityRepository.Get(id);
        }

        public List<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return entityRepository.GetAll(predicate);
        }

        public List<T> GetAll()
        {
            return entityRepository.GetAll();
        }

        public T UpdateOrDelete(T entity)
        {
            return entityRepository.UpdateOrDelete(entity);
        }
    }
}
