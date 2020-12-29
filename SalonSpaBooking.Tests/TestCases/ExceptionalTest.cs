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
    public class ExceptionalTest
    {
        private readonly ISalonSpaServices _salonSpaServices;
        public readonly Mock<ISalonSpaRepository> service = new Mock<ISalonSpaRepository>();
        private readonly SalonServices _salonServices;
        private readonly ServicesPlan _servicesPlan;
        private readonly Appointment _appointment;
        public ExceptionalTest()
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
        static ExceptionalTest()
        {
            if (!File.Exists("../../../../output_exception_revised.txt"))
                try
                {
                    File.Create("../../../../output_exception_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_exception_revised.txt");
                File.Create("../../../../output_exception_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Test for verify invalid Salon appointment Booking
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_InvlidAppointmentbooking()
        {
            //Arrange
            bool res = false;
            var appointment = new Appointment()
            {
                AppointmentId = 1,
                Name = "Uma Kumar",
                Mobile = 9631738145,
                Takendate = DateTime.Now,
                ServicesPlan = "Spot Lights - Eye Rejuvination",
                Remark = "Light Eye"
            };
            appointment = null;
            //Act
            service.Setup(repo => repo.SalonAppointment(appointment)).ReturnsAsync(appointment = null);
            var result = await _salonSpaServices.SalonAppointment(appointment);
            if (result == null)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "Testfor_Validate_InvlidAppointmentbooking=" + res + "\n");
            return res;
        }
    }
}
