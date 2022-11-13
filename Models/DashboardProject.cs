using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TCSA.Models;

public class DashboardProject
{
    public int Id { get; set; }

    [Required]
    public string GithubUrl { get; set; }

    [DefaultValue("Placeholder")]
    public string AppUserId { get; set; }

    [Required]
    [DefaultValue(false)]
    public bool IsCompleted { get; set; }

    [Required]
    public int ProjectId { get; set; }

    [JsonIgnore]
    public AppUser? AppUser { get; set; }
}

public class DashboardProjectCard : DashboardProject
{
    public string IconUrl { get; set; }

    public string Title { get; set; }
}

public class DashboardArticleCard : DashboardProject
{
    public string IconUrl { get; set; }

    public string Title { get; set; }
}
