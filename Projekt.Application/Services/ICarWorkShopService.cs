using Projekt.Domain.Entities;

namespace Projekt.Application.Services
{
    public interface ICarWorkShopService
    {
        Task Create(CarWorkShop carWorkShop);
    }
}