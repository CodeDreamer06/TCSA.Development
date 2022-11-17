using Microsoft.AspNetCore.Identity;

namespace TCSA.Models;

public class AppUser: IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<DashboardProject> DashboardProjects { get; set; }
    public int CurrentProject { get; set; }
    public string FrontEndFrameworks { get; set; }
}

public enum FrontEndFramework
{
    Blazor,
    MVC,
    MAUI,
    React,
    Angular
}

