using Client_Tracker.Data.Interfaces;
using Client_Tracker.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client_Tracker.Controllers
{
    [Route("api/all")]
    [ApiController]
    public class GenericController<T> : ControllerBase where T : class
    {
        //private readonly IUserRepo _users;
        private readonly IGenericRepo<T> _generic;

        public GenericController(IGenericRepo<T> generic)
        {
            _generic = generic;
        }

        [HttpGet]
        public ActionResult<IEnumerable<T>> GetAll()
        {
            var users = _generic.GetAll();
            return Ok(users);
        }

        [HttpGet("1")]
        public ActionResult test()
        {
            return Ok();
        }

    }
}
