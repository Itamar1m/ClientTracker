using Client_Tracker.Data.Interfaces;
using Client_Tracker.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client_Tracker.Controllers
{
    [Route("api/clients")]
    [ApiController]
    public class ClientController : GenericController<Client>
    {
        public ClientController(IGenericRepo<Client> generic) : base(generic)
        {

        }

    

    }
}
