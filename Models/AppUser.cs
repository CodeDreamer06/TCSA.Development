using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TCSA.Models;

public class AppUser: IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<DashboardProject> DashboardProjects { get; set; }
    public int CurrentProject { get; set; }
}

