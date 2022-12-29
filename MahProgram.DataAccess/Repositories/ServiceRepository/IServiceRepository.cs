using MahProgram.DataAccess.Models.ServiceModel;
using MahProgram.DataAccess.Repositories.MainRepisitories;

namespace MahProgram.DataAccess.Repositories.ServiceRepository;

public interface IServiceRepository : 
    IGetAll<Service>,
    IFindAsync<Service, int>,
    IAddAsync<Service>,
    IUpdateAsync<Service>,
    IRemoveAsync<Service>,
    ISaveChangeAsync,
    IAsyncDisposable
{
    
}
