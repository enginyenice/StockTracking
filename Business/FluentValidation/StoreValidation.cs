using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.FluentValidation
{
    class StoreValidation : AbstractValidator<Store>
    {
        public StoreValidation()
        {

                //Name
                RuleFor(store => store.Name).NotEmpty().WithMessage("Depo adı alanı zorunludur");
                //Address
                RuleFor(store => store.Address).NotEmpty().WithMessage("Address alanı zorunludur");
                //PhoneNumber
                RuleFor(store => store.PhoneNumber).NotEmpty().WithMessage("Telefon Numarası alanı zorunludur");
            
        }
    }
}
