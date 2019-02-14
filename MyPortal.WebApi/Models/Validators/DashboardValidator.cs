using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortal.WebApi.Models.Validators
{
    public class DashboardValidator:AbstractValidator<CreateDashBoard>
    {
        public DashboardValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Description).MaximumLength(100);
        }
    }
}
