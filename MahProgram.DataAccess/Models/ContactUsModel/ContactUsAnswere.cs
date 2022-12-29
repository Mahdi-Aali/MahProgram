using System.ComponentModel.DataAnnotations;

namespace MahProgram.DataAccess.Models.ContactUsModel;

public partial class ContactUsAnswere
{
    [Key]
    public int ContactUsAnswereId { get; set; }

    [Required]
    public int ContactUsId { get; set; }
    public ContactUs? ContactUs { get; set; }

    [Required]
    public string ResponseMessage { get; set; } = string.Empty;

    [Required]
    public bool IsDeleted { get; set; } = false;

    [Required]
    public DateTime CreateDate { get; set; }
}
