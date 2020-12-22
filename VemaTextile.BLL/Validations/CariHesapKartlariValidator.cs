using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VemaTextile.Repository.Repositories.Abstracts;
using VemaTextile.Entity.Entity;

namespace VemaTextile.BLL.Validations
{
    public class CariHesapKartlariValidator : AbstractValidator<CariHesapKartlari>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CariHesapKartlariValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.HesapAdi)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");

        }
    }
}