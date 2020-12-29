using System.ComponentModel.DataAnnotations;

namespace SalonSpaBooking.Entities
{
    public class ServicesPlan
    {
        [Key]
        public int PlanId { get; set; }
        [Required]
        [Display(Name ="Plan Name")]
        public string PlanName { get; set; }
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int ServiceId { get; set; }
    }
}
