using LibraryManagement.Infrastructure.Entities;

namespace LibraryManagement.Infrastructure;

public static class FactoryPattern
{
    public static LibraryContext CreateLibraryContext()
    {
        return new LibraryContext();
    }
}