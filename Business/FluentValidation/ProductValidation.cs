using Entities.Concrete;
using FluentValidation;

namespace Business.FluentValidation
{
    public class ProductValidation : AbstractValidator<Product>
    {
        public ProductValidation()
        {
            //Type
            RuleFor(product => product.Type).NotEmpty().WithMessage("Cins alanı zorunludur");

            //Unit
            RuleFor(product => product.Unit).NotEmpty().WithMessage("Birim alanı zorunludur");

            //Description
            RuleFor(product => product.Description).NotEmpty().WithMessage("Açıklama alanı zorunludur");

            //Image
            RuleFor(product => product.Image).NotEmpty().WithMessage("Resim alanı zorunludur");

            //CriticalStock
            RuleFor(product => product.CriticalStock).NotEmpty().WithMessage("Kritik stok miktarı zorunludur");
            RuleFor(product => product.CriticalStock).InclusiveBetween(0, int.MaxValue).WithMessage("Kritik stok miktarı 0 dan büyük bir değer olmalıdır.");
        }
    }
}