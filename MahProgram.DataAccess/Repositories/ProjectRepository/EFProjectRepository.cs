using MahProgram.DataAccess.Context;
using MahProgram.DataAccess.Models.ProjectModel;
using MahProgram.Utilities.Logging;

namespace MahProgram.DataAccess.Repositories.ProjectRepository;

public class EFProjectRepository : IProjectRepository
{
    private MahProgramDBContext _context;
    public EFProjectRepository(MahProgramDBContext context)
    {
        _context = context;
    }

    public IQueryable<Project> GetAll()
    {
        return _context.Projects.Where(p => !p.IsDeleted);
    }


    public async Task<Project> FindAsync(int key)
    {
        return await _context.Projects.FindAsync(key);
    }

    public async Task<bool> AddAsync(Project obj)
    {
        try
        {
            await _context.Projects.AddAsync(obj);
            await SaveChangeAsync();
            return true;
        }
        catch (Exception ex)
        {
            await ExceptionLogger.LogAsync(ex);
            return false;
        }
    }

    public async Task<bool> UpdateAsync(Project obj)
    {
        try
        {
            _context.Projects.Update(obj);
            await SaveChangeAsync();
            return true;
        }
        catch (Exception ex)
        {
            await ExceptionLogger.LogAsync(ex);
            return false;
        }
    }

    public async Task<bool> RemoveAsync(Project obj)
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
