using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Portafolio.Models;
using Portafolio.Services;

namespace Portafolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IPersonRepository _personRepository;
    private readonly IProjectsRepository _ProjectsRepository;

    private readonly IConfiguration _configuration;

    public HomeController(ILogger<HomeController> logger, IPersonRepository personRepository, IProjectsRepository ProjectsRepository, IConfiguration configuration)
    {
        _logger = logger;
        _personRepository = personRepository;
        _ProjectsRepository = ProjectsRepository;
        _configuration = configuration;
    }

    public IActionResult Index()
    {
        // ViewBag.Name = "Luis Villalobos";
        // return View();
        // return View("Index", "Luis Villalobos");
        // _logger.LogTrace("This is a trace log");
        // _logger.LogDebug("This is a debug log");
        // _logger.LogInformation("This is an information log");
        // _logger.LogWarning("This is a warning log");
        // _logger.LogError("This is an error log");
        // _logger.LogCritical("This is a critical log");
        // _logger.LogInformation("Index action method called at {Time}", DateTime.Now);
        // var lastName = _configuration.GetValue<string>("LastName");
        // _logger.LogInformation("LastName from configuration: {LastName}", lastName);
        var person = _personRepository.GetPerson();
        var projects = _ProjectsRepository.GetProjects().Take(3).ToList();
        var model = new HomeIndexViewModel
        {
            Projects = projects,
            Person = person
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
