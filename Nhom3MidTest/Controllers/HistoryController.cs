using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Nhom3MidTest.Data;

namespace Nhom3MidTest.Controllers
{
    public class HistoryController : Controller
    {
            private readonly CarDealerContext _context;

            public HistoryController(CarDealerContext context)
            {
                _context = context;
            }

            public async Task<IActionResult> Index()
            {
            var data = await _context.History
                    .Include(s => s.Car)
                    .Include(s => s.Customer)
                    .Select(s => new
                    {
                        CustomerId = s.Customer.Id,
                        CustomerName = s.Customer.Name,
                        CustomerBirthDate = s.Customer.BirthDate,
                        CarMake = s.Car.Make,
                        CarModel = s.Car.Model
                    })
                    .ToListAsync();

                return View(data);
            }
        

    }
}
