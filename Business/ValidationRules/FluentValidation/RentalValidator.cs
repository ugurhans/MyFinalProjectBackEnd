using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrate;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.CarID).NotEmpty();
            RuleFor(r => r.ReturnDate).GreaterThan(r => r.RentDate);
        }
    }
}
