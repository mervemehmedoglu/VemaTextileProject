using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VemaTextile.Models.Class;
using VemaTextile.Repository.Repositories.Abstracts;
using FluentValidation;
using VemaTextile.Entity.Entity;

namespace VemaTextile.BLL.Validations
{
    public class SayimİslemleriValidator : AbstractValidator<Sayimİslemleri>
    {
        private readonly IUnitOfWork _unitOfWork;

        public SayimİslemleriValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.MalAdi)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.EvrakNo)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.Seri)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.IslemTuru)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.IslemTuru)
               .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.CHKAdi)
               .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.BirimMiktar)
               .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.Miktar)
               .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.KaynakEvrakTipi)
               .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.Depo)
               .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");


        }
    }
}
