using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığını Boş Geçemezsiniz");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Lütfen 150 karakterden daha az veri girişi yapın ");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Lütfen en az  5 karakterli  veri girişi yapın ");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog İçeriğini Boş Geçemezsiniz");
            RuleFor(x => x.BlogContent).MaximumLength(150).WithMessage("Lütfen 150 karakterden daha az veri girişi yapın ");
            RuleFor(x => x.BlogContent).MinimumLength(5).WithMessage("Lütfen en az  5 karakterli  veri girişi yapın ");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog Görselini Boş Geçemezsiniz");
        }
    }
}
