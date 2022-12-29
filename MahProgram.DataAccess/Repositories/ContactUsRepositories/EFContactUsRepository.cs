using MahProgram.DataAccess.Context;
using MahProgram.DataAccess.Models.ContactUsModel;
using MahProgram.Utilities.Logging;
using Microsoft.EntityFrameworkCore;

namespace MahProgram.DataAccess.Repositories.ContactUsRepositories;

public sealed class EFContactUsRepository : IContactUsRepository
{
    private MahProgramDBContext _context;
    public EFContactUsRepository(MahProgramDBContext context)
    {
        _context = context;
    }

    public async Task<bool> AddAsync(ContactUs obj)
    {
        try
        {
            await _context.AddAsync(obj);
            await SaveChangeAsync();
            return true;
        }
        catch (Exception ex) 
        {
            await ExceptionLogger.LogAsync(ex);
            return false;
        }
    }

    public async ValueTask DisposeAsync()
    {
        await _context.DisposeAsync();
    }

    public async Task<ContactUs> FindAsync(int key) => await _context.ContactUs?
        .Include(cu => cu.ContactUsAnswere)?
        .FirstOrDefaultAsync(cu => cu.ContactUsId.Equals(key)!) ?? null!;

    public IQueryable<ContactUs> GetAll()
    {
        return _context.ContactUs.Where(cu => !cu.IsDeleted);
    }

    public async Task<bool> RemoveAsync(ContactUs obj)
    {
        try
        {
            obj.IsDeleted = true;
            await UpdateAsync(obj);
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


    public async Task<bool> UpdateAsync(ContactUs obj)
    {
        try
        {
            _context.ContactUs.Update(obj);
            await SaveChangeAsync();
            return true;
        }
        catch (Exception ex)
        {
            await ExceptionLogger.LogAsync(ex);
            return false;
        }
    }
}
