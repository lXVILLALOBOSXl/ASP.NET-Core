using Portafolio.Models;

namespace Portafolio.Services
{

    public interface IProjectsRepository
    {
        List<Project> GetProjects();
    }

    public class ProjectsRepository : IProjectsRepository
    {
        public List<Project> GetProjects()
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

    }
}