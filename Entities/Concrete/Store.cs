using Core.Entities;

namespace Entities.Concrete
{
    public class Store : IEntity
    {
        //-Depo numarası, Depo Adı, Depo Adres, Depo telefon.
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}