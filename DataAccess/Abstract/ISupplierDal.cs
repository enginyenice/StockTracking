using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ISupplierDal : IEntityRepository<Supplier>
    {
    }
}