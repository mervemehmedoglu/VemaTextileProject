using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;
using VemaTextile.Repository.Repositories.Abstracts;

namespace VemaTextile.BLL.Validations
{
    public class ProjeTakibiValidator : AbstractValidator<ProjeTakibi>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProjeTakibiValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.EvrakNo)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.Seri)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.CHKKodu)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.CHKAdi)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");


        }
    }
}
