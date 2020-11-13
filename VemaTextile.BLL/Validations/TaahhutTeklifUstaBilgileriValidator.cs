﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;
using VemaTextile.Repository.Repositories.Abstracts;

namespace VemaTextile.BLL.Validations
{
    public class TaahhutTeklifUstaBilgileriValidator : AbstractValidator<TaahhutTeklifUstaBilgileri>
    {
        private readonly IUnitOfWork _unitOfWork;

        public TaahhutTeklifUstaBilgileriValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.EvrakNo)
                .NotEmpty().WithMessage("Bu alan boş bırakılamaz.");
            RuleFor(x => x.UstaKodu)
               .NotEmpty().WithMessage("Bu alan boş bırakılamaz.");
            RuleFor(x => x.UstaAdi)
               .NotEmpty().WithMessage("Bu alan boş bırakılamaz.");
           
        }
        private bool BeAValidDate(DateTime date)
        {
            if (date == default(DateTime))
                return false;
            return true;
        }
    }
}