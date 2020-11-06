using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VemaTextile.Repository.Repositories.Abstracts;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.BLL.Validations
{
    public class ProjeKategorilerValidator : AbstractValidator<ProjeKategoriler>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProjeKategorilerValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.EvrakNo)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.ProjectKey)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.TaskName)
               .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.TaskDuration)
               .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.Onculler)
               .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.TaskPercentComplete)
               .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.Constraint)
              .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.MilesStone)
              .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.OnculTask)
             .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.Kullanan)
            .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.Gun2)
            .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.Gun3)
           .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.ConstraintDateTime)
           .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.SonTarih)
           .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.SiraNo)
          .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
        }
    }
}
