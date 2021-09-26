using Client_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client_Tracker.Data.Interfaces
{
   public interface IClientRepo
    {
        void Create(Client client);
        bool SaveChanges();
    }
}
