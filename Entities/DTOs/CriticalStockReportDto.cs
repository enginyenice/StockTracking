using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CriticalStockReportDto
    {
        public string StoreName { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public int CriticalStock { get; set; }
    }
}
