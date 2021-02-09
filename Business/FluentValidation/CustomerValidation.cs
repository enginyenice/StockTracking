using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Business.FluentValidation
{
    public class CustomerValidation : AbstractValidator<Customer>
    {
        public CustomerValidation()
        {
            //FirstName
            RuleFor(customer => customer.FirstName).NotEmpty().WithMessage("Ad alanı zorunludur");
            RuleFor(customer => customer.FirstName).Must(IsNameValid).WithMessage("Ad alanı sadece harften oluşmalıdır.");
            //LastName
            RuleFor(customer => customer.LastName).NotEmpty().WithMessage("Soyad alanı zorunludur");
            RuleFor(customer => customer.LastName).Must(IsNameValid).WithMessage("Soyad alanı sadece harften oluşmalıdır.");
            //CompanyName
            RuleFor(customer => customer.CompanyName).NotEmpty().WithMessage("Firma adı alanı zorunludur");
            //Email
            RuleFor(customer => customer.EMail).NotEmpty().WithMessage("E-Posta alanı zorunludur");
            RuleFor(customer => customer.EMail).EmailAddress().WithMessage("Geçerli bir E-Posta adresi giriniz");
            //PhoneNumber
            RuleFor(customer => customer.PhoneNumber).NotEmpty().WithMessage("Telefon Numarası alanı zorunludur");
        }
        private bool IsNameValid(string arg)
        {
            try
            {
                Regex regex = new Regex(@"^[a-zA-Z ]*$");
                return regex.IsMatch(arg);
            }
            catch
            {
                return false;
            }
        }
    }
}
