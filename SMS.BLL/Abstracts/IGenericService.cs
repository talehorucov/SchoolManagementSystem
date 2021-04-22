using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL.Abstracts
{
    public interface IGenericService<T> where T : class
    {
        List<T> GetAll(Expression<Func<T,bool>> predicate);
        List<T> GetAll();
        T Get(int id);
        T Add(T entity);
        T UpdateOrDelete(T entity);
    }
}
