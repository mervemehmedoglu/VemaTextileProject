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
    public class StokKartlariValidator : AbstractValidator<StokKartlari>
    {
        private readonly IUnitOfWork _unitOfWork;

        public StokKartlariValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.MalKodu)
                .NotEmpty().WithMessage("Bu alan boş bırakılamaz.");
            RuleFor(x => x.MalAdi)
                .NotEmpty().WithMessage("Bu alan boş bırakılamaz.");


        }
        
    }

}
