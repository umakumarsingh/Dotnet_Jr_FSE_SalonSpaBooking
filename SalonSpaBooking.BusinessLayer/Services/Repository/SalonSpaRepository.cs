using Microsoft.EntityFrameworkCore;
using SalonSpaBooking.DataLayer;
using SalonSpaBooking.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonSpaBooking.BusinessLayer.Services.Repository
{
    public class SalonSpaRepository : ISalonSpaRepository
    {
        /// <summary>
        /// Creating Referance variable of SalonSpaDbContext and injecting in SalonSpaRepository Constructor
        /// </summary>
        private readonly SalonSpaDbContext _salonContext;
        public SalonSpaRepository(SalonSpaDbContext salonSpaDbContext)
        {
            _salonContext = salonSpaDbContext;
        }
        /// <summary>
        /// Get Salon Services Plan for Main Page
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ServicesPlan> SalonServicesPlan()
        {
            var plan = _salonContext.ServicesPlans.OrderByDescending(x => x.PlanName).ToList();
            return plan;
        }
        /// <summary>
        /// Get all services Plan on Main Page and find the plan by Plan Id
        /// </summary>
        /// <param name="PlanId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ServicesPlan>> GetAllServicesPlan(int? PlanId)
        {
            if(PlanId == null)
            {
                var plan = await _salonContext.ServicesPlans
                    .OrderByDescending(x => x.PlanName).ToListAsync();
                return plan;
            }
            else
            {
                var plan = await _salonContext.ServicesPlans.Where(x => x.PlanId == PlanId)
                    .OrderByDescending(x => x.PlanName).ToListAsync();
                return plan;
            }
        }
        /// <summary>
        /// Get Plan By Id.
        /// </summary>
        /// <param name="PlanId"></param>
        /// <returns></returns>
        public async Task<ServicesPlan> GetServicesPlanById(int PlanId)
        {
            var plan = await _salonContext.ServicesPlans.Where(x => x.PlanId == PlanId)
                    .OrderByDescending(x => x.PlanName).FirstOrDefaultAsync();
            return plan;
        }
        /// <summary>
        /// Bok a Salon Appointment by providing name and few details.
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        public async Task<Appointment> SalonAppointment(Appointment appointment)
        {
            _salonContext.Appointments.Add(appointment);
            await _salonContext.SaveChangesAsync();
            return appointment;
        }
        /// <summary>
        /// get a list of salon services for display on Menu Bar
        /// </summary>
        /// <returns></returns>
        public IList<SalonServices> SalonServicesList()
        {
            var serviceList = _salonContext.Servicess.ToList();
            return serviceList;
        }
        /// <summary>
        /// Find a salon services by Plan Title and show on Index Page
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ServicesPlan>> ServicesPlanByTitle(string title)
        {
            var result = await _salonContext.ServicesPlans.
                Where(x => x.Title == title).Take(10).ToListAsync();
            return result;
        }
        /// <summary>
        /// Book Salon apoointment and get appointment Id
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        public async Task<Appointment> GetAppointmentById(int appointmentId)
        {
            var result = await _salonContext.Appointments
                                 .Where(x => x.AppointmentId == appointmentId)
                                 .FirstOrDefaultAsync();
            return result;
        }
    }
}
