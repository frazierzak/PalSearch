using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PalSearch.Models;
using Newtonsoft.Json;

namespace PalSearch.Controllers;
public class HomeController : Controller {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger) {
        _logger = logger;
    }

    public IActionResult Index()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", "pals_all_data.json");
            var jsonData = System.IO.File.ReadAllText(filePath);
            var pals = JsonConvert.DeserializeObject<List<Pal>>(jsonData);

            return View(pals);
        }

    public IActionResult Privacy() {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
