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
    public class TaahhutProjeTakibiValidator : AbstractValidator<TaahhutProjeTakibi>
    {
        private readonly IUnitOfWork _unitOfWork;

        public TaahhutProjeTakibiValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
           
            RuleFor(x => x.Seri)
               .NotEmpty().WithMessage("Bu alan boş bırakılamaz.");
            RuleFor(x => x.CHKKodu)
               .NotEmpty().WithMessage("Bu alan boş bırakılamaz.");
            RuleFor(x => x.CHKAdi)
               .NotEmpty().WithMessage("Bu alan boş bırakılamaz.");
            RuleFor(x => x.Tarih)
                 .Must(BeAValidDate).WithMessage("Tarih alanı boş bırakılamaz.");
            
        }
        private bool BeAValidDate(DateTime date)
        {
            if (date == default(DateTime))
                return false;
            return true;
        }
    }
}
