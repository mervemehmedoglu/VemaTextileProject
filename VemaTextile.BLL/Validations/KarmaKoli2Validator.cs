using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VemaTextile.Repository.Repositories.Abstracts;
using FluentValidation;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.BLL.Validations
{
    public class KarmaKoli2Validator : AbstractValidator<KarmaKoli2>
    {
        private readonly IUnitOfWork _unitOfWork;

        public KarmaKoli2Validator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.MalKodu)
                .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.MalAdi)
                 .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.EvrakNo)
                 .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Seri)
                .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.IslemTuru)
                .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.KaynakEvrakTipi)
                .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Kaydeden)
                .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.IDMailKodu)
                .NotNull().WithMessage("Bu alan boş geçilemez");
        }
        private bool BeAValidDate(DateTime date)
        {
            if (date == default(DateTime))
                return false;
            return true;
        }

    }
}
