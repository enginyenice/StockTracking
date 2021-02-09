using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBuyOrSellService
    {
        string Buy(ProductInStore productInStore, StockMovement stockMovement);
        string Sell(ProductInStore productInStore, StockMovement stockMovement);
        
    }
}
