using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SayHelloApp.Models;

namespace SayHelloApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(new InputName { Name = TempData["Name"] as string});
    }

    [HttpPost]
    public IActionResult NewName(InputName inputName) 
    {
        TempData["Name"] = inputName.Name;
        return RedirectToAction(nameof(Index));
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
