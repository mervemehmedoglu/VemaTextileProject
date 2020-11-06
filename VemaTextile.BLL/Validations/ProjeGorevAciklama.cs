using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VemaTextile.Entity.Entity;
using VemaTextile.Repository.Repositories.Abstracts;

namespace VemaTextile.BLL.Validations
{
    public class ProjeGorevAciklamaValidator : AbstractValidator<ProjeGorevAciklama>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProjeGorevAciklamaValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.Kullanan)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");

        }
    }
}
