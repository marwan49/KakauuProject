﻿using eKakauu.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eKakauu.Controllers
{
    public class ChocolatesController : Controller
    {
        private readonly AppDbContext _context;

        public ChocolatesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var AllChocolates = await _context.chocolates.ToListAsync();
            return View(AllChocolates);
        }
    }
}
