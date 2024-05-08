using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Domain.Interface
{
    public interface ICarWorkShopRepository
    {
        Task Create(Domain.Entities.CarWorkShop carWorkShop);
    }
}
