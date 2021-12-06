using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testdb.IService;
using testdb.Models;

namespace testdb.Service
{ 
    public class GenericRepository<T> : IGenericService<T> where T : class
    {
        private testdbContext _context;
        private DbSet<T> table;

        public GenericRepository(testdbContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        public List<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Delete(object id)
        {
            T exists = table.Find(id);
            table.Remove(exists);
        }
    }
}
