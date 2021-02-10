using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IStockMovementService
    {
        List<StockMovement> GetAll();

        StockMovement Get(int id);

        string Add(StockMovement entity);

        string Delete(int id);

        string Update(StockMovement entity);

        List<ProductReportDto> GetReportData();
    }
}