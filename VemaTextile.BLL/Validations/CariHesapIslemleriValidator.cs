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
    public class CariHesapIslemleriValidator : AbstractValidator<CariHesapİslemleri>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CariHesapIslemleriValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.IslemTuru)
                .NotNull().WithMessage("Parametre alanı boş geçilemez");
            RuleFor(x => x.KaynakEvrakTipi)
                 .NotNull().WithMessage("Parametre alanı boş geçilemez");
            RuleFor(x => x.HesapKodu)
                 .NotNull().WithMessage("Parametre alanı boş geçilemez");
            RuleFor(x => x.HesapAdi)
                .NotNull().WithMessage("Parametre alanı boş geçilemez");
            RuleFor(x => x.Kaydeden)
                .NotNull().WithMessage("Parametre alanı boş geçilemez");
        }
        

    }
}
