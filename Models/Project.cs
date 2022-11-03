namespace TCSA.Models;

public class Project: Article
{
    public string Introduction { get; set; }
    public List<string> Requirements { get; set; }
    public List<string> Tips { get; set; }
    public string Resources { get; set; }
}

