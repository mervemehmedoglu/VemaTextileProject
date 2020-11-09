using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;
using VemaTextile.Repository.Repositories.Abstracts;

namespace VemaTextile.BLL.Validations
{
    public class SilinenKayitlarValidator : AbstractValidator<SilinenKayitlar>
    {
        private readonly IUnitOfWork _unitOfWork;

        public SilinenKayitlarValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.EvrakNo)
                .NotEmpty().WithMessage("Bu alan boş bırakılamaz.");
           


        }
    }
}
