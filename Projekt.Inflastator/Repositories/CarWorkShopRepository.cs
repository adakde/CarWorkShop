using Projekt.Infrastructure.CarWorkShopDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt;
using Projekt.Domain.Interface;

namespace Projekt.Infrastructure.Repositories
{
    internal class CarWorkShopRepository : ICarWorkShopRepository
    {
        private readonly CarWorkShopDBContext _dBContext;

        public CarWorkShopRepository(CarWorkShopDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public async Task Create(Domain.Entities.CarWorkShop carWorkShop)
        {
            _dBContext.Add(carWorkShop);
            await _dBContext.SaveChangesAsync();
        }
    }
}
