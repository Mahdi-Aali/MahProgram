using MahProgram.Utilities.Logging;
using Microsoft.AspNetCore.Components.Forms;

namespace MahProgram.Utilities.FileManagment;

public static class FileSaver
{
    public static async Task SaveFileAsync(IBrowserFile file, string imagePath)
    {
        try
        {
            ArgumentNullException.ThrowIfNull(file);
            using (FileStream fileStream = new FileStream(imagePath, FileMode.Create))
            {
                await file.OpenReadStream().CopyToAsync(fileStream);
            }
        }
        catch (Exception ex)
        {
            await ExceptionLogger.LogAsync(ex);
        }
    }
}
