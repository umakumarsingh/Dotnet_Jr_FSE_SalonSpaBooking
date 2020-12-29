using Moq;
using SalonSpaBooking.BusinessLayer.Interfaces;
using SalonSpaBooking.BusinessLayer.Services;
using SalonSpaBooking.BusinessLayer.Services.Repository;
using SalonSpaBooking.Entities;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;
namespace SalonSpaBooking.Tests.TestCases
{
    /// <summary>
    /// Creating Referance Variable of Service Interface and Mocking Repository Interface and class
    /// </summary>
    public class FuctionalTests
    {
        private readonly ISalonSpaServices _salonSpaServices;
        public readonly Mock<ISalonSpaRepository> service = new Mock<ISalonSpaRepository>();
        private readonly SalonServices _salonServices;
        private readonly ServicesPlan _servicesPlan;
        private readonly Appointment _appointment;
        public FuctionalTests()
        {
            //Creating New mock Object with value.
            _salonSpaServices = new SalonSpaServices(service.Object);
            _salonServices = new SalonServices
            {
                Id = 1,
                ServicesId = 1,
                Name = "Gentle face wash, Cetaphil Gentle Skin Cleanser",
                Url = "~/Home/Index/1",
                OpenInNewWindow = false,
                Description = "Home Link for Menu bar",
            };
            _servicesPlan = new ServicesPlan
            {
                PlanId = 1,
                PlanName = "Skin Care - Treatments",
                Title = "Spot Lights - Eye Rejuvination",
                Description = "Highlight The Youthfulness Of Your Eyes As You Treat Them With This Rejuvenation Service Enriched With Papaya And Pineapple Enzymes. ",
                Price = 750,
                ServiceId = 1
            };
            _appointment = new Appointment()
            {
                AppointmentId = 1,
                Name = "Uma Kumar",
                Mobile = 9631738145,
                Email = "test_test@iihtc.co.in",
                Takendate = DateTime.Now,
                ServicesPlan = "Spot Lights - Eye Rejuvination",
                Remark = "Light Eye"
            };
        }
        /// <summary>
        /// Creating test output text file that store the result in boolean result
        /// </summary>
        static FuctionalTests()
        {
            if (!File.Exists("../../../../output_revised.txt"))
                try
                {
                    File.Create("../../../../output_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_revised.txt");
                File.Create("../../../../output_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Get all sevices plan to validate all Services Plan
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_GetAllServicesPlan()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.GetAllServicesPlan(_servicesPlan.PlanId));
            var result = await _salonSpaServices.GetAllServicesPlan(_servicesPlan.PlanId);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Validate_GetAllServicesPlan=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for get services plan by Plan Id, if not exists test failed or passesd if its true.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetServicesPlanById()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.GetServicesPlanById(_servicesPlan.PlanId)).ReturnsAsync(_servicesPlan);
            var result = await _salonSpaServices.GetServicesPlanById(_servicesPlan.PlanId);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetServicesPlanById=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for get services plan by Title, if not exists test failed or passesd if its true.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_ServicesPlanByTitle()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.ServicesPlanByTitle(_servicesPlan.Title));
            var result = await _salonSpaServices.ServicesPlanByTitle(_servicesPlan.Title);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_ServicesPlanByTitle=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for book a salon appointment id return async return _appointment object
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Take_SalonAppointment()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.SalonAppointment(_appointment)).ReturnsAsync(_appointment);
            var result = await _salonSpaServices.SalonAppointment(_appointment);
            //Assertion
            if(result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Take_SalonAppointment=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for get services plan by Plan Id, if not exists test failed or passesd if its true.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetAppointmentById()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.GetAppointmentById(_appointment.AppointmentId)).ReturnsAsync(_appointment);
            var result = await _salonSpaServices.GetAppointmentById(_appointment.AppointmentId);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetAppointmentById=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for get all Salon Services Plan
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetAllSalonServicesPlan()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.SalonServicesPlan());
            var result = _salonSpaServices.SalonServicesPlan();
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetAllSalonServicesPlan=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Get Salon Services List for menu
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_SalonServicesList()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.SalonServicesList());
            var result = _salonSpaServices.SalonServicesList();
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_SalonServicesList=" + res + "\n");
            return res;
        }
    }
}
