using LibraryManagement.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Infrastructure.Repositories;

public class BookRepository : GenericRepository<Book>
{
    public override Book? First(Func<Book, bool> match)
    {
        return _context.Books.Include(book => book.Author)
            .Include(book => book.Genre).FirstOrDefault(match);
    }

    public override IEnumerable<Book> Find(Func<Book, bool> predicate)
    {
        return _context.Books.Include(book => book.Author)
            .Include(book => book.Genre).Where(predicate).ToList();
    }

    public override IEnumerable<Book> GetAll()
    {
        return _context.Books.Include(book => book.Author)
            .Include(book => book.Genre).ToList();
    }
}