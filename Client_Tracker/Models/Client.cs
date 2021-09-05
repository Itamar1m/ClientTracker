using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Client_Tracker.Models
{
    public class Client
    {
         
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [Column(TypeName = "nvarchar(20)")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        [Column(TypeName = "nvarchar(20)")]
        public string LastName { get; set; }

        public List<Appointment> Appointments { get; set; }

        public bool IsClient { get; set; }

        [Required]
        [MaxLength(30)]
        [Column(TypeName = "nvarchar(20)")]
        public string DateOfBirth{ get; set; }

        

 

    }
}
