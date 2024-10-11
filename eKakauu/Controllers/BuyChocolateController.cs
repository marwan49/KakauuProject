using eKakauu.Data;
using eKakauu.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eKakauu.Controllers
{
    public class BuyChocolateController : Controller
    {
        private readonly IChocolateService _service;

        public BuyChocolateController(IChocolateService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var AllChocolates = await _service.GetAll();
            return View(AllChocolates);
        }
    }
}