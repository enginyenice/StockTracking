using Entities.Concrete;
using FluentValidation;

namespace Business.FluentValidation
{
    public class StockMovementValidation : AbstractValidator<StockMovement>
    {
        public StockMovementValidation()
        {
            //MemberNumber
            RuleFor(stockMovement => stockMovement.MemberNumber).NotEmpty().WithMessage("Müşteri/Tedarikçi alanı zorunludur");
            //Piece
            RuleFor(stockMovement => stockMovement.Piece).NotEmpty().WithMessage("Adet alanı zorunludur");
            //UnitPrice
            RuleFor(stockMovement => stockMovement.UnitPrice).NotEmpty().WithMessage("Birim fiyat alanı zorunludur");
            //TotalPrice
            RuleFor(stockMovement => stockMovement.TotalPrice).NotEmpty().WithMessage("Toplam fiyat alanı zorunludur");
            //ProductId
            RuleFor(stockMovement => stockMovement.ProductId).NotEmpty().WithMessage("Ürün alanı zorunludur");
        }
    }
}