using CarSite.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSite.Business.ValidationRules.FluentValidation
{
    public class Tb_Ads_Validator:AbstractValidator<TB_Ads>
    {
        public Tb_Ads_Validator()
        {
            RuleFor(t => t.City).NotNull().WithMessage("City cannot be empty");
        }
    }
}
