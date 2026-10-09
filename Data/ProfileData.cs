using MyPortfolio.Models;

namespace MyPortfolio.Data;

public static class ProfileData
{
    public static Profile Me = new()
    {
        Name = "Jhaymar N. Gaviola",
        Headline = "Computer Science student and aspiring web developer",
        Bio = "I love learning how to code and building things. I am a passionate software developer with a strong interest in web development and software engineering. I am always looking for new challenges and opportunities to grow my skills and knowledge.",
        Location = "Pandi, Bulacan",
        Email = "jhaymargaviola19@gmail.com",
        GithubUrl = "https://github.com/waksun",

        Skills = new()
        {
            new SkillGroup { Category = "Languages", Items = new() { "C#", "Java", "JavaScript", "Dart", "HTML", "CSS" } },
            new SkillGroup { Category = "Frameworks & Libraries", Items = new() { "Vue 3", "React", "Flutter", "Node.js"} },
            new SkillGroup { Category = "Databases", Items = new() { "MongoDB", "SQLite" } },
            new SkillGroup { Category = "Tools", Items = new() { "Git", "GitHub", "VS Code", "Vite", "npm" } }
        },

        Education = new()
        {
            new EducationEntry
            {
                Degree = "Bachelor of Science in Computer Science",
                School = "Polytechnic University of the Philippines - Sta. Mesa",
                Years = "2024 - 2028"
            }
        },

        Experience = new()
        {
            new ExperienceEntry
            {
                Role = "Junior Developer",
                Place = "Freelance Team",
                Years = "2025",
                Details = "Worked with a freelance team to build a web application for a research group."
            }
        },

        Projects = new()
        {
            new Project
            {
                Title = "ReStok",
                Summary = "Restock optimizer for sari-sari stores. Recommends what to buy within a budget using a fractional knapsack algorithm, with an offline local database.",
                Status = "Completed",
                RepoUrl = "https://github.com/NovaPrime0/ReStok",
                TechUsed = new() { "Flutter", "Dart", "Drift", "SQLite" }
            },
            new Project
            {
                Title = "Automated Matrix Diagonalizer",
                Summary = "Calculator that finds the determinant, eigenvalues, eigenvectors, and diagonal form of a matrix up to 5x5.",
                Status = "Completed",
                RepoUrl = "https://github.com/NovaPrime0/Automated-Matrix-Diagonalizer",
                TechUsed = new() { "React", "Vite", "JavaScript", "math.js" }
            }
        }
    };
}