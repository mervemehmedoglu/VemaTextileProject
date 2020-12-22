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
    public class SonEvrakNotlarValidator : AbstractValidator<SonEvrakNotlar>
    {
        private readonly IUnitOfWork _unitOfWork;

        public SonEvrakNotlarValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.Kaydeden)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.KaynakEvrakTipi)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.EvrakNo)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.Seri)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
          
        }
    }
}
