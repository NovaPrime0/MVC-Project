namespace MyMVCPortfolio.Models
{
    public class PortfolioViewModel
    {
        public string Name { get; set; } = string.Empty;
        public string Tagline { get; set; } = string.Empty;
        public string IntroText { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Focus { get; set; } = string.Empty;
        public string CurrentStatus { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string GithubUrl { get; set; } = string.Empty;
        public string LinkedInUrl { get; set; } = string.Empty;
        public string ResumeUrl { get; set; } = string.Empty;
        public AboutSection About { get; set; } = new();
        public SkillsSection Skills { get; set; } = new();
        public ProjectsSection Projects { get; set; } = new();
        public EducationSection Education { get; set; } = new();
    }

    public class AboutSection
    {
        public string Description { get; set; } = string.Empty;
        public string OutsideOfWork { get; set; } = string.Empty;
    }

    public class SkillsSection
    {
        public List<string> Languages { get; set; } = new();
        public List<string> Frameworks { get; set; } = new();
        public List<string> Tools { get; set; } = new();
    }

    public class ProjectsSection
    {
        public string Title { get; set; } = "Projects where I've contributed";
        public List<ProjectItem> Items { get; set; } = new();
    }

    public class ProjectItem
    {
        public string Title { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string SecondDescription { get; set; } = string.Empty;
        public List<string> Bullets { get; set; } = new();
    }

    public class EducationSection
    {
        public string Degree { get; set; } = string.Empty;
        public string Institution { get; set; } = string.Empty;
        public string Years { get; set; } = string.Empty;
    }
}
