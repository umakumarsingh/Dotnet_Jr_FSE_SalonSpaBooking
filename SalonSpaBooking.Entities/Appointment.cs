using System;
using System.ComponentModel.DataAnnotations;

namespace SalonSpaBooking.Entities
{
    public class Appointment
    {
        [Key]
        [Display(Name = "Appointment Number")]
        public int AppointmentId { get; set; }
        [Required]
        [Display(Name = "Full Name")]
        public string Name { get; set; }
        public long Mobile { get; set; }
        public string Email { get; set; }
        [Required]
        [Display(Name = "Appointment Date")]
        public DateTime Takendate { get; set; }
        [Display(Name = "Services Plan")]
        public string ServicesPlan { get; set; }
        public string Remark { get; set; }
        public virtual SalonServices ServicesTypes { get; set; }
        public virtual ServicesPlan ServicesPlans { get; set; }
    }
}
