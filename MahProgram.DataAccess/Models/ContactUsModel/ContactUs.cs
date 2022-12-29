using System.ComponentModel.DataAnnotations;

namespace MahProgram.DataAccess.Models.ContactUsModel;

public partial class ContactUs
{
    [Key]
    public int ContactUsId { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    [Required]
    [MaxLength(80)]
    public string Email { get; set; } = string.Empty;
    [Required]
    [MaxLength(800)]
    public string Text { get; set; } = string.Empty;

    [Required]
    public DateTime CreateDate { get; set; }

    [Required]
    public bool IsDeleted { get; set; } = false;

    [Required]
    public bool HasAnswere { get; set; } = false;


    public ContactUsAnswere? ContactUsAnswere { get; set; }
}
