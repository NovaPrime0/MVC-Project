using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMVCPortfolio.Models;

namespace MyMVCPortfolio.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        // my personal details
        var model = new PortfolioViewModel
        {
            Name = "Veevhoi Poblete",
            Tagline = "Student. Builder.",
            IntroText = "I'm a CS student at PUP who builds practical software. I work on database design, algorithms, and apps that solve real local problems. I want to make useful, community-focused tools backed by clean data design.",
            Location = "Marikina, Metro Manila, NCR",
            Focus = "Building more skills, and creating money",
            CurrentStatus = "Studying at Polytechnic University of the Philippines",
            Email = "veevoipobz19@gmail.com",
            GithubUrl = "#",
            LinkedInUrl = "#",
            ResumeUrl = "#",
            About = new AboutSection
            {
                Description = "I'm a CS student at PUP who loves turning everyday problems into working software. I got into tech through games and stayed for the problem-solving.",
                OutsideOfWork = "I like playing online games and going out with my motorcycle."
            },
            // education
            Education = new EducationSection
            {
                Degree = "Computer Science",
                Institution = "Polytechnic University of the Philippines - Sta. Mesa, Manila",
                Years = "2024 - 2028"
            }
        };

        return View(model);
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

