namespace MahProgram.DataAccess.Repositories.MainRepisitories;

public interface IGetAll<T> where T : class
{
    public IQueryable<T> GetAll();
}
