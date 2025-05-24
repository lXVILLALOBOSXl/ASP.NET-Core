namespace Portafolio.Models
{

    public class Project
    {
        public string Name { get; set; }
        public string Description { get; set; }
        // Array of strings for images
        public List<string> ImageUrls { get; set; }
        public string? Url { get; set; }


    }
}