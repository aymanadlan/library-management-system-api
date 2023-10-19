using library_management_system_api.Data.Base;

namespace library_management_system__api.Models
{
    public class Book : IEntityBase
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
    }
}
