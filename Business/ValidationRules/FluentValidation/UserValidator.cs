using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.FirstName).MinimumLength(2);
            RuleFor(u => u.LastName).NotNull();
            RuleFor(u => u.LastName).MinimumLength(2);
            RuleFor(u => u.Email).NotNull();
            RuleFor(u => u.Email).Must(EmailRegex).WithMessage(Messages.EmailErrorMessage);
            RuleFor(u => u.Password).NotNull();
            RuleFor(u => u.Password).MinimumLength(8);
        }

        private bool EmailRegex(string arg)
        {
            return arg.Contains("@");
        }

    }
}
