using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TCSA.Models;

public class Roadmap
{
    public int Id { get; set; }

    public string AppUserId { get; set; }

    [Required]
    [DefaultValue(false)]
    public bool IsCompleted { get; set; }

    [Required]
    public RoadmapLevel RoadmapLevel { get; set; }
}

public enum RoadmapLevel
{
    White,
    Yellow,
    Orange,
    Green,
    Blue,
    Purple,
    Brown,
    Red,
    Black
}

