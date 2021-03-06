using Client_Tracker.Models;
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


        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public T Create(T obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            table.Add(obj);
            return obj;
        }

        public T GetById(int Id)
        { 
    
            return table.Find(Id);
        }
    }
}
