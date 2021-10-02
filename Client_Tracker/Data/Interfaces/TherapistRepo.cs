using Client_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client_Tracker.Data.Interfaces
{
    public class TherapistRepo:ITherapistRepo
    {
        private readonly ClientTrackerContext _context;

        public TherapistRepo(ClientTrackerContext context)
        {
            _context = context;

        }

        public  Therapist GetByDetail(string firstName)
        {
            Therapist therapist = new Therapist();
            List<Client> clients = new List<Client>();

            therapist = _context.Therapists.FirstOrDefault(t => t.FirstName ==firstName);
            clients = _context.Clients.Where(c => c.therapist.Id == therapist.Id).ToList();
            //var b = _context.Therapists.Find(firstName); //Finds by primary key

            return therapist;
        }
    }
}
