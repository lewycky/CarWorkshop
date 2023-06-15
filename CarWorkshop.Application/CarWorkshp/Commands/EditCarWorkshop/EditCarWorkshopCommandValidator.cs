using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.CarWorkshp.Commands.EditCarWorkshop
{
    public class EditCarWorkshopCommandValidator :  AbstractValidator<EditCarWorkshopCommand>
    {
        public EditCarWorkshopCommandValidator() 
        {
            RuleFor(c => c.Description)
                .NotEmpty().WithMessage("Wprowadź opis");

            RuleFor(c => c.PhoneNumber)
                .MinimumLength(8)
                .MaximumLength(12);
        }
    }
}
