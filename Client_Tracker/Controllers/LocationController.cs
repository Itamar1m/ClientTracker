using Client_Tracker.Data.Interfaces;
using Client_Tracker.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client_Tracker.Controllers
{
    [Route("api/location")]
    [ApiController]
    public class LocationController : GenericController<Location>
    {
        public LocationController(IGenericRepo<Location> generic) : base(generic)
        {

        }

    }
}
