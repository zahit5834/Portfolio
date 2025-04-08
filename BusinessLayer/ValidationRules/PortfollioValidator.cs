using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfollioValidator : AbstractValidator<Portfollio>
    {
        public PortfollioValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Portföy adını boş geçemezsiniz.");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Lütfen en az 5 karakter girişi yapın.");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Lütfen 100 karakterden fazla değer girişi yapmayın.");
            RuleFor(x=>x.ImageUrl).NotNull().WithMessage("Resim Url alanını boş geçemezsiniz.");
            RuleFor(x => x.ImageUrl2).NotNull().WithMessage("Resim Url alanını boş geçemezsiniz.");
            RuleFor(x => x.ProjectUrl).NotNull().WithMessage("Proje Url alanını boş geçemezsiniz.");
            RuleFor(x=>x.Price).NotNull().WithMessage("Fiyat alanını boş geçemezsiniz.");
            RuleFor(x => x.Value).NotNull().WithMessage("Değer alanını boş geçemezsiniz.");
        }
    }
}
