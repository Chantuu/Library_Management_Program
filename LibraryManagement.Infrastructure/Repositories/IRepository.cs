namespace LibraryManagement.Infrastructure.Repositories;

public interface IRepository<T>
{
    void Add(T entity);
    void Update(T entity);
    T Get(int id);
    T First(Func<T, bool> match);
    IEnumerable<T> Find(Func<T, bool> predicate);
    IEnumerable<T> GetAll();
    void Delete(T entity);
    void SaveChanges();
}
