using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VemaTextile.Entity.Entity;
using VemaTextile.Repository.Repositories.Abstracts;
using FluentValidation;


namespace VemaTextile.BLL.Validations
{
    
    public class AlinanCeklerAddValidator : AbstractValidator<AlinanCekler>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AlinanCeklerAddValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.VadeTarihi)
                .Must(BeAValidDate).WithMessage("Vade Tarihi alanı boş bırakılamaz.");
        }
        private bool BeAValidDate(DateTime date)
        {
            if (date == default(DateTime))
                return false;
            return true;
        }

    }
}
