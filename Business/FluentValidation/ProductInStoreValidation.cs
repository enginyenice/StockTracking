using Entities.Concrete;
using FluentValidation;

namespace Business.FluentValidation
{
    public class ProductInStoreValidation : AbstractValidator<ProductInStore>
    {
        public ProductInStoreValidation()
        {
            //ProductId
            RuleFor(productInStore => productInStore.ProductId).NotEmpty().WithMessage("Ürün alanı zorunludur");
            //Stock
            RuleFor(productInStore => productInStore.Stock).NotEmpty().WithMessage("Stok alanı zorunludur");
            //StoreId
            RuleFor(productInStore => productInStore.StoreId).NotEmpty().WithMessage("Depo alanı zorunludur");
        }
    }
}