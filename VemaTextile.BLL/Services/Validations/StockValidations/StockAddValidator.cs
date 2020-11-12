using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VemaTextile.Repository.Repositories.Abstracts;
using FluentValidation;
using VemaTextile.Models.Class;

namespace VemaTextile.BLL.Services.Validations.StockValidations
{
    
    public class StockAddValidator : AbstractValidator<StokKartlari>
    {
        private readonly IUnitOfWork _unitOfWork;

        public StockAddValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            RuleFor(x => x.UreticiUnvan)
                .NotNull().WithMessage("Üreteci Ünvanı Boş Geçilemez...");
                
        }

}
}
