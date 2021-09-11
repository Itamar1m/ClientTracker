using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client_Tracker.Data.Interfaces
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly ClientTrackerContext _context;
        private DbSet<T> table;

        public GenericRepo(ClientTrackerContext context)
        {
            _context = context;
            table = _context.Set<T>();

        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public void add(T obj)
        {
            throw new NotImplementedException();
        }

     
    }
}
