using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace MahProgram.DTOs.Models.ProjectModel;

public record CreateProjectViewModel
{
    [Required(ErrorMessage = "نام پروژه نمیتواند خالی باشد")]
    [MaxLength(50, ErrorMessage = "نام پروژه نمیتواند بیشتر از 50 حرف باشد")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "توضیحات پروژه پروژه نمیتواند خالی باشد")]
    [MaxLength(800, ErrorMessage = "توضیحات پروژه نمیتواند بیشتر از 50 حرف باشد")]
    [MinLength(50, ErrorMessage = "توضیحات پروژه نمیتواند بیشتر از 50 حرف باشد")]
    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage = "آیکن پروژه نمیتواند خالی باشد")]
    public IBrowserFile Icon { get; set; } = null!;

    [Required(ErrorMessage = "تصویر اول پروژه نمیتواند خالی باشد")]
    public IBrowserFile MockUpImageOne { get; set; } = null!;

    [Required(ErrorMessage = "تصویر دوم پروژه نمیتواند خالی باشد")]
    public IBrowserFile MockUpImageTwo { get; set; } = null!;

    [Required(ErrorMessage = "تصویر سوم پروژه نمیتواند خالی باشد")]
    public IBrowserFile MockUpImageThree { get; set; } = null!;

    [Required(ErrorMessage = "تصویر چهارم پروژه نمیتواند خالی باشد")]
    public IBrowserFile MockUpImageFour { get; set; } = null!;

}
