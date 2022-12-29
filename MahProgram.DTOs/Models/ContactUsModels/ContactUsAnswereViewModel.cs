using System.ComponentModel.DataAnnotations;

namespace MahProgram.DTOs.Models.ContactUsModels;

public record ContactUsAnswereViewModel
{
    public ContactUsAnswereViewModel()
    {

    }

    public ContactUsAnswereViewModel(string responseMessage, int contactUsId)
    {
        ResponseMessage = responseMessage;
        ContactUsId = contactUsId;
    }

    [Required(ErrorMessage = "پاسخ شما نمیتواند خالی باشد")]
    [MinLength(10, ErrorMessage = "پاسخ شما نمیتواند کمتر از 100 حرف باشد")]
    public string ResponseMessage { get; set; } = string.Empty;

    [Required]
    public int ContactUsId { get; set; }
}