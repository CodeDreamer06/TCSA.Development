using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TCSA.Models;

public class AppUser: IdentityUser
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string CompletedProjects { get; set; }
}

