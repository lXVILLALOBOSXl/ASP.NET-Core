using Portafolio.Models;

namespace Portafolio.Services
{
    public interface IPersonRepository
    {
        Person GetPerson();
    }

    public class PersonRepository : IPersonRepository
    {
        public Person GetPerson()
        {
            return new Person()
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
        }
    }
}