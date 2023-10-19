using library_management_system__api.Models;
using library_management_system_api.Data.Base;

namespace library_management_system_api.Data.Services
{
    public interface IBooksService: IEntityBaseRepository<Book>
    {
    }
}
