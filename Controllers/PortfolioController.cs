using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;

namespace MVC_Project.Controllers;
public class PortfolioController : Controller
{
    public IActionResult PortfolioView()
    {
        PortfolioModel myPortfolio = new PortfolioModel();
        myPortfolio.Name = "John Mark Yumena";
        myPortfolio.socialsList = [];
        myPortfolio.projectLinks = [];


        myPortfolio.projectLinks.Add("https://github.com/NovaPrime0/Automated-Matrix-Diagonalizer.git");
        myPortfolio.projectLinks.Add("https://github.com/NovaPrime0/ReStok.git");


        List<(string title, string thumbnail, string text)> projectInfo = [
            ("Automated Matrix Diagonalizer", "Matrix.png", "A web application that diagonalizes a matrix using eigenvalues obtained through the QR Decomposition algorithm"),
            ("ReStok", "Restok.png", "An offline flutter-based application that suggests restock list based on ROI")
        ];

        ViewData["projectDesc"] = projectInfo;

        myPortfolio.socialsList.Add(new Socials
        (){
            Platform = "Facebook",
            Link = "https://www.facebook.com/johnmark.yumena.9/"
        });
        myPortfolio.socialsList.Add(new Socials
        (){
            Platform = "Gmail",
            Link = "yumenajohnmark@gmail.com"
        });
        myPortfolio.socialsList.Add(new Socials
        (){
            Platform = "Github",
            Link = "https://github.com/NovaPrime0"
        });
        return View(myPortfolio);
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}