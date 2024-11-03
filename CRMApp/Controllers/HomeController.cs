using Microsoft.AspNetCore.Mvc;
using CRMApp.Models;
using MongoDB.Driver; // Ensure this is included
using System.Collections.Generic;
using System.Threading.Tasks;

public class HomeController : Controller
{
    private readonly CRMAppContext _context;

    public HomeController()
    {
        _context = new CRMAppContext();
    }

    public async Task<IActionResult> Index() // Make Index async
    {
        var customers = await _context.Customers.Find(_ => true).ToListAsync(); // Use ToListAsync
        return View(customers);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Customer customer) // Make Create async
    {
        if (ModelState.IsValid)
        {
            await _context.Customers.InsertOneAsync(customer); // Use InsertOneAsync
            return RedirectToAction("Index");
        }
        return View(customer);
    }
}
