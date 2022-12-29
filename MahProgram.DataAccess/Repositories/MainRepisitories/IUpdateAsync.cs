namespace MahProgram.DataAccess.Repositories.MainRepisitories;

public interface IUpdateAsync<T> where T : class
{
    public Task<bool> UpdateAsync(T obj);
}
