using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client_Tracker.Data.Interfaces
{
   public interface IGenericRepo<T> where T :class
    {
        IEnumerable<T> GetAll();
        void add(T obj);

    }
}
