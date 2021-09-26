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
        private readonly IClientRepo _repository;

        public ClientController(IGenericRepo<Client> generic, IClientRepo repository) : base(generic)
        {
            _repository = repository;
        }



        [HttpPost]
        [Route("create")]        
        public ActionResult CreateClient(Client client)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }
            else
            {               
                _repository.Create(client);
                _repository.SaveChanges();               
            }

            return Ok(client);


        }




    }
}
