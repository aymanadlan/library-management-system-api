using library_management_system__api.Data;
using library_management_system__api.Models;
using library_management_system_api.Data.Base;

namespace library_management_system_api.Data.Services
{
    public class BooksService : EntityBaseRepository<Book> , IBooksService
    {
        public BooksService(AppDbContext context) : base(context) { }

    }
}
