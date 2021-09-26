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

        public  List<Therapist> GetById(string firstName)
        {
            List<Therapist> therapists = new List<Therapist>(); ;

            therapists = _context.Therapists.Where(t => t.LastName == firstName).ToList();
            var b = _context.Therapists.Find(firstName); //Finds by primary key
            return therapists;
        }
    }
}
