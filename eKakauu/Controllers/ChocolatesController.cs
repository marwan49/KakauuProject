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
            var allChocolates = await _service.GetAllAsync();
            return View(allChocolates);
        }

        // Get: Chocolates/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("imageURL,Name,ChocolateProcessing,Flavor,Validity,price,ChocolateTypek")] Chocolate chocolate)
        {
            chocolate.BrandId = 1; 
            if (!ModelState.IsValid)
            {
                return View(chocolate);
            }
            await _service.AddAsync(chocolate);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var chocolateDetails = await _service.GetByIdAsync(id);

            if (chocolateDetails == null)
                return View("NotFound");

            return View(chocolateDetails);
        }

        // Get: Chocolates/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var chocolateDetails = await _service.GetByIdAsync(id);

            if (chocolateDetails == null)
                return View("NotFound");

            return View(chocolateDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,imageURL,Name,ChocolateProcessing,Flavor,Validity,price,ChocolateTypek")] Chocolate chocolate)
        {
            chocolate.BrandId = 1; 
            if (!ModelState.IsValid)
            {
                return View(chocolate);
            }
            await _service.UpdateAsync(id, chocolate);
            return RedirectToAction(nameof(Index));
        }

        // Get: Chocolates/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var chocolateDetails = await _service.GetByIdAsync(id);

            if (chocolateDetails == null)
                return View("NotFound");

            return View(chocolateDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chocolateDetails = await _service.GetByIdAsync(id);

            if (chocolateDetails == null)
                return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
