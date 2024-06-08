using Microsoft.AspNetCore.Mvc;
using Projekt.Application.Services;

namespace Projekt.Controllers
{
    public class CarWorkShopController : Controller
    {
        private readonly ICarWorkShopService _carWorkshopService;

        public CarWorkShopController(ICarWorkShopService carWorkShopService) 
        {
            _carWorkshopService = carWorkShopService;
        
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Domain.Entities.CarWorkShop carWorkShop)
        {
            await _carWorkshopService.Create(carWorkShop);
            return RedirectToAction(nameof(Create));
        }
    }
}
