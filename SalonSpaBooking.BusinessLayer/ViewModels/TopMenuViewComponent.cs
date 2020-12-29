using Microsoft.AspNetCore.Mvc;
using SalonSpaBooking.BusinessLayer.Interfaces;
using System.Threading.Tasks;

namespace SalonSpaBooking.BusinessLayer.ViewModels
{
    public class TopMenuViewComponent : ViewComponent
    {
        private readonly ISalonSpaServices _salonSpaServices;

        /// <summary>
        /// Show the list of salon services on Menu Bar
        /// </summary>
        /// <param name="salonSpaServices"></param>
        public TopMenuViewComponent(ISalonSpaServices salonSpaServices)
        {
            _salonSpaServices = salonSpaServices;
        }
        /// <summary>
        /// Invoke method as async while displaying menu bar.
        /// </summary>
        /// <returns></returns>
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = _salonSpaServices.SalonServicesList();
            return await Task.FromResult((IViewComponentResult)View("Default", model));
        }
    }
}
