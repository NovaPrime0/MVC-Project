namespace MVC_Project.Models;

public class Socials
{
    public string Platform{set; get;}
    public string Link{set; get;}
}
public class PortfolioModel
{
    public string Name{set; get;}
    public List<string> projectLinks{set; get;} 
    public List<Socials> socialsList {set; get;}
}
