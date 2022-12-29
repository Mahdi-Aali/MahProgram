namespace MahProgram.DataAccess.Repositories.MainRepisitories;

public interface IRemoveAsync<T> where T : class
{
    public Task<bool> RemoveAsync(T obj);
}
