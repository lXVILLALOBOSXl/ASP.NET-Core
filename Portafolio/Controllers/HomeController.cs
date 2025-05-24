using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Portafolio.Models;

namespace Portafolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // ViewBag.Name = "Luis Villalobos";
        // return View();
        // return View("Index", "Luis Villalobos");
        var person = new Person()
        {
            Name = "Luis Villalobos",
            Occupation = "Student in Computer Science Engineering",
            AboutMe = "Engineering student with solid hands-on experience in software development. Intermediate proficiency in Python, C#, Angular and Java, with active participation in bootcamps, specialized courses, and complete projects. Passionate about building intelligent solutions, with knowledge in web and mobile development, data structures, algorithms, and fundamentals of artificial intelligence. Ready to contribute effectively to development teams as a junior or intern developer. Eager to learn and grow in the field of technology.",
            Skills = new Dictionary<string, List<string>>
            {

                { "Soft", new List<string> { "Focus", "Communication", "Teamwork", "Time Management", "Responsibility", "Problem Solving" } },
                { "Languages", new List<string> { "Python (intermediate)", "C# (intermediate)", "Java (intermediate)", "C++", "JavaScript", "SQl" } },
                { "Frameworks and Technologies", new List<string> { 
                    "Python: Flask, Tkinter, SQLAlchemy, Selenium, BeautifulSoup, NumPy, Pandas, Matplotlib, Seaborn, TensorFlow",
                    "C#: ASP.NET Core",
                    "Java: Swing, JavaFX, JDBC, Spring",
                    "Web & Mobile: Angular, Node.js, Ionic, Bootstrap",
                    "Others: ASP.NET, LINQ, Git, GitHub, RESTful APIs, Unix CLI, Bison, Yacc"
                } },
                { "Computer Science", new List<string> { "Data Structures", "Algorithms", "Formal Languages and Automata (Bison/Yacc)", "Basic Machine Learning (Classification, Regression, Clustering)" } },
                { "Databases", new List<string> { "MySQL", "SQLite", "SQL Server" } }
            }
        };
        var projects = GetProjects().Take(3).ToList();
        var model = new HomeIndexViewModel
        {
            Projects = projects,
            Person = person
        };
        return View(model);
    }

    private List<Project> GetProjects()
    {
        return new List<Project>
        {
            new Project
            {
                Name = "Fundación San Elías",
                Description = "CRM/PWA application for pharmacy and medical care using Angular, Node.js, and Ionic.",
                ImageUrls = new List<string>
                {
                    "~/img/Portfolio/San Elias/1.png",
                    "~/img/Portfolio/San Elias/2.png",
                },
                Url = "fundacionsaneliasac.com"
            },
            new Project
            {
                Name = "Tesla Cientifica",
                Description = "E-commerce application for selling scientific equipment using Flask, SQLAlchemy, and Bootstrap.",
                ImageUrls = new List<string>
                {
                    "~/img/Portfolio/Tesla Cientifica/1.png",
                    "~/img/Portfolio/Tesla Cientifica/2.png",
                    "~/img/Portfolio/Tesla Cientifica/3.png",
                    "~/img/Portfolio/Tesla Cientifica/4.png",
                    "~/img/Portfolio/Tesla Cientifica/5.png",
                    "~/img/Portfolio/Tesla Cientifica/6.png",
                },
                Url = ""
            },
            new Project
            {
                Name = "Daltys Food",
                Description = "CRM for the management of a restaurant using Java, JavaFX, React native, PHP, JS, WordPress, html5",
                ImageUrls = new List<string>
                {
                    "~/img/Portfolio/Daltys/1.png",
                    "~/img/Portfolio/Daltys/2.png",
                    "~/img/Portfolio/Daltys/3.png",
                    "~/img/Portfolio/Daltys/4.png",
                    "~/img/Portfolio/Daltys/5.png",
                    "~/img/Portfolio/Daltys/6.png",
                    "~/img/Portfolio/Daltys/7.png",
                    "~/img/Portfolio/Daltys/8.png",
                    "~/img/Portfolio/Daltys/9.png",
                },
                Url = ""
            }
        };
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
