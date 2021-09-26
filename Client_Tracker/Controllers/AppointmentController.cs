using Client_Tracker.Data.Interfaces;
using Client_Tracker.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client_Tracker.Controllers
{
    [Route("api/appointments")]
    [ApiController]
    public class AppointmentController : GenericController<Appointment>
    {
        public AppointmentController(IGenericRepo<Appointment> generic) : base(generic)

        {
        }

    }
}
