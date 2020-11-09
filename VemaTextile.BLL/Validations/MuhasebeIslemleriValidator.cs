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
    public class MuhasebeIslemleriValidator : AbstractValidator<MuhasebeIslemleri>
    {
        private readonly IUnitOfWork _unitOfWork;

        public MuhasebeIslemleriValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.HesapKodu)
                .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.FisNo)
               .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.MaddeNo)
               .NotNull().WithMessage("Bu alan boş geçilemez");

        }
    }

}
