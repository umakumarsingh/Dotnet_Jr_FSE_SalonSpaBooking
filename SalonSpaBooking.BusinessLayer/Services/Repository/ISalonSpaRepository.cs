using SalonSpaBooking.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalonSpaBooking.BusinessLayer.Services.Repository
{
    public interface ISalonSpaRepository
    {
        //List of method to perform all related operation
        Task<IEnumerable<ServicesPlan>> GetAllServicesPlan(int? PlanId);
        Task<ServicesPlan> GetServicesPlanById(int PlanId);
        Task<IEnumerable<ServicesPlan>> ServicesPlanByTitle(string title);
        Task<Appointment> SalonAppointment(Appointment appointment);
        Task<Appointment> GetAppointmentById(int appointmentId);
        IEnumerable<ServicesPlan> SalonServicesPlan();
        IList<SalonServices> SalonServicesList();
    }
}
