using SalonSpaBooking.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalonSpaBooking.BusinessLayer.ViewModels
{
    public class ServicesPlanViewModels
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
        public IEnumerable<ServicesPlan> ServicesPlans { get; set; }
        public int PlanPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount()
        {
            return Convert.ToInt32(Math.Ceiling(ServicesPlans.Count() / (double)PlanPerPage));
        }
        public IEnumerable<ServicesPlan> PaginatedServicesPlan()
        {
            int start = (CurrentPage - 1) * PlanPerPage;
            return ServicesPlans.OrderBy(b => b.PlanId).Skip(start).Take(PlanPerPage);
        }
    }
}
