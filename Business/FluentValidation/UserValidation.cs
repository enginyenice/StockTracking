using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Business.FluentValidation
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            //FirstName
            RuleFor(user => user.FirstName).NotEmpty().WithMessage("Ad alanı zorunludur");
            RuleFor(user => user.FirstName).Must(IsNameValid).WithMessage("Ad alanı sadece harften oluşmalıdır.");
            //LastName
            RuleFor(user => user.LastName).NotEmpty().WithMessage("Soyad alanı zorunludur");
            RuleFor(user => user.LastName).Must(IsNameValid).WithMessage("Soyad alanı sadece harften oluşmalıdır.");
            //UserName
            RuleFor(user => user.UserName).NotEmpty().WithMessage("Kullanıcı adı alanı zorunludur");
            //Email
            RuleFor(user => user.EMail).NotEmpty().WithMessage("E-Posta alanı zorunludur");
            RuleFor(user => user.EMail).EmailAddress().WithMessage("Geçerli bir E-Posta adresi giriniz");
            //Password
            RuleFor(user => user.Password).NotEmpty().WithMessage("Şifre alanı zorunludur");
            //PhoneNumber
            RuleFor(user => user.PhoneNumber).NotEmpty().WithMessage("Telefon Numarası alanı zorunludur");
            
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
