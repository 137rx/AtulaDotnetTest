using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AtulaDotnetTest.Models;
using AtulaDotnetTest.Data;

namespace AtulaDotnetTest.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;


    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var products = _context.Products.ToList(); 
        if (products == null)
        {
            TempData["ErrorMessage"] = "No products found.";
            return View(new List<Product>()); 
        }
        return View(products);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
