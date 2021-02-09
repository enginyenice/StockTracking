using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStockMovementService
    {
        List<StockMovement> GetAll();
        StockMovement Get(int id);
        string Add(StockMovement entity);
        string Delete(int id);
        string Update(StockMovement entity);
    }
}
