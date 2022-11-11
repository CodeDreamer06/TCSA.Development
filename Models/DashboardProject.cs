using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TCSA.Models;

public class DashboardProject
{
    public int Id { get; set; }

    [Required]
    public string GithubUrl { get; set; }

    public string AppUserId { get; set; }
    public int ProjectId { get; set; }

    [JsonIgnore]
    public AppUser? AppUser { get; set; }
}

public class DashboardProjectCard : DashboardProject
{
    public string IconUrl { get; set; }

    public string Title { get; set; }
}
