using MahProgram.DataAccess.Context;
using MahProgram.DataAccess.Models.EmployeeModel;
using MahProgram.Utilities.Logging;

namespace MahProgram.DataAccess.Repositories.EmployeeRepository;

public class EFEmployeeRepository : IEmployeeRepository
{
    private MahProgramDBContext _context;

    public EFEmployeeRepository(MahProgramDBContext context)
    {
        _context = context;
    }

    public IQueryable<Employee> GetAll() => _context.Employees.Where(e => !e.IsDeleted);

    public async Task<Employee> FindAsync(int key)
    {
        return await _context.Employees.FindAsync(key)!;
    }

    public async Task<bool> AddAsync(Employee obj)
    {
        try
        {
            await _context.Employees.AddAsync(obj);
            await SaveChangeAsync();
            return true;
        }
        catch (Exception ex)
        {
            await ExceptionLogger.LogAsync(ex);
            return false;
        }
    }

    public async Task<bool> RemoveAsync(Employee obj)
    {
        obj.IsDeleted = true;
        return await UpdateAsync(obj);
    }

    public async Task<bool> UpdateAsync(Employee obj)
    {
        try
        {
            _context.Employees.Update(obj);
            await SaveChangeAsync();
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
