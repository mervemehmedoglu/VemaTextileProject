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
    public class ProjeGorevlerValidator : AbstractValidator<ProjeGorevler>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProjeGorevlerValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.EvrakNo)
                .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.TaskName)
                .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.EvrakNo)
                .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.EvrakNo)
                .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.EvrakNo)
                .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.TaskStartTime)
                 .Must(BeAValidDate).WithMessage("Tarih alanı boş bırakılamaz.");
            RuleFor(x => x.TaskFinishTime)
                .Must(BeAValidDate).WithMessage("Tarih alanı boş bırakılamaz.");
            RuleFor(x => x.BaslangicPlanTarihi)
                .Must(BeAValidDate).WithMessage("Tarih alanı boş bırakılamaz.");
            RuleFor(x => x.BitisPlanTarihi)
                .Must(BeAValidDate).WithMessage("Tarih alanı boş bırakılamaz.");
            RuleFor(x => x.Usta)
               .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Planlama)
               .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.TaskDuration)
               .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Onculler)
               .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.OnculTask)
               .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Kullanan)
               .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Kullanan2)
               .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Durum)
               .NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Okundu)
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
