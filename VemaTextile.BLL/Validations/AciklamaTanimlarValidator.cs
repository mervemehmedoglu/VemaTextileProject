using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VemaTextile.Entity.Entity;
using FluentValidation;


namespace VemaTextile.BLL.Validations
{
    public class AciklamaTanimlarValidator : AbstractValidator<AciklamaTanimlar>
    {
        public AciklamaTanimlarValidator()
        {
            RuleFor(x => x.Parametre1)
                .NotNull().WithMessage("Parametre alanı boş geçilemez")
                .NotEmpty().WithMessage("Parametre alanı boş geçilemez.")
                .MaximumLength(50).WithMessage("Karakter uzunluğu maksimum 50 olmalıdır.");
                
            RuleFor(x => x.Parametre2)
                .NotEmpty().WithMessage("Parametre alanı boş geçilemez.")
                .NotNull().WithMessage("Parametre alanı boş geçilemez.")
                .MaximumLength(50).WithMessage("Karakter uzunluğu maksimum 50 olmalıdır."); ;

            
               
        }
    }
}
