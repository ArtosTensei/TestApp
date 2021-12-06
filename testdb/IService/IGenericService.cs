using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testdb.IService
{
    public interface IGenericService<T> where T : class
    {
        List<T> GetAll();
        T GetById(object id);
        void Insert(T obj);
        void Delete(object id); 
    }
}
