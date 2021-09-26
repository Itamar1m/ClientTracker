using Client_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client_Tracker.Data.Interfaces
{
    public class ClientRepo : IClientRepo
    {
        private readonly ClientTrackerContext _context;

        public ClientRepo(ClientTrackerContext context)
        {
            _context = context;

        }
        public void Create(Client client)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }
            else
            {
                Therapist therapist = new Therapist();
                GenericRepo<Therapist> th = new GenericRepo<Therapist>(_context);
                therapist = th.GetById(2);
                client.therapist = therapist;
             
                _context.Clients.Add(client);
    

            }

     

        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
