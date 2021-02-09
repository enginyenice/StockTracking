using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class StockMovement : IEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int MemberNumber { get; set; }
        public int ProductId { get; set; }
        public int Piece { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime TransactionDate { get; set; }

    }
}
