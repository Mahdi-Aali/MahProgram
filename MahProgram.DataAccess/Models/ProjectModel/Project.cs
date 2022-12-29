using System.ComponentModel.DataAnnotations;

namespace MahProgram.DataAccess.Models.ProjectModel;

public partial class Project
{
    [Key]
    public int ProjectId { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [MaxLength(800)]
    [MinLength(50)]
    public string Description { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string Icon { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string MockUpImageOne { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string MockUpImageTwo { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string MockUpImageThree { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string MockUpImageFour { get; set; } = string.Empty;

    [Required]
    public bool IsDeleted { get; set; } = false;

    [Required]
    public DateTime CreateDate { get; set; }
}
