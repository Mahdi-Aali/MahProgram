using MahProgram.DataAccess.Models.EmployeeModel;
using MahProgram.DataAccess.Repositories.MainRepisitories;

namespace MahProgram.DataAccess.Repositories.EmployeeRepository;

public interface IEmployeeRepository : 
    IGetAll<Employee>, 
    IFindAsync<Employee, int>,
    IAddAsync<Employee>,
    IRemoveAsync<Employee>,
    IUpdateAsync<Employee>,
    ISaveChangeAsync,
    IAsyncDisposable
{}