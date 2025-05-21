namespace Portafolio.Models;

public class Person
{
    public string Name { get; set; }
    public string Occupation { get; set; }

    public string AboutMe { get; set; }

    // Create a double array for skills, for example, soft skills: Focus. Frameworks and Technologies: Python, C#, Java,.

    public Dictionary<string, List<string>> Skills { get; set; } 

}
