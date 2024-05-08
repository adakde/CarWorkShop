using Microsoft.AspNetCore.Mvc;

namespace Projekt.Controllers
{
    public class CarWorkShopController : Controller
    {

        [HttpPost]
        public IActionResult Create(Domain.Entities.CarWorkShop carWorkShop)
        {
            return View();
        }
    }
}
