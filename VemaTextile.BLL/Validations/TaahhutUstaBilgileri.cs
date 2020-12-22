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
    public class TaahhutUstaBilgileriValidator : AbstractValidator<TaahhutUstaBilgileri>
    {
        private readonly IUnitOfWork _unitOfWork;

        public TaahhutUstaBilgileriValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.EvrakNo)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.UstaAdi)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.Tıp)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.HakedisEvrakNo)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.BaslangicTarihi)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.BitisTarihi)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");


        }
    }
}
