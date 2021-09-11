using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Client_Tracker.Models
{
    public class Therapist
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [Column(TypeName = "nvarchar(30)")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        [Column(TypeName = "nvarchar(30)")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(30)]
        [Column(TypeName = "nvarchar(20)")]
        public string Email { get; set; }

        public List<Client> Clients { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; } = true;

        public List<Appointment> appointments { get; set; }


  

    }
}
