using MahProgram.DataAccess.Models.ContactUsModel;
using MahProgram.DataAccess.Repositories.MainRepisitories;

namespace MahProgram.DataAccess.Repositories.ContactUsAnswereRepositories;

public interface IContactUsAnswereRepository : IAddAsync<ContactUsAnswere>, ISaveChangeAsync, IAsyncDisposable
{
    public Task<bool> SendAnswereAsync(ContactUsAnswere contactUsAnswere, string to);
}
