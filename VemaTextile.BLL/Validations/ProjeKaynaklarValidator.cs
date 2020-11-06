using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VemaTextile.Repository.Repositories.Abstracts;
using FluentValidation;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;


namespace VemaTextile.BLL.Validations
{
    public class ProjeKaynaklarValidator : AbstractValidator<ProjeKaynaklar>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProjeKaynaklarValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.Aciklama)
                .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.HesapKodu)
                .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.HesapAdi)
                .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.EvrakNo)
                .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.ProjeNo)
                .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.GorevAdi)
                .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Kaydeden)
                .NotNull().WithMessage("Bu alan boş geçilemez");



        }
        private bool BeAValidDate(DateTime date)
        {
            if (date == default(DateTime))
                return false;
            return true;
        }
    }
}
