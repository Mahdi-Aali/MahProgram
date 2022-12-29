using System.ComponentModel.DataAnnotations;

namespace MahProgram.DataAccess.Models.EmployeeModel;

public partial class Employee
{
    [Key]
    public int EmployeeId { get; set; }

    [Required]
    [MaxLength(50)]
    [MinLength(5)]
    public string FullName { get; set; } = string.Empty;
    [Required]
    [MaxLength(50)]
    [MinLength(3)]
    public string Skill { get; set; } = string.Empty;

    [Required]
    [MaxLength(80)]
    [MinLength(50)]
    public string Bio { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string ImagePath { get; set; } = string.Empty;

    [MaxLength(150)]
    [DataType(DataType.Url)]
    [Url]
    public string? GitHubLink { get; set; }

    [MaxLength(150)]
    [DataType(DataType.Url)]
    [Url]
    public string? LinkedinLink { get; set; }

    [MaxLength(150)]
    [DataType(DataType.Url)]
    [Url]
    public string? TwitterLink { get; set; }

    [MaxLength(150)]
    [DataType(DataType.Url)]
    [Url]
    public string? InstagramLink { get; set; }

    [MaxLength(150)]
    [DataType(DataType.Url)]
    [Url]
    public string? TelegramLink { get; set; }

    [Required]
    public bool IsDeleted { get; set; } = false;

    [Required]
    public DateTime CreateDate { get; set; }
}
