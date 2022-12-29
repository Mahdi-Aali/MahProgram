using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace MahProgram.DTOs.Models.ServiceModels;

public record EditServiceViewModel
{
    public int ServiceId { get; set; }
    [Required(ErrorMessage = "عنوان سرویس نمیتواند خالی باشد")]
    [MinLength(2, ErrorMessage = "عنوان سرویس نمیتواند کمتر از 2 حرف باشد")]
    [MaxLength(150, ErrorMessage = "عنوان سرویس نمیتواند بیشتر از 150 حرف باشد")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "توضیحات سرویس نمیتواند خالی باشد")]
    [MinLength(50, ErrorMessage = "توضیحات سرویس نمیتواند کمتر از 50 حرف باشد")]
    public string Description { get; set; } = string.Empty;

    public IBrowserFile ImagePath { get; set; } = null!;

    [Required(ErrorMessage = "آیکن سرویس نمیتواند خالی باشد")]
    [MaxLength(25, ErrorMessage = "آیکون سرویس نمیتواند بیشتر از 25 حرف باشد")]
    [MinLength(2, ErrorMessage = "آیکن سرویس نمیتواند کمتر از 2 حرف باشد")]
    public string Icon { get; set; } = string.Empty;

    public DateTime CreateDate { get; set; }

    public bool IsDeleted { get; set; } = false;
}
