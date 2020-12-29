using Moq;
using SalonSpaBooking.BusinessLayer.Interfaces;
using SalonSpaBooking.BusinessLayer.Services;
using SalonSpaBooking.BusinessLayer.Services.Repository;
using SalonSpaBooking.Entities;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xunit;

namespace SalonSpaBooking.Tests.TestCases
{
    public class BoundaryTest
    {
        private readonly ISalonSpaServices _salonSpaServices;
        public readonly Mock<ISalonSpaRepository> service = new Mock<ISalonSpaRepository>();
        private readonly SalonServices _salonServices;
        private readonly ServicesPlan _servicesPlan;
        private readonly Appointment _appointment;
        public BoundaryTest()
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
        static BoundaryTest()
        {
            if (!File.Exists("../../../../output_boundary_revised.txt"))
                try
                {
                    File.Create("../../../../output_boundary_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_boundary_revised.txt");
                File.Create("../../../../output_boundary_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Test to validate appointment is return valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_ValidateAppointmentId()
        {
            //Arrange
            bool res = false;
            //Act
            service.Setup(repo => repo.SalonAppointment(_appointment)).ReturnsAsync(_appointment);
            var result = await _salonSpaServices.SalonAppointment(_appointment);
            if (result.AppointmentId == _appointment.AppointmentId)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "Testfor_ValidateAppointmentId=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Validate Mobile Number
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_ValidateMobileNumber()
        {
            //Arrange
            bool res = false;
            //Act
            service.Setup(repo => repo.SalonAppointment(_appointment)).ReturnsAsync(_appointment);
            var result = await _salonSpaServices.SalonAppointment(_appointment);
            var actualLength = _appointment.Mobile.ToString().Length;
            if (result.Mobile.ToString().Length == actualLength)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "Testfor_ValidateMobileNumber=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Testfor_ValidEmail used for test the valid Email
        /// </summary>
        [Fact]
        public async void Testfor_ValidEmail()
        {
            //Arrange
            bool res = false;
            //Act
            bool isEmail = Regex.IsMatch(_appointment.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            //Assert
            Assert.True(isEmail);
            res = isEmail;
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "Testfor_ValidEmail=" + res + "\n");
        }
    }
}
