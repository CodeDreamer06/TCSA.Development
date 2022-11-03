namespace TCSA.Models;

public class Article
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string IconUrl { get; set; }
    public Area Area { get; set; }
}

public enum Area
{
    HowItWorks,
    StartHere,
    Console,
    StartApplying,
    MVC,
    Angular,
    React,
    Blazor,
    MAUI,
    Azure
}

