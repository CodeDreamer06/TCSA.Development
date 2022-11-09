namespace TCSA.Models;

public class Project: Article
{
    public List<Paragraph> Introduction { get; set; }
    public List<string> Requirements { get; set; }
    public string RequirementsIntro { get; set; }
    public string RequirementsConclusion { get; set; }
    public List<string>? Resources { get; set; }
    public string ResourcesIntro { get; set; }
    public string ResourcesConclusion { get; set; }
    public List<string> Tips { get; set; }
    public List<string> Challenges { get; set; }
    public string LearningIntro { get; set; }
    public List<string> LearningItems { get; set; }
    public List<string> Screenshots { get; set; }
}

