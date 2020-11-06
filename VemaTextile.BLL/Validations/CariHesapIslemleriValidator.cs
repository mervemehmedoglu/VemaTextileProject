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
    public class CariHesapIslemleriValidator : AbstractValidator<CariHesapİslemleri>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CariHesapIslemleriValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.IslemTuru)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.KaynakEvrakTipi)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.HesapKodu)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.HesapAdi)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.Kaydeden)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            


        }
        private bool BeAValidDate(DateTime date)
        {
            if (date == default(DateTime))
                return false;
            return true;
        }

    }
}
