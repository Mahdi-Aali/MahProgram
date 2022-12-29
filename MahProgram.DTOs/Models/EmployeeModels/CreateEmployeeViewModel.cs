using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace MahProgram.DTOs.Models.EmployeeModels;

public record CreateEmployeeViewModel
{
    [Required(ErrorMessage = "نام کامل نمیتواند خالی باشد")]
    [MaxLength(50, ErrorMessage = "نام کامل نمیتواند بیشتر از 50 حرف باشد")]
    [MinLength(5, ErrorMessage = "نام کامل نمیتواند کمتر از 5 حرف باشد")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "مهارت نمیتواند خالی باشد")]
    [MaxLength(50, ErrorMessage = "مهارت نمیتواند بیشتر از 50 حرف باشد")]
    [MinLength(3, ErrorMessage = "مهارت نمیتواند کمتر از 3 حرف باشد")]
    public string Skill { get; set; } = string.Empty;

    [Required(ErrorMessage = "بیو نمیتواند خالی باشد")]
    [MaxLength(80, ErrorMessage = "بیو نمیتواند بیشتر از 80 حرف باشد")]
    [MinLength(50, ErrorMessage = "بیو نمیتواند کمتر از 50 حرف باشد")]
    public string Bio { get; set; } = string.Empty;

    [Required(ErrorMessage = "تصویر نمیتواند خالی باشد")]
    public IBrowserFile Image { get; set; } = null!;


    [MaxLength(150, ErrorMessage = "لینک گیت هاب نمیتواند بیشتر از 150 حرف باشد")]
    [DataType(DataType.Url, ErrorMessage = "لطفا لینک معتبری را وارد کنید")]
    [Url(ErrorMessage = "لطفا لینک معتبری را وارد کنید")]
    public string? GitHubLink { get; set; }

    [MaxLength(150, ErrorMessage = "لینک لینکدین نمیتواند بیشتر از 150 حرف باشد")]
    [DataType(DataType.Url, ErrorMessage = "لطفا لینک معتبری را وارد کنید")]
    [Url(ErrorMessage = "لطفا لینک معتبری را وارد کنید")]
    public string? LinkedinLink { get; set; }

    [MaxLength(150, ErrorMessage = "لینک توییتر نمیتواند بیشتر از 150 حرف باشد")]
    [DataType(DataType.Url, ErrorMessage = "لطفا لینک معتبری را وارد کنید")]
    [Url(ErrorMessage = "لطفا لینک معتبری را وارد کنید")]
    public string? TwitterLink { get; set; }

    [MaxLength(150, ErrorMessage = "لینک اینستاگرام نمیتواند بیشتر از 150 حرف باشد")]
    [DataType(DataType.Url, ErrorMessage = "لطفا لینک معتبری را وارد کنید")]
    [Url(ErrorMessage = "لطفا لینک معتبری را وارد کنید")]
    public string? InstagramLink { get; set; }

    [MaxLength(150, ErrorMessage = "لینک تلگرام نمیتواند بیشتر از 150 حرف باشد")]
    [DataType(DataType.Url, ErrorMessage = "لطفا لینک معتبری را وارد کنید")]
    [Url(ErrorMessage = "لطفا لینک معتبری را وارد کنید")]
    public string? TelegramLink { get; set; }
}
