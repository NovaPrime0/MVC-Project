namespace DirectoryPortfolio.Models
{
    public class DirectoryViewModel
    {
        public string Subject { get; set; } = "Application Development and Emerging Technologies";
        public string Professor { get; set; } = "Yuhenyo Andres Bato";
        public string Section { get; set; } = "BSCS 3-5";
        
        public List<StudentProfile> Profiles { get; set; } = new();
    }

    public class StudentProfile
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string ProfileUrl { get; set; } = string.Empty;
        public string PhotoUrl { get; set; } = string.Empty;
    }
}
