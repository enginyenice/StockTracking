using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        //Stok Kodu, Cinsi, Birimi, Açıklama, Resim, Kritik Stok Sayısı
        public int Id { get; set; }
        public string Type { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int CriticalStock { get; set; }

    }
}
