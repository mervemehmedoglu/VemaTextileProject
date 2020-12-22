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
    public class MuhasebeHesapKartlariValidator : AbstractValidator<MuhasebeHesapKartlari>
    {
        private readonly IUnitOfWork _unitOfWork;

        public MuhasebeHesapKartlariValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.HesapKodu)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
        }
    }
}
