using Core.Entities;

namespace Entities.Concrete
{
    public class ProductInStore : IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public int Stock { get; set; }
    }
}