using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.RetrunDate).NotNull();
            RuleFor(r => r.RetrunDate).GreaterThanOrEqualTo(r => r.RentDate);
        }
    }
}
