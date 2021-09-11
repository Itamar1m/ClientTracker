using Client_Tracker.Data.Interfaces;
using Client_Tracker.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client_Tracker.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //private readonly IUserRepo _users;
        private readonly IGenericRepo<Therapist> _users;

        public UserController(IGenericRepo<Therapist> users)
        {
            _users = users;

        }

        [HttpGet]
        public ActionResult<IEnumerable<Therapist>> GetAll()
        {
            var users = _users.GetAll();
            return Ok(users);
        }

    }
}
