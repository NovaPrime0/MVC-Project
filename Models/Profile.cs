namespace MyPortfolio.Models;

public class Profile
{
    public string Name { get; set; } = "";
    public string Headline { get; set; } = "";
    public string Bio { get; set; } = "";
    public string Location { get; set; } = "";
    public string Email { get; set; } = "";
    public string GithubUrl { get; set; } = "";

    public List<SkillGroup> Skills { get; set; } = new();
    public List<EducationEntry> Education { get; set; } = new();
    public List<ExperienceEntry> Experience { get; set; } = new();
    public List<Project> Projects { get; set; } = new();
}

public class SkillGroup
{
    public string Category { get; set; } = "";
    public List<string> Items { get; set; } = new();
}

public class EducationEntry
{
    public string Degree { get; set; } = "";
    public string School { get; set; } = "";
    public string Years { get; set; } = "";
}

public class ExperienceEntry
{
    public string Role { get; set; } = "";
    public string Place { get; set; } = "";
    public string Years { get; set; } = "";
    public string Details { get; set; } = "";
}

public class Project
{
    public string Title { get; set; } = "";
    public string Summary { get; set; } = "";
    public string Status { get; set; } = "";
    public string RepoUrl { get; set; } = "";
    public List<string> TechUsed { get; set; } = new();
}