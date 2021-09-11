using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client_Tracker.Models;

namespace Client_Tracker.Data.Interfaces
{

   
    public class UserRepo:IUserRepo
    {
        private readonly ClientTrackerContext _context;
           
        public UserRepo(ClientTrackerContext context)
        {
            _context = context;
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Therapist> GetAll()
        {
           
            return _context.Therapists.ToList();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
