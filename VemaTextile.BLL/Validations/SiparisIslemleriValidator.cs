using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using VemaTextile.Entity.Entity;

using VemaTextile.Repository.Repositories.Abstracts;

namespace VemaTextile.BLL.Validations
{
    public class SiparisIslemleriValidator : AbstractValidator<SiparisIslemleri>
    {
        private readonly IUnitOfWork _unitOfWork;

        public SiparisIslemleriValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.MalKodu)
                .NotEmpty().WithMessage("Bu alan boş bırakılamaz.");
            RuleFor(x => x.MalAdi)
               .NotEmpty().WithMessage("Bu alan boş bırakılamaz.");
            RuleFor(x => x.Tarih)
                 .Must(BeAValidDate).WithMessage("Odeme Tarihi alanı boş bırakılamaz.");
            RuleFor(x => x.EvrakNo)
               .NotEmpty().WithMessage("Bu alan boş bırakılamaz.");
            RuleFor(x => x.Seri)
               .NotEmpty().WithMessage("Bu alan boş bırakılamaz.");
            RuleFor(x => x.IslemTipi)
               .NotEmpty().WithMessage("Bu alan boş bırakılamaz.");
            RuleFor(x => x.IslemTuru)
               .NotEmpty().WithMessage("Bu alan boş bırakılamaz.");
            RuleFor(x => x.CHKKodu)
               .NotEmpty().WithMessage("Bu alan boş bırakılamaz.");
            RuleFor(x => x.CHKAdi)
               .NotEmpty().WithMessage("Bu alan boş bırakılamaz.");
            RuleFor(x => x.KaynakEvrakTipi)
               .NotEmpty().WithMessage("Bu alan boş bırakılamaz.");
            RuleFor(x => x.Kaydeden)
               .NotEmpty().WithMessage("Bu alan boş bırakılamaz.");
        }
        private bool BeAValidDate(DateTime date)
        {
            if (date == default(DateTime))
                return false;
            return true;
        }
    }
}
