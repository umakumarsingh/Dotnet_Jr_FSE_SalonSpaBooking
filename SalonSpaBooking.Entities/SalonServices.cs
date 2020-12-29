using System.ComponentModel.DataAnnotations;

namespace SalonSpaBooking.Entities
{
    public class SalonServices
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ServicesId { get; set; }
        public string Name { get; set; }
        [Required]
        public string Url { get; set; }
        public bool OpenInNewWindow { get; set; }
        public string Description { get; set; }
    }
}
