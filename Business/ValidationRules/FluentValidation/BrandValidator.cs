﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrate;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.BrandName).MinimumLength(2);
            RuleFor(b => b.BrandName).NotEmpty();
        }
    }
}
