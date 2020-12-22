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
    public class MuhasebeIsletmeKodlariValidator : AbstractValidator<MuhasebeIsletmeKodlari>
    {
        private readonly IUnitOfWork _unitOfWork;

        public MuhasebeIsletmeKodlariValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.HesapKodu)
                .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.DBTutar)
               .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.DBKdv)
               .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.DBMiktar)
               .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.DSTutar)
               .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.DSKdv)
               .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.DSMiktar)
               .NotNull().WithMessage("Bu alan boş geçilemez"); 
        }
    }
}
