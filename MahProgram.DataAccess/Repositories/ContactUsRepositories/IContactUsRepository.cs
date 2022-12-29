using MahProgram.DataAccess.Models.ContactUsModel;
using MahProgram.DataAccess.Repositories.MainRepisitories;

namespace MahProgram.DataAccess.Repositories.ContactUsRepositories;

public interface IContactUsRepository : 
    IAddAsync<ContactUs>,
    IGetAll<ContactUs>,
    IFindAsync<ContactUs, int>,
    IUpdateAsync<ContactUs>,
    IRemoveAsync<ContactUs>,
    ISaveChangeAsync,
    IAsyncDisposable
{}