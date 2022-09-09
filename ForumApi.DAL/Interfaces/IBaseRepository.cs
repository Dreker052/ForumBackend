using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApi.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        void Create(T entity);

        T Get(string id);

        IEnumerable<T> Select();

        void Delete(string id);

        T Edit(string id, T entity);
    }
}
