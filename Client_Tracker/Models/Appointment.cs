using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Client_Tracker.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Client Client { get; set; }

        [Required]
        [Column(TypeName ="varchar(20)")]
        public string Date { get; set; }

        [Required]
        public TimeSpan Time { get; set; }

        [Required]
        public User Therapist { get; set; }

        [Required]
        public Location Location { get; set; }

        public DateTime CreatedDate { get; set; } //Has default

        public bool? Attended { get; set; }
    }
}
