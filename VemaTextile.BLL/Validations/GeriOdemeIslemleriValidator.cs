using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VemaTextile.Repository.Repositories.Abstracts;
using FluentValidation;
using VemaTextile.Entity.Entity;


namespace VemaTextile.BLL.Validations
{
    public class GeriOdemeIslemleriValidator : AbstractValidator<GeriOdemeIslemleri>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GeriOdemeIslemleriValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.HesapKodu)
                .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.BankaHesapKodu)
                 .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.EvrakNo)
                 .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.TahsilatTipi)
                .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.VadeTarihi)
                .Must(BeAValidDate).WithMessage("Vade Tarihi alanı boş bırakılamaz.");
        }
        private bool BeAValidDate(DateTime date)
        {
            if (date == default(DateTime))
                return false;
            return true;
        }

    }
}
