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
    public class TahsilatPlaniValidator : AbstractValidator<TahsilatPlani>
    {
        private readonly IUnitOfWork _unitOfWork;

        public TahsilatPlaniValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.OdemeTarihi)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
           

        }
    }
}
