using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBuyOrSellService
    {
        string Buy(ProductInStore productInStore, StockMovement stockMovement);

        string Sell(ProductInStore productInStore, StockMovement stockMovement);
    }
}