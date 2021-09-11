using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client_Tracker.Models;

namespace Client_Tracker.Data.Interfaces

{
    public interface IUserRepo
    {
        IEnumerable<Therapist> GetAll();

        void Create();

        bool SaveChanges();

        void GetById(int id);
    }
}
