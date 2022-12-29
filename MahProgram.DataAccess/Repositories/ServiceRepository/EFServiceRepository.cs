using MahProgram.DataAccess.Context;
using MahProgram.DataAccess.Models.ServiceModel;
using MahProgram.Utilities.Logging;

namespace MahProgram.DataAccess.Repositories.ServiceRepository;

public class EFServiceRepository : IServiceRepository
{
    private MahProgramDBContext _context;

    public EFServiceRepository(MahProgramDBContext context)
    {
        _context = context;
    }

    public IQueryable<Service> GetAll() => _context.Services.Where(s => !s.IsDeleted);

    public async Task<Service> FindAsync(int key) => await _context.Services.FindAsync(key)!;

    public async Task<bool> AddAsync(Service obj)
    {
        try
        {
            await _context.Services.AddAsync(obj);
            await SaveChangeAsync();
            return true;
        }
        catch (Exception ex)
        {
            await ExceptionLogger.LogAsync(ex);
            return false;
        }
    }

    public async Task<bool> UpdateAsync(Service obj)
    {
        try
        {
            _context.Services.Update(obj);
            await SaveChangeAsync();
            return true;
        }
        catch (Exception ex)
        {
            await ExceptionLogger.LogAsync(ex);
            return false;
        }
    }


    public async Task<bool> RemoveAsync(Service obj)
    {
        obj.IsDeleted = true;
        return await UpdateAsync(obj);
    }

    public async Task SaveChangeAsync()
    {
        await _context.SaveChangesAsync();
    }

    public async ValueTask DisposeAsync()
    {
        await _context.DisposeAsync();
    }

}
