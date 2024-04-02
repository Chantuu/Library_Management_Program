using LibraryManagement.Infrastructure.Entities;

namespace LibraryManagement.Infrastructure.Repositories;

public class GenericRepository<T> : IRepository<T>, IDisposable
where T : class
{
    readonly LibraryContext _context;
    
    public GenericRepository()
    {
        _context = FactoryPattern.CreateLibraryContext();
    }
    
    public virtual void Add(T entity)
    {
        _context.Add(entity);
    }

    public virtual void Update(T entity)
    {
        _context.Update(entity);
    }

    public virtual T? Get(int id)
    {
        return _context.Find<T>(id);
    }

    public virtual T? First(Func<T, bool> match)
    {
        return _context.Set<T>().FirstOrDefault(match);
    }

    public virtual IEnumerable<T> Find(Func<T, bool> predicate)
    {
        return _context.Set<T>().Where(predicate);
    }

    public virtual IEnumerable<T> GetAll()
    {
        return _context.Set<T>();
    }

    public virtual void Delete(T entity)
    {
        _context.Remove(entity);
    }

    public virtual void SaveChanges()
    {
        _context.SaveChanges();
    }
    
    public virtual void Dispose()
    {
        _context.Dispose();
    }
}
