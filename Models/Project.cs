namespace TCSA.Models;

public class Project: Article
{
    public List<Paragraph> Introduction { get; set; }
    public List<string> Requirements { get; set; }
    public List<string> Resources { get; set; }
    public List<string> Tips { get; set; }
    public List<string> Challenges { get; set; }
}

