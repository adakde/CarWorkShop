using Projekt.Infrastructure.CarWorkShopDB;

namespace Projekt.Infrastructure.Seeder
{
    public class CarWorkShopSeeder
    {
        private readonly CarWorkShopDBContext _dbContext;
        public CarWorkShopSeeder(CarWorkShopDBContext dBContext) {
            _dbContext = dBContext;
        }
        public async Task Seed()
        {
            if(await _dbContext.Database.CanConnectAsync())
            {
                if(!_dbContext.CarWorkShops.Any())
                {
                    var mazdaASO = new Domain.Entities.CarWorkShop()
                    {
                        Name = "Mazda ASO",
                        Description = "Serwis Mazdy",
                        ContactDetails = new()
                        {
                            City = "Kraków",
                            Street = "Szewska 2",
                            PostalCode = "30-001",
                            PhoneNumber = "+48696969693"
                        }
                    };
                    mazdaASO.EncodeName();
                    _dbContext.CarWorkShops.Add(mazdaASO);
                    await _dbContext.SaveChangesAsync();
                }

            }
        }
    }
}
