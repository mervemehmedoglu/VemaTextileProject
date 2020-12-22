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
    public class EylemVeGorevlerValidator : AbstractValidator<EylemVeGorevler>
    {
        private readonly IUnitOfWork _unitOfWork;

        public EylemVeGorevlerValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            
            RuleFor(x => x.ChkAdi)
                 .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.EylemGorev)
                 .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Kaydeden)
                .NotNull().WithMessage("Bu alan boş geçilemez");  
        }
       

    }
}
