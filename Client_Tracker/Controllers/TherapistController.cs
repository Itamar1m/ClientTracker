using Client_Tracker.Data.Interfaces;
using Client_Tracker.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client_Tracker.Controllers
{
    [Route("api/therapists")]
    [ApiController]
    public class TherapistController : GenericController<Therapist>
    {
        public TherapistController(IGenericRepo<Therapist> generic) : base(generic)

        {
        }

    }
}
