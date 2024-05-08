using Projekt.Infrastructure.CarWorkShopDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt;
namespace Projekt.Infrastructure.Repositories
{
    internal class CarWorkShopRepository : ICarWorkShopRepository
    {
        private readonly CarWorkShopDBContext dBContext;

        public CarWorkShopRepository(CarWorkShopDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public async Task Create(Domain.Entities.CarWorkShop carWorkShop) 
        {
            _dbContext.Add(carWorkShop);
            await _dbContext.SaveChangesAsync();
        }
    }
}
