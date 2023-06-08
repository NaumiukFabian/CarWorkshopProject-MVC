using CarWorkshop.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarWorkshop.Controllers
{
    public class CarWorkshopController : Controller
    {
        private readonly ICarWorkshopService _carWorkshopService;

        public CarWorkshopController(ICarWorkshopService carWorkshopService)
        {
            _carWorkshopService = carWorkshopService;
        }
        [HttpPost]
        public async Task<IActionResult> Creat(Domain.Entities.CarWorkshop carWorkshop)
        {
            await _carWorkshopService.Creat(carWorkshop);
            return RedirectToAction(nameof(Creat));
        }
    }
}
