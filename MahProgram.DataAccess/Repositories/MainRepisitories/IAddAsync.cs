namespace MahProgram.DataAccess.Repositories.MainRepisitories;

public interface IAddAsync<T> where T : class
{
    public Task<bool> AddAsync(T obj);
}
