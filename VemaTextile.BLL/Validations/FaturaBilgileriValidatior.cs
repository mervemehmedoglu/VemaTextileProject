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
    public class FauraBilgileriValidator : AbstractValidator<FaturaBilgileri>
    {
        private readonly IUnitOfWork _unitOfWork;

        public FauraBilgileriValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            

            _unitOfWork = unitOfWork;
            RuleFor(x => x.Tıp)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");

            _unitOfWork = unitOfWork;
            RuleFor(x => x.KaynakEvrakTipi)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");





        }
    }
}