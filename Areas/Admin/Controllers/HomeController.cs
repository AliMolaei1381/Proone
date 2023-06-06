using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pro.Models;
using sample.Models.Context;

namespace Pro.Areas.Admin.Controllers;
[Area("Admin")]

public class HomeController : Controller
{

   private readonly Context_Db db;

   
    private readonly ILogger<HomeController> _logger;

    public HomeController(Context_Db _db)
    {
        db=_db;
       
    }

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

  
  
    public IActionResult Index()
    {
        return View();
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
