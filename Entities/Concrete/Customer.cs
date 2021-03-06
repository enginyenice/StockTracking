﻿using Core.Entities;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        //-Müşteri numarası, Müşteri Firma Adı, Ad, soyad, E-mail, telefon.
        public int Id { get; set; }

        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
    }
}