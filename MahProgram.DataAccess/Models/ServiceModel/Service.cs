using System.ComponentModel.DataAnnotations;

namespace MahProgram.DataAccess.Models.ServiceModel;

public partial class Service
{
    [Key]
    public int ServiceId { get; set; }
    [Required]
    [MaxLength(150)]
    public string Name { get; set; } = string.Empty;

    [Required]
    public string Description { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string ImagePath { get; set; } = string.Empty;

    [Required]
    [MaxLength(25)]
    public string Icon { get; set; } = string.Empty;

    [Required]
    public DateTime CreateDate { get; set; }

    [Required]
    public bool IsDeleted { get; set; } = false;
}
