﻿using DemoMOMO_nhom2.Models;
using DemoMOMO_nhom2.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoMOMO_nhom2.Controllers
{
    public class BrandController : Controller
    {
        private readonly DataContext _dataContext;
        public BrandController(DataContext context)
        {
            _dataContext = context;
        }
        public async Task<IActionResult> Index(string Slug = "")
        {
            BrandModel brand = _dataContext.Brands.Where(c => c.Slug == Slug).FirstOrDefault();
            if ( brand == null) return RedirectToAction("Index");
            var productsByBrand = _dataContext.Products.Where(c => c.BrandId == brand.Id);
            return View(await productsByBrand.OrderByDescending(p => p.Id).ToListAsync());
        }
    }
}
