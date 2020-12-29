using SalonSpaBooking.BusinessLayer.Interfaces;
using SalonSpaBooking.BusinessLayer.Services.Repository;
using SalonSpaBooking.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalonSpaBooking.BusinessLayer.Services
{
    public class SalonSpaServices : ISalonSpaServices
    {
        /// <summary>
        /// Creating referance variable of ISalonSpaRepository and injecting in SalonSpaServices constructor
        /// </summary>
        private readonly ISalonSpaRepository _salonSpaRepository;
        public SalonSpaServices(ISalonSpaRepository salonSpaRepository)
        {
            _salonSpaRepository = salonSpaRepository;
        }
        /// <summary>
        /// Get all services Plan on Main Page and find the plan by Plan Id
        /// </summary>
        /// <param name="PlanId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ServicesPlan>> GetAllServicesPlan(int? PlanId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Book Salon apoointment and get appointment Id
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        public async Task<Appointment> GetAppointmentById(int appointmentId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get a services plan by id
        /// </summary>
        /// <param name="PlanId"></param>
        /// <returns></returns>
        public async Task<ServicesPlan> GetServicesPlanById(int PlanId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Book a salon appointment for salon.
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        public async Task<Appointment> SalonAppointment(Appointment appointment)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get alist of salon services list
        /// </summary>
        /// <returns></returns>
        public IList<SalonServices> SalonServicesList()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get Salon Services Plan for Main Page
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ServicesPlan> SalonServicesPlan()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Find a services by Plan Title.
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ServicesPlan>> ServicesPlanByTitle(string title)
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}
