using eKakauu.Data;
using eKakauu.Data.Services;
using eKakauu.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eKakauu.Controllers
{
    public class ChocolatesController : Controller
    {
        private readonly IChocolateService _service;

        public ChocolatesController(IChocolateService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var AllChocolates = await _service.GetAll();
            return View(AllChocolates);
        }

        //Get: Chocolates/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("imageURL,Name,ChocolateProcessing," +
            "Flavor,Validity,price,ChocolateTypek")] Chocolate chocolate)
        {
            chocolate.CocoaId = 1;
            if (!ModelState.IsValid)
            {
                return View(chocolate);
            }
            _service.Add(chocolate);
            return RedirectToAction(nameof(Index));
        }

    }
}
