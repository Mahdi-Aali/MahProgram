namespace MahProgram.DataAccess.Repositories.MainRepisitories;

public interface IFindAsync<T, TKey> where T : class
{
    public Task<T> FindAsync(TKey key);
}
