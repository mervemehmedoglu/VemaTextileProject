﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VemaTextile.Repository.Repositories.Abstracts;
using VemaTextile.Entity.Entity;



namespace VemaTextile.BLL.Validations
{
    public class VerilenSenetlerValidator : AbstractValidator<VerilenSenetler>
    {
        private readonly IUnitOfWork _unitOfWork;

        public VerilenSenetlerValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.VadeTarihi)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
            RuleFor(x => x.EvrakNo)
                .NotEmpty().WithMessage("Kategori Adı alanı boş bırakılamaz.");
        }
    }
}
