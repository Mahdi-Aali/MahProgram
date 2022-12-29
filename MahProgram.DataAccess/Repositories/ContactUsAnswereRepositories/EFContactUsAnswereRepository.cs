using MahProgram.DataAccess.Context;
using MahProgram.DataAccess.Models.ContactUsModel;
using MahProgram.Utilities.Email;
using MahProgram.Utilities.Logging;

namespace MahProgram.DataAccess.Repositories.ContactUsAnswereRepositories;

public sealed class EFContactUsAnswereRepository : IContactUsAnswereRepository
{
    private MahProgramDBContext _context;

    public EFContactUsAnswereRepository(MahProgramDBContext context)
    {
        _context = context;
    }


    public async Task<bool> AddAsync(ContactUsAnswere obj)
    {
        try
        {
            await _context.ContactUsAnsweres.AddAsync(obj);
            await SaveChangeAsync();
            return true;
        }
        catch (Exception ex)
        {
            await ExceptionLogger.LogAsync(ex);
            return false;
        }
    }

    public async Task<bool> SendAnswereAsync(ContactUsAnswere contactUsAnswere, string to)
    {
        try
        {
            await AddAsync(contactUsAnswere);
            await EmailSender.SendAsync(to, "پاسخ به تماس شما در ماه پروگرام", contactUsAnswere.ResponseMessage);
            return true;
        }
        catch (Exception ex)
        {
            await ExceptionLogger.LogAsync(ex);
            return false;
        }
    }

    public async Task SaveChangeAsync()
    {
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            await ExceptionLogger.LogAsync(ex);
        }
    }

    public async ValueTask DisposeAsync()
    {
        await _context.DisposeAsync();
    }


}
