using Projekt.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Application.Services
{
    public class CarWorkShopService : ICarWorkShopService
    {
        private readonly ICarWorkShopRepository _carWorkShopRepository;
        public CarWorkShopService(ICarWorkShopRepository carWorkShopRepository)
        {
            _carWorkShopRepository = carWorkShopRepository;
        }

        public async Task Create(Domain.Entities.CarWorkShop carWorkShop)
        {
            carWorkShop.EncodeName();
            await _carWorkShopRepository.Create(carWorkShop);
        }
    }
}
