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
    public class OdemePlaniValidator : AbstractValidator<OdemePlani>
    {
        private readonly IUnitOfWork _unitOfWork;

        public OdemePlaniValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.HesapKodu)
                .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.OdemeTarihi)
                 .Must(BeAValidDate).WithMessage("Odeme Tarihi alanı boş bırakılamaz.");
        }
        private bool BeAValidDate(DateTime date)
        {
            if (date == default(DateTime))
                return false;
            return true;
        }
    }
}
