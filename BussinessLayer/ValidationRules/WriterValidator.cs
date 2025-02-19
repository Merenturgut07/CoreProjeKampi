using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x=>x.WriterName).NotEmpty().WithMessage("Yazar Adı Soyadı Kısımı Boş Geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter veri girişi yapınız");
            RuleFor(x => x.WriterName).MaximumLength(40).WithMessage("Lütfen en fazla 40 karakter veri  girişi yapınız");
            RuleFor(x=>x.WriterMail).NotEmpty().WithMessage("Mail Adresi Boş Geçilemez");
            RuleFor(x => x.WriterPassword)
                .NotEmpty().WithMessage("Şifre boş geçilemez")
                .MinimumLength(6).WithMessage("Şifre en az 6 karakter olmalıdır")
                .Matches(@"[A-Z]").WithMessage("Şifre en az bir büyük harf içermelidir")
                .Matches(@"[a-z]").WithMessage("Şifre en az bir küçük harf içermelidir")
                .Matches(@"\d").WithMessage("Şifre en az bir rakam içermelidir");

            RuleFor(x => x.WriterPasswordConfirm)
                .NotEmpty().WithMessage("Şifre tekrarını boş geçilemez")
                .Equal(x => x.WriterPassword).WithMessage("Şifreler eşleşmiyor");


        }
    }
}
