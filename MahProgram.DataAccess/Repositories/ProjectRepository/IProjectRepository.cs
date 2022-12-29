using MahProgram.DataAccess.Models.ProjectModel;
using MahProgram.DataAccess.Repositories.MainRepisitories;

namespace MahProgram.DataAccess.Repositories.ProjectRepository;

public interface IProjectRepository : 
    IGetAll<Project>,
    IFindAsync<Project, int>,
    IAddAsync<Project>,
    IUpdateAsync<Project>,
    IRemoveAsync<Project>,
    ISaveChangeAsync,
    IAsyncDisposable
{

}
