using CarWorkshop.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Infrastructure.Seeders
{
    public class CarWorkshopSeeder
    {
        private readonly CarWorkshopDbContext _dbContext;
        public CarWorkshopSeeder(CarWorkshopDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if(await _dbContext.Database.CanConnectAsync())
            {
                if(!_dbContext.CarWorkshops.Any())
                {
                    var MercedesDealer = new Domain.Entities.CarWorkshop()
                    {
                        Name = "Auto Idea Dealer Mercedes-Benz",
                        Description = "Salon samochodowy Mercedes-Benz",
                        ContactDetails = new()
                        {
                            City = "Warszawa",
                            Street = "Brukowa 46",
                            PostalCode = "05-092",
                            PhoneNumber = "+800 200 200"
                        }
                    };
                    MercedesDealer.EncodeName();

                    _dbContext.CarWorkshops.Add(MercedesDealer);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
