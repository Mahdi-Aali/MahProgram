using System.ComponentModel.DataAnnotations;

namespace MahProgram.DTOs.Models.ContactUsModels;

public record ContactUsViewModel
{
    public ContactUsViewModel(string name, string email, string text)
    {
        Name = name;
        Email = email;
        Text = text;
    }

    public ContactUsViewModel()
    {

    }

    [Required(ErrorMessage = "نام نمیتواند خالی باشد")]
    [MaxLength(50, ErrorMessage = "نام نمیتواند بیشتر از 50 حرف باشد")]
    [MinLength(3, ErrorMessage = "نام نمیتواند کمتر از 3 حرف باشد")]
    public string Name { get; init; } = string.Empty;

    [Required(ErrorMessage = "نام نمیتواند خالی باشد")]
    [MaxLength(80, ErrorMessage = "نام نمیتواند بیشتر از 50 حرف باشد")]
    [MinLength(10, ErrorMessage = "نام نمیتواند کمتر از 3 حرف باشد")]
    [EmailAddress(ErrorMessage = "آدرس ایمیل معتبر نمیباشد")]
    [DataType(DataType.EmailAddress, ErrorMessage = "آدرس ایمیل معتبر نمیباشد")]
    public string Email { get; init; } = string.Empty;

    [Required(ErrorMessage = "متن تماس نمیتواند خالب باشد")]
    [MaxLength(800, ErrorMessage = "متن تماس نمیتواند بیشتر از 800 حرف باشد")]
    [MinLength(10, ErrorMessage = "متن تماس نمیتواند کمتر از 10 حرف باشد")]
    public string Text { get; init; } = string.Empty;
}
