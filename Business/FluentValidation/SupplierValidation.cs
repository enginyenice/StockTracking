using Entities.Concrete;
using FluentValidation;

namespace Business.FluentValidation
{
    public class SupplierValidation : AbstractValidator<Supplier>
    {
        public SupplierValidation()
        {
            //CompanyName
            RuleFor(supplier => supplier.CompanyName).NotEmpty().WithMessage("Firma adı alanı zorunludur");
            //Email
            RuleFor(supplier => supplier.EMail).NotEmpty().WithMessage("E-Posta alanı zorunludur");
            RuleFor(supplier => supplier.EMail).EmailAddress().WithMessage("Geçerli bir E-Posta adresi giriniz");
            //PhoneNumber
            RuleFor(supplier => supplier.PhoneNumber).NotEmpty().WithMessage("Telefon Numarası alanı zorunludur");
        }
    }
}