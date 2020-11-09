using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VemaTextile.Repository.Repositories.Abstracts;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.BLL.Validations
{
    public class MuhasebeMasrafMerkeziKartlariValidator : AbstractValidator<MuhasebeMasrafMerkeziKartlari>
    {
        private readonly IUnitOfWork _unitOfWork;

        public MuhasebeMasrafMerkeziKartlariValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.HesapKodu)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
        }
    }
}
