using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalonSpaBooking.Entities;
using System;
using System.Linq;

namespace SalonSpaBooking.DataLayer
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SalonSpaDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<SalonSpaDbContext>>()))
            {
                if (context.Servicess.Any())
                {
                    return;   // Data was already seeded
                }
                context.Servicess.AddRange(
                new SalonServices
                {
                    Id = 1,
                    ServicesId = 0,
                    Name = "All Plan",
                    Url = "~/",
                    OpenInNewWindow = false
                },
                new SalonServices
                {
                    Id = 2,
                    ServicesId = 1,
                    Name = "SKIN",
                    Url = "~/Home/Index/1",
                    OpenInNewWindow = false
                },
                new SalonServices
                {
                    Id = 3,
                    ServicesId = 2,
                    Name = "HAIR",
                    Url = "~/Home/Index/2",
                    OpenInNewWindow = false
                },
                new SalonServices
                {
                    Id = 4,
                    ServicesId = 3,
                    Name = "MAKEUP",
                    Url = "~/Home/Index/3",
                    OpenInNewWindow = false
                },
                new SalonServices
                {
                    Id = 5,
                    ServicesId = 4,
                    Name = "HANDS & FEET",
                    Url = "~/Home/Index/4",
                    OpenInNewWindow = false
                },
                new SalonServices
                {
                    Id = 6,
                    ServicesId = 5,
                    Name = "SPA",
                    Url = "~/Home/Index/5",
                    OpenInNewWindow = false
                });
                context.SaveChanges();
                if(context.ServicesPlans.Any())
                {
                    return;
                }
                context.ServicesPlans.AddRange(
                    new ServicesPlan
                    {
                        PlanId = 1,
                        PlanName = "Skin Care - Treatments",
                        Title = "Spot Lights - Eye Rejuvination",
                        Description = "Highlight The Youthfulness Of Your Eyes As You Treat Them With This Rejuvenation Service Enriched With Papaya And Pineapple Enzymes. ",
                        Price = 750,
                        ServiceId = 1
                    },
                    new ServicesPlan
                    {
                        PlanId = 2,
                        PlanName = "Skin Care - Treatments",
                        Title = "Spot Lights - Organic Eye- Lip Treatment",
                        Description = "Reduce Dryness From Your Eyes And Lips With A Treatment Designed To Transform",
                        Price = 1250,
                        ServiceId = 1
                    });
                context.SaveChanges();
            }
        }
    }
}
