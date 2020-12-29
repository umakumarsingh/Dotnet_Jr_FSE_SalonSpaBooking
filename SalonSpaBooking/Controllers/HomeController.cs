using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SalonSpaBooking.BusinessLayer.Interfaces;
using SalonSpaBooking.BusinessLayer.ViewModels;
using SalonSpaBooking.Entities;
using SalonSpaBooking.Models;

namespace SalonSpaBooking.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Creating Referance variable of ISalonSpaServices and injecting in controller constructor.
        /// </summary>
        private readonly ISalonSpaServices _salonSpaServices;
        public HomeController(ISalonSpaServices salonSpaServices)
        {
            _salonSpaServices = salonSpaServices;
        }
        /// <summary>
        /// Show list of Services Plan and navigate on Plan by Plan Id and find plan by Title.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="search"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public async Task<IActionResult> Index(int? id, string search, int page = 1)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Show the full plan Details.
        /// </summary>
        /// <param name="PlanId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Details(int PlanId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Gat a salon appointment, Httpget Method.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult SalonAppointment()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Gat a salon appointment, HttpPost Method.
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> SalonAppointment(AppointmentViewModel appointment)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get an appointment information.
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> AppointmentInfo(int appointmentId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
