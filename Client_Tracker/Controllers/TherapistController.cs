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
        private readonly ITherapistRepo _repo;

        public TherapistController(IGenericRepo<Therapist> generic, ITherapistRepo therapistRepo) : base(generic)
        {
            _repo = therapistRepo;

        }

        [HttpGet]
        [Route("get{firstName}")]
        public new ActionResult GetFull(string firstName)

        {
            Therapist therapist = _repo.GetByDetail(firstName);
            return Ok(therapist);



        }
    }
}
