using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Supplier :IEntity
    {
        //-Tedarikçi numarası, Tedarikçi Firma Adı, E-mail, telefon
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
    }
}
