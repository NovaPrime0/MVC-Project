using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DirectoryPortfolio.Models;

namespace DirectoryPortfolio.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var model = new DirectoryViewModel
        {
            Subject = "Application Development and Emerging Technologies",
            Professor = "Yuhenyo Andres Bato",
            Section = "BSCS 3-5",
            Profiles = new List<StudentProfile>
            {
                new StudentProfile { Id = "01", Name = "Veevhoi Poblete", ProfileUrl = "https://github.com/NovaPrime0/MVC-Project/tree/Portfolio-Veevhoi-Poblete", PhotoUrl = "/images/poblete_pic.jpg" },
                new StudentProfile { Id = "02", Name = "Jhaymar Gaviola", ProfileUrl = "https://github.com/NovaPrime0/MVC-Project/tree/portfolio_jamal" },
                new StudentProfile { Id = "03", Name = "John Mark Yumena", ProfileUrl = "#" }
            }
        };

        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
